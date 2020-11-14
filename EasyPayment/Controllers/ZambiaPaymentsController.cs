using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EasyPayment.Application.Handlers.Commands;
using EasyPyment.Common.Models.ResponseModels;
using EasyPyment.Common.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace EasyPayment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZambiaPaymentsController : BaseController
    {
        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<ZambiaPaymentResponse>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpPost, Route("initiateZambiapayment")]
        public async Task<IActionResult> InitiateAccountPayment([FromBody] InitiateAccountPaymentCommand command)
        {
            try
            {
                var res = await Mediator.Send(command);

                if (res.IsSuccessResponse)
                {
                    return Ok(res);
                }
                else
                {
                    return new BadRequestObjectResult((BaseMessageResponse)res);

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "initiateaccountpayment");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }

        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<ZambiaPaymentResponse>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpPost, Route("validatezambiapayment")]
        public async Task<IActionResult> ValidateAccountPayment([FromBody] ValidateAccountPaymentCommand command)
        {
            try
            {
                var res = await Mediator.Send(command);

                if (res.IsSuccessResponse)
                {
                    return Ok(res);
                }
                else
                {
                    return new BadRequestObjectResult((BaseMessageResponse)res);

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "validateaccountpayment");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }

        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<ZambiaPaymentResponse>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpPost, Route("verifyzambiapayment")]
        public async Task<IActionResult> VerifyAccountPayment([FromBody] VerifyAccountPaymentCommand command)
        {
            try
            {
                var res = await Mediator.Send(command);

                if (res.IsSuccessResponse)
                {
                    return Ok(res);
                }
                else
                {
                    return new BadRequestObjectResult((BaseMessageResponse)res);

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "verifyaccountpayment");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }
    }
}

