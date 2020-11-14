using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{

    public class PaymentLog
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
        public string CustomerId { get; set; }
        public int PaymentSetupId { get; set; }
        public PaymentSetup paymentSetup { get; set; }
        public string TenantAppId { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymantKey { get; set; }
        public string PaymentChannel { get; set; }
        public string Email { get; set; }
        public long Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentCardId { get; set; }
        public string StatusMessage { get; set; }
        public string Narration { get; set; }
        public bool IsCompleted { get; set; }
        public string Response { get; set; }
    }

    //public class PaymentLog
    //{
    //    public PaymentLog()
    //    {
    //        this.appRegistries = new HashSet<AppRegistry>();
    //    }
    //    public string CustomerId { get; set; }
    //    public string ReferenceNumber { get; set; }
    //    public string PaymentChannel { get; set; }
    //    public string AppCode { get; set; }
    //    public decimal Amount { get; set; }
    //    public DateTime PaymentDate { get; set; }
    //    public string StatusMessage { get; set; }
    //    public string Narration { get; set; }
    //    public bool IsCompleted { get; set; }
    //    public string Response { get; set; } // Json of the response

    //    public ICollection<AppRegistry> appRegistries { get; set; }
    //}

}
