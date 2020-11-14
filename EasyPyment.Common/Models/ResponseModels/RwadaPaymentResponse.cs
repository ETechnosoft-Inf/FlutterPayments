using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
   public class RwadaPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public RwandaMetaData Meta { get; set; }
    }

    public class RwandaMetaData
    {
        public RwandaAuthorization Authorization { get; set; }
    }

    public class RwandaAuthorization
    {
        public string Redirect { get; set; }
        public string Mode { get; set; }
    }
}
