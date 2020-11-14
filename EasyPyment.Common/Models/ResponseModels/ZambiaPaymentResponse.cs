using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
   
    public class ZambiaPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public ZambiaMetaData Meta { get; set; }
    }

    public class ZambiaMetaData
    {
        public ZambiaAuthorization Authorization { get; set; }
    }

    public class ZambiaAuthorization
    {
        public string Redirect { get; set; }
        public string Mode { get; set; }
    }
}
