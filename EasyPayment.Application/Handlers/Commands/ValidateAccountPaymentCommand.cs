using EasyPayment.Application.Interfaces;
using EasyPyment.Common.Models.RequestModels;
using EasyPyment.Common.Models.ResponseModels;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Commands
{
    public class ValidateAccountPaymentCommand : IRequest<MessageResponse<ValidateAccountResponse>>
    {
        public long otp { get; set; }
        public string flw_ref { get; set; }
        public string type { get; set; }
    }

    public class ValidateAccountPaymentCommandValidator : AbstractValidator<ValidateAccountPaymentCommand>
    {
        public ValidateAccountPaymentCommandValidator()
        {
            RuleFor(c => c.otp).NotEmpty();
            RuleFor(c => c.flw_ref).NotEmpty();
            RuleFor(c => c.type).NotEmpty();
        }
    }

    public class ValidateAccountPaymentCommandHandler : IRequestHandler<ValidateAccountPaymentCommand, MessageResponse<ValidateAccountResponse>>
    {
        private readonly IEasyPaymentDbContext _dbContext;
        private readonly IHttpClientHelper _httpHelper;
        private readonly IConfiguration _configuration;
        public ValidateAccountPaymentCommandHandler(IEasyPaymentDbContext dbContext, IHttpClientHelper httpHelper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _httpHelper = httpHelper;
            _configuration = configuration;
        }
        public Task<MessageResponse<ValidateAccountResponse>> Handle(ValidateAccountPaymentCommand request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
            //var response = new MessageResponse<ValidateAccountResponse>();

            //var token = _configuration.GetValue<string>("FlutterwaveService:AccessCode");
            //var initiateBaseURL = _configuration.GetValue<string>("FlutterwaveService:BaseUrl");
            //var initiateURL = _configuration.GetValue<string>("FlutterwaveService:Initialize");
            //var validatePayment = new ValidateAccountPaymentModel()
            //{
            //    flw_ref = request.flw_ref,
            //    otp = request.otp,
            //    type = request.type
            //};

            //var endpointresponse =
        }
    }
}
