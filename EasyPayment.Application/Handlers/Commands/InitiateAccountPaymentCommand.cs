using EasyPayment.Application.Interfaces;
using EasyPayment.Domain.Entities;
using EasyPyment.Common.Enum;
using EasyPyment.Common.Models.RequestModels;
using EasyPyment.Common.Models.ResponseModels;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Commands
{
    public class InitiateAccountPaymentCommand: IRequest<MessageResponse<AccountPaymentResponse>>
    {
        public string tx_ref { get; set; }
        public long amount { get; set; }
        public string account_bank { get; set; }
        public string account_number { get; set; }
        public string currency { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string full_name { get; set; }
        public string TenantAppId { get; set; }
        public int PaymentSetupId { get; set; }
    }

    public class InitiateAccountPaymentCommandValidator : AbstractValidator<InitiateAccountPaymentCommand>
    {
        public InitiateAccountPaymentCommandValidator()
        {
            RuleFor(c => c.account_bank).NotEmpty();
            RuleFor(c => c.account_number).NotEmpty();
            RuleFor(c => c.amount).NotEmpty();
            RuleFor(c => c.currency).NotEmpty();
            RuleFor(c => c.email).NotEmpty().EmailAddress();
            RuleFor(c => c.full_name).NotEmpty();
            RuleFor(c => c.phone_number).NotEmpty();
            RuleFor(c => c.TenantAppId).NotEmpty();
            RuleFor(c => c.PaymentSetupId).NotEmpty();

        }
    }

    public class InitiateAccountPaymentCommandHandler : IRequestHandler<InitiateAccountPaymentCommand, MessageResponse<AccountPaymentResponse>>
    {
                private readonly IEasyPaymentDbContext _dbContext;
                private readonly IHttpClientHelper _httpHelper;
                private readonly IConfiguration _configuration;
                public InitiateAccountPaymentCommandHandler(IEasyPaymentDbContext dbContext, IHttpClientHelper httpHelper, IConfiguration configuration)
                {
                    _dbContext = dbContext;
                    _httpHelper = httpHelper;
                    _configuration = configuration;
                }
       
        public async Task<MessageResponse<AccountPaymentResponse>> Handle(InitiateAccountPaymentCommand request, CancellationToken cancellationToken)
        {
            string txn_Ref = null;
            var response = new MessageResponse<AccountPaymentResponse>();
            var paymentlogexist = await _dbContext.PaymentLogs.FirstOrDefaultAsync(c => c.TenantAppId.ToLower().Equals(request.TenantAppId.ToLower()));
            var paymentId = await _dbContext.PaymentSetups.FirstOrDefaultAsync(c => c.TenantAppId.ToLower().Equals(request.TenantAppId.ToLower()));
            var emailexist = await _dbContext.PaymentLogs.FirstOrDefaultAsync(c => c.Email.ToLower().Equals(request.email.ToLower()));
            if(paymentlogexist == null && emailexist == null)
            {
                txn_Ref = Guid.NewGuid().ToString().Replace("-", "");
                var model = new PaymentLog()
                {
                    PaymentSetupId = paymentId.Id,
                    TenantAppId = request.TenantAppId,
                    Email = request.email,
                    Amount = request.amount,
                    ReferenceNumber = txn_Ref,
                    PaymentDate = DateTime.Now
                };
                _dbContext.PaymentLogs.Add(model);
                await _dbContext.SaveChangesAsync();

                var token = _configuration.GetValue<string>("FlutterwaveService:AccessCode");
                var initiateBaseURL = _configuration.GetValue<string>("FlutterwaveService:BaseUrl");
                var initiateURL = _configuration.GetValue<string>("FlutterwaveService:Initialize");
                var initiatepayment = new AccountPaymentRequestModel()
                {
                    account_bank = request.account_bank,
                    account_number = request.account_number,
                    amount = request.amount,
                    currency = request.currency,
                    email = request.email,
                    full_name = request.full_name,
                    phone_number = request.phone_number,
                    tx_ref = txn_Ref
                };

                var endpointresponse = await _httpHelper.PostAsync<AccountPaymentResponse, AccountPaymentRequestModel>(initiatepayment, $"{initiateBaseURL}/{initiateURL}", token);
                var endpointresponsedata = new AccountPaymentResponse
                {
                    Status = endpointresponse.Status,
                    Message = endpointresponse.Message,
                    Data = new AccountPaymentResponseData
                    {
                        Account = endpointresponse.Data.Account,
                        amount = endpointresponse.Data.amount,
                        account_id = endpointresponse.Data.account_id,
                        app_fee = endpointresponse.Data.app_fee,
                        auth_model = endpointresponse.Data.auth_model,
                        card = endpointresponse.Data.card,
                        charged_amount = endpointresponse.Data.charged_amount,
                        charge_type = endpointresponse.Data.charge_type,
                        CreatedAt = endpointresponse.Data.CreatedAt,
                        currency = endpointresponse.Data.currency,
                        customer = endpointresponse.Data.customer,
                        device_fingerprint = endpointresponse.Data.device_fingerprint,
                        flw_ref = endpointresponse.Data.flw_ref,
                        fraud_status = endpointresponse.Data.fraud_status,
                        id = endpointresponse.Data.id,
                        ip = endpointresponse.Data.ip,
                        merchant_fee = endpointresponse.Data.merchant_fee,
                        Meta = endpointresponse.Data.Meta,
                        narration = endpointresponse.Data.narration,
                        payment_type = endpointresponse.Data.payment_type,
                        processor_response = endpointresponse.Data.processor_response,
                        status = endpointresponse.Data.status
                    }

                };
                response.IsSuccessResponse = true;
                response.Result = endpointresponsedata;
                response.ResponseCode = (int)ResponseDetail.Successful;
                response.Message = "Payment initiated Succesfully";
            }
            else
            {
                response.IsSuccessResponse = false;
                response.Message = "Invalid Details";
                response.ResponseCode = (int)ResponseDetail.Failed;
                response.Result = null;
            }
            return response;
        }
    }
}
