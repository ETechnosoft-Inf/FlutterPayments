using EasyPayment.Application.Interfaces;
using EasyPyment.Common.Enum;
using EasyPyment.Common.Models;
using EasyPyment.Common.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Queries
{
    public class GetAllPaymentSetup : IRequest<MessageResponse<List<PaymentSetupDto>>>
    {

    }

    public class GetAllPaymentSetupHandler : IRequestHandler<GetAllPaymentSetup, MessageResponse<List<PaymentSetupDto>>>
    {
        private readonly IEasyPaymentDbContext _dbContext;

        public GetAllPaymentSetupHandler(IEasyPaymentDbContext context)
        {
            _dbContext = context;
        }
        public async Task<MessageResponse<List<PaymentSetupDto>>> Handle(GetAllPaymentSetup request, CancellationToken cancellationToken)
        {
            var response = new MessageResponse<List<PaymentSetupDto>>();
            var settings = await _dbContext.PaymentSetups.ToListAsync();
            //var paymentSetupDto = _mapper.Map<List<PaymentSetupDto>>(settings);

            response.IsSuccessResponse = true;
            response.ResponseCode = (int)ResponseDetail.Successful;
            response.Message = $"{settings.Count} Record(s) selected";
            //response.Result = paymentSetupDto;
            response.Result = settings.Select(c => new PaymentSetupDto
            {
                Id = c.Id,
                TenantAppId = c.TenantAppId,
                ProviderName = c.ProviderName,
                ProviderPublicKey = c.providerPublicKey,
                ProviderSecretKey = c.ProviderSecretKey,
                IsActive = c.IsActive
            }).ToList();

            return response;
        }

    }
}
