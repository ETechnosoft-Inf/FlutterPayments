public enum PaymentMethods
{
    account =0,
    card,
    banktransfer,
    mpesa,
    mobilemoneyrwanda,
    mobilemoneyzambia,
    qr,
    mobilemoneyuganda,
    ussd,
    credit,
    barter,
    mobilemoneyghana,
    payattitude,
    mobilemoneyfranco,
    paga,
    voucher,
    mobilemoneytanzania
}

    //INITIATE PAYMENT
   public class InitiatePaymentResponseModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public InitiateDetails data { get; set; }
    }

    public class InitiateDetails
    {
        public string link { get; set; }
    }

    public class VerificationResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public VerificationResonseData data { get; set; }
    }

    //PAYMENT VERIFICATION
    public class VerificationResonseData
    {
        public long id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public long amount { get; set; }
        public string currency { get; set; }
        public long charged_amount { get; set; }
        public long app_fee { get; set; }
        public long merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string payment_type { get; set; }
        public DateTime created_at { get; set; }
        public long account_id { get; set; }
        public long amount_settled { get; set; }
        public CardDetails card { get; set; }
        public CustomerDetails customer { get; set; }
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


    


    

