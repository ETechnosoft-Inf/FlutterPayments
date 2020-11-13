using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
   
    public class InitiatePaymentResponseModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public InitiateDetails data { get; set; }
    }

    public class InitiateDetails
    {
        public string link { get; set; }
    }
}
