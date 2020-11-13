
//ACCOUNT PAYMENT RESPONSE

public class AccountPaymentResponse
{
        public long id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public long amount { get; set; }
        public long charged_amount { get; set; }
        public long app_fee { get; set; }
        public long merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string currency { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string payment_type { get; set; }
        public string fraud_status { get; set; }
        public string charge_type { get; set; }
        public DateTime CreatedAt { get; set; }
        public long account_id { get; set; }
        public AccountDetails Account { get; set; }
        public CustomerDetails customer { get; set; }
        public CardDetails card { get; set; }
        public AccountPaymentMetaData Meta { get; set; }

}

    public class AccountDetails
    {
        public string account_number { get; set; }
        public string bank_code { get; set; }
        public string account_name { get; set; }
    }

    public class AccountPaymentMetaData
    {
        public AccountPaymentAuthorization Authorization { get; set; }
    }

     public class AccountPaymentAuthorization
    {
        public string Mode { get; set; }
        public string ValidateInstructions { get; set; }
    }
