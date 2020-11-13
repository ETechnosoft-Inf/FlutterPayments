using EasyPyment.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Responses
{
    public class Util
    {
        public static MessageResponse<T> GetResponse<T>(bool response, string message, T result) where T : class
        {
            var responseMessage = new MessageResponse<T>();
            responseMessage.IsSuccessResponse = response;
            var responseCode = response ? ResponseDetail.Successful : ResponseDetail.Failed;
            responseMessage.ResponseCode = (int)responseCode;
            responseMessage.Message = message;
            responseMessage.Result = result;
            return responseMessage;
        }
    }
}
