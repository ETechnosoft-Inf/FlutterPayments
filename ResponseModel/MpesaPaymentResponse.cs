    //Mpesa PAYMENT RESPONSE
    public class MpesaResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public MpesaResponseDetails Data { get; set; }
    }

    public class MpesaResponseDetails
    {
        public long Id { get; set; }
        public string TxRef { get; set; }
        public string FlwRef { get; set; }
        public string DeviceFingerprint { get; set; }
        public long Amount { get; set; }
        public long ChargedAmount { get; set; }
        public long AppFee { get; set; }
        public long MerchantFee { get; set; }
        public string ProcessorResponse { get; set; }
        public string AuthModel { get; set; }
        public string Currency { get; set; }
        public string Ip { get; set; }
        public string Narration { get; set; }
        public string Status { get; set; }
        public string AuthUrl { get; set; }
        public string PaymentType { get; set; }
        public string FraudStatus { get; set; }
        public string ChargeType { get; set; }
        public DateTimeO CreatedAt { get; set; }
        public long AccountId { get; set; }
        public CustomerDetails Customer { get; set; }
    }

    public class CustomerDetails
    {
        public long id { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public DateTime created_at { get; set; }
    }