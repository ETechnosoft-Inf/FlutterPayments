using EasyPayment.Application.Interfaces;
using EasyPayment.Domain.Entities;
using EasyPyment.Common.Enum;
using EasyPyment.Common.Models;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Commands
{
    public class CreatePaymentSetupCommand : IRequest<MessageResponse<PaymentSetupDto>>
    {
        public string TenantAppId { get; set; }
        public string ProviderName { get; set; }
        public string providerPublicKey { get; set; }
        public string ProviderSecretKey { get; set; }
    }

    public class CreatePaymentSetupCommandValidator : AbstractValidator<CreatePaymentSetupCommand>
    {
        public CreatePaymentSetupCommandValidator()
        {
            RuleFor(c => c.TenantAppId).NotEmpty();
            RuleFor(c => c.ProviderName).NotEmpty();
            RuleFor(c => c.providerPublicKey).NotEmpty();
            RuleFor(c => c.ProviderSecretKey).NotEmpty();
        }
    }
    public class CreatePaymentSetupCommandHandler : IRequestHandler<CreatePaymentSetupCommand, MessageResponse<PaymentSetupDto>>
    {
        private readonly IEasyPaymentDbContext _dbContext;
        public CreatePaymentSetupCommandHandler(IEasyPaymentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<MessageResponse<PaymentSetupDto>> Handle(CreatePaymentSetupCommand request, CancellationToken cancellationToken)
        {
            var messageResponse = new MessageResponse<PaymentSetupDto>();
            var setup = await _dbContext.PaymentSetups.FirstOrDefaultAsync(c => c.ProviderName.ToLower().Equals(request.ProviderName.ToLower()));
            if (setup != null)
            {
                messageResponse = Util.GetResponse<PaymentSetupDto>(false, "Payment Settings already Exist", null);
            }
            else
            {
                var settings = new PaymentSetup()
                {
                    ProviderName = request.ProviderName,
                    providerPublicKey = request.providerPublicKey,
                    ProviderSecretKey = request.ProviderSecretKey,
                    TenantAppId = request.TenantAppId, 
                    IsActive = true
                };
                _dbContext.PaymentSetups.Add(settings);
                await _dbContext.SaveChangesAsync();

                var setups = await _dbContext.PaymentSetups.FirstOrDefaultAsync(c => c.ProviderName.ToLower().Equals(request.ProviderName.ToLower()));

                var result = new PaymentSetupDto
                {
                    ProviderName = request.ProviderName,
                    ProviderPublicKey = request.providerPublicKey,
                    ProviderSecretKey = request.ProviderSecretKey,
                    TenantAppId = request.TenantAppId,
                    IsActive = true
                };
                messageResponse.IsSuccessResponse = true;
                messageResponse.Result = result;
                messageResponse.ResponseCode = (int)ResponseDetail.Successful;
                messageResponse.Message = "Payment Settings Created Succesfully";
            }
            return messageResponse;

        }
    }
}
