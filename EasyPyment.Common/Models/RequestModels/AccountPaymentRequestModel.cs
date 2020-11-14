using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.RequestModels
{
    public class AccountPaymentRequestModel
    {
        public string tx_ref { get; set; }
        public long amount { get; set; }
        public string account_bank { get; set; }
        public string account_number { get; set; }
        public string currency { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string full_name { get; set; }
    }

    public class ValidateAccountPaymentModel
    {
        public long otp { get; set; }
        public string flw_ref { get; set; }
        public string type { get; set; }
    }

    public class VaerifyAccountPaymentRequest
    {
        public string transaction_id { get; set; }
    }
}
