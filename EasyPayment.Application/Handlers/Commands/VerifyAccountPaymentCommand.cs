using EasyPyment.Common.Models.ResponseModels;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Handlers.Commands
{
    public class VerifyAccountPaymentCommand:IRequest<MessageResponse<VerifyAccountPaymentResponse>>
    {
        public string transaction_id { get; set; }
    }

    public class VerifyAccountPaymentCommandValidator : AbstractValidator<VerifyAccountPaymentCommand>
    {
        public VerifyAccountPaymentCommandValidator()
        {
            RuleFor(c => c.transaction_id).NotEmpty();
        }
    }

    public class VerifyAccountPaymentCommandHandler : IRequestHandler<VerifyAccountPaymentCommand, MessageResponse<VerifyAccountPaymentResponse>>
    {
        public Task<MessageResponse<VerifyAccountPaymentResponse>> Handle(VerifyAccountPaymentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
