using EasyPyment.Common.Models.ResponseModels;
using EasyPyment.Common.Responses;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Application.Handlers.Commands
{
  public class InitiateRwandaPaymentCommand:IRequest<MessageResponse<RwadaPaymentResponse>>
    {
        public string TxRef { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
        public string Network { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Fullname { get; set; }
    }
    public class InitiateRwandaPaymentCommandValidator : AbstractValidator<InitiateRwandaPaymentCommand>
    {
        
    }

}
