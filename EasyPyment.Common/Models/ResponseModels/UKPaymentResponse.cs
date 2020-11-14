using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
    public class UKPaymentResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public UKPaymentResponseDetails data { get; set; }
    }

    public class UKPaymentResponseDetails
    {
        public string amount { get; set; }
        public string type { get; set; }
        public bool redirect { get; set; }
        public DateTimeOffset created_at { get; set; }
        public string order_ref { get; set; }
        public string flw_ref { get; set; }
        public string redirect_url { get; set; }
        public string payment_code { get; set; }
        public string type_data { get; set; }
        public UKPaymentMetaData Meta { get; set; }
    }

    public class UKPaymentMetaData
    {
        public UKPaymentAuthorization Authorization { get; set; }
    }

    public class UKPaymentAuthorization
    {
        public long account_number { get; set; }
        public string SortCode { get; set; }
    }
}
