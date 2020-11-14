using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{

    public partial class AccountPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public AccountPaymentResponseData Data { get; set; }
    }
    public class AccountPaymentResponseData
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

    public class ValidateAccountResponse
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
        public DateTimeOffset CreatedAt { get; set; }
        public long AccountId { get; set; }
        public CustomerDetails Customer { get; set; }
        public CardDetails Card { get; set; }
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
        public string mode { get; set; }
        public string validate_instructions { get; set; }
    }

    public class VerifyAccountPaymentResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public AccountVerificationData Data { get; set; }
    }

    public class AccountVerificationData
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
}
