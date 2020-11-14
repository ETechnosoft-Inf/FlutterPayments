using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
  public class InitiateCardPaymentResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public InitiateCardPaymentMeta meta { get; set; }
    }

    public class InitiateCardPaymentMeta
    {
        public InitiateCardAuthorization authorization { get; set; }
    }

    public class InitiateCardAuthorization
    {
        public string mode { get; set; }
        public string[] fields { get; set; }
    }

    public class VerifyCardPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public VerificationData Data { get; set; }
    }

    public class VerificationData
    {
        public long Id { get; set; }
        public string TxRef { get; set; }
        public string FlwRef { get; set; }
        public string DeviceFingerprint { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
        public long ChargedAmount { get; set; }
        public double AppFee { get; set; }
        public long MerchantFee { get; set; }
        public string ProcessorResponse { get; set; }
        public string AuthModel { get; set; }
        public string Ip { get; set; }
        public string Narration { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public DateTime CreatedAt { get; set; }
        public long AccountId { get; set; }
        public CardDetails Card { get; set; }
        public string Meta { get; set; }
        public double AmountSettled { get; set; }
        public CustomerDetails Customer { get; set; }
    }


}
