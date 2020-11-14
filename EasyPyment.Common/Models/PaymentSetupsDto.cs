using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models
{
    public class PaymentSetupDto
    {
        public int Id { get; set; }
        public string TenantAppId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderPublicKey { get; set; }
        public string ProviderSecretKey { get; set; }
        public bool IsActive { get; set; }
    }
}
