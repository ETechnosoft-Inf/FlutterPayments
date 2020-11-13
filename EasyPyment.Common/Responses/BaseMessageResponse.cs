using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace EasyPyment.Common.Responses
{
    public class BaseMessageResponse
    {
        [JsonIgnore]
        public bool IsSuccessResponse { get; set; }
        public int ResponseCode { get; set; }
        public string Message { get; set; }
    }
    public class MessageResponse<T> : BaseMessageResponse
    {
        public T Result { get; set; }
    }
    public class Response<T>
    {
        public T Result { get; set; }
    }
}
