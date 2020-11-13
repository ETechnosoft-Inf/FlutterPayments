using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{
    public class AppRegistry
    {
        public AppRegistry()
        {
            this.paymentSetups = new HashSet<PaymentSetup>();
            this.paymentCards=new HashSet<PaymentCard>();
        }

        public long Id { get; set; }
        public string AppCode { get; set; }
        public string AppName { get; set; }
        public bool IsActive { get; set; }
       
        public ICollection<PaymentSetup> paymentSetups { get; set; }
        public ICollection<PaymentCard> paymentCards { get; set; } 
    }
}
