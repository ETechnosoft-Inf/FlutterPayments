//CARD PAYMENTS

    public class CardPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public CardPaymentDetails Data { get; set; }
        public CardMetaData Meta { get; set; }
    }


     public class CardPaymentDetails
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
        public string AuthUrl { get; set; }
        public string PaymentType { get; set; }
        public string FraudStatus { get; set; }
        public string ChargeType { get; set; }
        public DateTime CreatedAt { get; set; }
        public long AccountId { get; set; }
        public CustomerDetails Customer { get; set; }
        public CardDetails Card { get; set; }
    }


     public class CardDetails
    {
        public long first_6digits { get; set; }
        public long last_4digits { get; set; }
        public string issuer { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public string token { get; set; }
        public string expiry { get; set; }
    }

    public class CustomerDetails
    {
        public long id { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public DateTime created_at { get; set; }
    }
  

    public class authorizationResponse
    {
        public string mode { get; set; }
        public string[] fields { get; set; }
    }

    //INITIATE CARD PAYMENT RESPONSE
    public class InitiateCardPaymentResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public InitiateCardPaymentResponseData data { get; set; }
        public CardMetaData MetaData { get; set; }
    }

    public class InitiateCardPaymentResponseData
    {
        public long id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public long amount { get; set; }
        public long charged_amount { get; set; }
        public double app_fee { get; set; }
        public long merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string currency { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string auth_url { get; set; }
        public string payment_type { get; set; }
        public string fraud_status { get; set; }
        public string charge_type { get; set; }
        public DateTime created_at { get; set; }
        public long account_id { get; set; }
        public CustomerDetails Customer { get; set; }
        public CardDetails Card { get; set; }
    }

    public class CardMetaData
    {
        public authorizationResponse Authorization { get; set; }
    }

    public class authorizationResponse
    {
        public string mode { get; set; }
        public string endpoint { get; set; }
    }
    
    //VALIDATE CARD CHARGE TRANSACTION
    public class ValidateCardPaymentResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public ValidateCardPaymentResponseDetails data { get; set; }
    }

    public class ValidateCardPaymentResponseDetails
    {
        public long id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public long amount { get; set; }
        public long charged_amount { get; set; }
        public double app_fee { get; set; }
        public long merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string currency { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string auth_url { get; set; }
        public string payment_type { get; set; }
        public string fraud_status { get; set; }
        public string charge_type { get; set; }
        public DateTime created_at { get; set; }
        public long account_id { get; set; }
        public CustomerDetails Customer { get; set; }
        public CardDetails Card { get; set; }
    }

    //VERIFY CARD PAYMENT RESPONSE
    public class VerifyCardPaymentResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public VerifyCardPaymentResponseDetails data { get; set; }
    }
    public class VerifyCardPaymentResponseDetails
    {
        public long Id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public long amount { get; set; }
        public string currency { get; set; }
        public long charged_amount { get; set; }
        public double app_fee { get; set; }
        public long merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string payment_type { get; set; }
        public DateTime created_at { get; set; }
        public long account_id { get; set; }
        public CardDetails Card { get; set; }
        public string MetaData { get; set; }
        public double amount_settled { get; set; }
        public CustomerDetails Customer { get; set; }
    }
