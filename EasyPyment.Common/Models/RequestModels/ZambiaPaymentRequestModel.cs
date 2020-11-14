using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.RequestModels
{
    
        public class ZambiaPaymentRequestModel
        {
            public string TxRef { get; set; }
            public long Amount { get; set; }
            public string Currency { get; set; }
            public string Network { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Fullname { get; set; }
        }
    
}
