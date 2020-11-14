using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
   public class VerifyPaymentResponseModel
    {
        
            public string Status { get; set; }
            public string Message { get; set; }
            public VerificationDetails Data { get; set; }
        
    }

    public  class VerificationDetails
    {
        public long Id { get; set; }
        public string TxRef { get; set; }
        public string FlwRef { get; set; }
        public string DeviceFingerprint { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
        public long ChargedAmount { get; set; }
        public long AppFee { get; set; }
        public long MerchantFee { get; set; }
        public string ProcessorResponse { get; set; }
        public string AuthModel { get; set; }
        public string Ip { get; set; }
        public string Narration { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public long AccountId { get; set; }
        public long AmountSettled { get; set; }
        public CardDetails Card { get; set; }
        public CustomerDetails Customer { get; set; }
    }
}
