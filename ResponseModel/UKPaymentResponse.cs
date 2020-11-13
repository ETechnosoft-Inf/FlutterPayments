//UK PAYMENT
     public class UKPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public UKPaymentResponseDetails Data { get; set; }
    }

    public class UKPaymentResponseDetails
    {
        public string Amount { get; set; }
        public string Type { get; set; }
        public bool Redirect { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderRef { get; set; }
        public string FlwRef { get; set; }
        public object RedirectUrl { get; set; }
        public string PaymentCode { get; set; }
        public string TypeData { get; set; }
        public UKPaymentMetaData Meta { get; set; }
    }

    public class UKPaymentMetaData
    {
        public UKPaymentAuthorization Authorization { get; set; }
    }

    public class UKPaymentAuthorization
    {
        public long AccountNumber { get; set; }
        public string SortCode { get; set; }
    }
