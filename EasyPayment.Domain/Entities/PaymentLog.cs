using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{
    public class PaymentLog
    {
        public PaymentLog()
        {
            this.appRegistries = new HashSet<AppRegistry>();
        }
        public string CustomerId { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymentChannel { get; set; }
        public string AppCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string StatusMessage { get; set; }
        public string Narration { get; set; }
        public bool IsCompleted { get; set; }
        public string Response { get; set; } // Json of the response
        
        public ICollection<AppRegistry> appRegistries { get; set; }
    }
}
