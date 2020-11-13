using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{
    public class PaymentSetup
    {
        
        public long TenantAppId { get; set; }
        public long  AppRegistryId { get; set; }
        public AppRegistry AppRegistry { get; set; }
        public string ProviderName { get; set; }
        public string providerPublicKey { get; set; }
        public string ProviderSecretKey { get; set; }
        public bool IsActive { get; set; }
    }
}
