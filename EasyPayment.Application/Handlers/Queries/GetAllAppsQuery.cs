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
    public class GetAllAppsQuery : IRequest<MessageResponse<List<AppDto>>>
    {
    }
    public class GetAllAppsQueryHandler : IRequestHandler<GetAllAppsQuery, MessageResponse<List<AppDto>>>
    {
        private readonly IEasyPaymentDbContext _dbcontext;
        public GetAllAppsQueryHandler(IEasyPaymentDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<MessageResponse<List<AppDto>>> Handle(GetAllAppsQuery request, CancellationToken cancellationToken)
        {
            var response = new MessageResponse<List<AppDto>>();
            var apps = await _dbcontext.AppRegistries.ToListAsync();
            if (apps == null)
            {
                response = Util.GetResponse<List<AppDto>>(false, "No App Found", null);
                response.Result = null;
            }
            else
                response.IsSuccessResponse = true;
            response.Message = $"{apps.Count} Record(s) selected";
            response.ResponseCode = (int)ResponseDetail.Successful;
            response.Result = apps.Select(c => new AppDto { Id = c.Id, AppName = c.AppName, AppCode = c.AppCode, IsActive = c.IsActive }).ToList();
            return response;
        }
    }
}
