using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{
    public class PaymentSetup
    {
        public PaymentSetup()
        {
            this.paymentLogs = new HashSet<PaymentLog>();
        }
        public int Id { get; set; }
        public string TenantAppId { get; set; }
        public string ProviderName { get; set; }
        public string providerPublicKey { get; set; }
        public string ProviderSecretKey { get; set; }
        public bool IsActive { get; set; }
        public ICollection<PaymentLog> paymentLogs { get; set; }
    }
}
