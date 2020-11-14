//using EasyPayment.Application.Interfaces;
//using EasyPyment.Common.Models.ResponseModels;
//using EasyPyment.Common.Responses;
//using FluentValidation;
//using MediatR;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace EasyPayment.Application.Handlers.Commands
//{
//    public class InitiateCardPaymentCommand:IRequest<MessageResponse<InitiateCardPaymentResponse>>
//    {
//        public string card_number { get; set; }
//        public string cvv { get; set; }
//        public string expiry_month { get; set; }
//        public string expiry_year { get; set; }
//        public string currency { get; set; }
//        public string amount { get; set; }
//        public string email { get; set; }
//        public string fullname { get; set; }
//        public string tx_ref { get; set; }
//        public string redirect_url { get; set; }
//        public string TenantAppId { get; set; }
//        public int PaymentSetupId { get; set; }

//    }

//    public class InitiateCardPaymentCommandValidator : AbstractValidator<InitiateCardPaymentCommand>
//    {
//        public InitiateCardPaymentCommandValidator()
//        {
//            RuleFor(c => c.TenantAppId).NotEmpty();
//            RuleFor(c => c.amount).NotEmpty();
//            RuleFor(c => c.card_number).NotEmpty();
//            RuleFor(c => c.currency).NotEmpty();
//            RuleFor(c => c.cvv).NotEmpty();
//            RuleFor(c => c.email).NotEmpty().EmailAddress();
//            RuleFor(c => c.expiry_month).NotEmpty();
//            RuleFor(c => c.expiry_year).NotEmpty();
//            RuleFor(c => c.fullname).NotEmpty();
//            RuleFor(c => c.PaymentSetupId).NotEmpty();
//        }
//    }

//    public class InitiateCardPaymentCommandHandler : IRequestHandler<InitiateCardPaymentCommand, MessageResponse<InitiateCardPaymentResponse>>
//    {
//        private readonly IEasyPaymentDbContext _dbContext;
//        private readonly IHttpClientHelper _httpHelper;
//        private readonly IConfiguration _configuration;
//        public InitiateCardPaymentCommandHandler(IEasyPaymentDbContext dbContext, IHttpClientHelper httpHelper, IConfiguration configuration)
//        {
//            _dbContext = dbContext;
//            _httpHelper = httpHelper;
//            _configuration = configuration;
//        }
//        public async Task<MessageResponse<InitiateCardPaymentResponse>> Handle(InitiateCardPaymentCommand request, CancellationToken cancellationToken)
//        {
//            string trxRef = null;
//            var response = new MessageResponse<InitiateCardPaymentResponse>();
//            var paymentLogExist = await _dbContext.PaymentLogs.f
//        }
//    }

//}
