using EasyPayment.Application.Interfaces;
using EasyPayment.Domain.Entities;
using EasyPyment.Common.Enum;
using EasyPyment.Common.Models;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Commands
{
    public class RegisterAppCommand:IRequest<MessageResponse<AppDto>>
    {
        public string AppName { get; set; }
    }

    public class RegisterAppCommandQueryValidator : AbstractValidator<RegisterAppCommand>
    {
        public RegisterAppCommandQueryValidator()
        {
            RuleFor(c => c.AppName).NotEmpty();
        }
    }

    public class RegisterAppCommandQueryHandler : IRequestHandler<RegisterAppCommand, MessageResponse<AppDto>>
    {
        private readonly IEasyPaymentDbContext _dbcontext;
        public RegisterAppCommandQueryHandler(IEasyPaymentDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<MessageResponse<AppDto>> Handle(RegisterAppCommand request, CancellationToken cancellationToken)
        {
            var messageResponse = new MessageResponse<AppDto>();
            var item = await _dbcontext.AppRegistries.FirstOrDefaultAsync(x => x.AppName == request.AppName.ToLower());
            if (item == null)
            {
                var appCode = Guid.NewGuid().ToString().Replace("-", "");
                var appRegistry = new AppRegistry()
                {
                    AppName = request.AppName.ToLower(),
                    AppCode = appCode,
                    IsActive = true
                };
                _dbcontext.AppRegistries.Add(appRegistry);
                await _dbcontext.SaveChangesAsync();
                messageResponse.IsSuccessResponse = true;
                messageResponse.Message = "Successfully created";
                messageResponse.ResponseCode = (int)ResponseDetail.Successful;
                messageResponse.Result = new AppDto()
                {
                    AppCode = appCode, Id = item.Id,
                    AppName = request.AppName.ToLower()
                };
                return messageResponse;

            }
            else
            {
                messageResponse.Result = null;
                messageResponse.IsSuccessResponse = false;
                messageResponse.Message = "Duplicate_Name";
                messageResponse.ResponseCode = (int)ResponseDetail.Failed;
            }
            return messageResponse;

        }
    }
}
