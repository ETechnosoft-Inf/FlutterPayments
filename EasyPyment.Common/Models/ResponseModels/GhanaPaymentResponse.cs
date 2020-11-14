using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
    
    public class GhanaPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public GhanaMetaData Meta { get; set; }
    }

    public class GhanaMetaData
    {
        public RwandaAuthorization Authorization { get; set; }
    }

    public class GhanaAuthorization
    {
        public string Redirect { get; set; }
        public string Mode { get; set; }
    }
}
