using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
   
    public class InitiatePaymentResponseModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public InitiatResponseDetails data { get; set; }
    }

    public class InitiatResponseDetails
    {
        public string link { get; set; }
    }
}
