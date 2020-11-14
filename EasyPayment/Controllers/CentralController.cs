using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EasyPayment.Application.Handlers.Commands;
using EasyPayment.Application.Handlers.Queries;
using EasyPyment.Common.Models;
using EasyPyment.Common.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace EasyPayment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentralController : BaseController
    {
        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<AppDto>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpPost, Route("addApplication")]
        public async Task<IActionResult> CreateApplication([FromBody] RegisterAppCommand command)
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
                Log.Error(ex, "registerapp");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }

        [ProducesResponseType(typeof(BaseMessageResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(MessageResponse<List<AppDto>>), (int)HttpStatusCode.OK)]
        [Produces("application/json")]
        [HttpGet, Route("getallapps")]
        public async Task<IActionResult> GetAllApps()
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
                Log.Error(ex, "getallapps");
                return new BadRequestObjectResult(new BaseMessageResponse { IsSuccessResponse = false, Message = "Unable to proceed", ResponseCode = 15 });
            }
        }
    }
}
