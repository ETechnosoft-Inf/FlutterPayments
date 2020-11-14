using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
    public class USSDResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public USSDResponseDetails Data { get; set; }
        public USSDMetaData Meta { get; set; }
    }

    public class USSDResponseDetails
    {
        public long Id { get; set; }
        public string TxRef { get; set; }
        public string FlwRef { get; set; }
        public string DeviceFingerprint { get; set; }
        public long Amount { get; set; }
        public long ChargedAmount { get; set; }
        public double AppFee { get; set; }
        public long MerchantFee { get; set; }
        public string ProcessorResponse { get; set; }
        public string AuthModel { get; set; }
        public string Currency { get; set; }
        public string Ip { get; set; }
        public string Narration { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public string FraudStatus { get; set; }
        public string ChargeType { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public long AccountId { get; set; }
        public CustomerDetails Customer { get; set; }
        public long PaymentCode { get; set; }
    }

    public class USSDMetaData
    {
        public USSDAuthorization Authorization { get; set; }
    }

    public class USSDAuthorization
    {
        public string Mode { get; set; }
        public string Note { get; set; }
    }

   
}
