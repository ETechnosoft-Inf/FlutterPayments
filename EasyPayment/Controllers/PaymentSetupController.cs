using EasyPayment.Application.Handlers.Commands;
using EasyPayment.Application.Handlers.Queries;
using EasyPyment.Common.Models;
using EasyPyment.Common.Responses;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EasyPayment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentSetupController : BaseController
    {
        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<PaymentSetupDto>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpPost, Route("addpaymentsetup")]
        public async Task<IActionResult> CreatePaymentSetup([FromBody] CreatePaymentSetupCommand command)
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

        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<List<PaymentSetupDto>>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpGet, Route("getallpaymentsetup")]
        public async Task<IActionResult> GetAllPaymentsSetups()
        {
            try
            {
                var command = new GetAllAppsQuery();
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
                Log.Error(ex, "getallpaymentsetups");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }
    }

    
}
