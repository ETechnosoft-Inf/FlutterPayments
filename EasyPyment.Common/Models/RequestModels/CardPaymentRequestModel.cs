using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.RequestModels
{
    public class CardPaymentRequestModel
    {
        public string card_number { get; set; }
        public string cvv { get; set; }
        public string expiry_month { get; set; }
        public string expiry_year { get; set; }
        public string currency { get; set; }
        public string amount { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string tx_ref { get; set; }
        public string redirect_url { get; set; }
    }

    public class EncrryptPaymentDetailsModel
    {
        public string client { get; set; }
    }
}
