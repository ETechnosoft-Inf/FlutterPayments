using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Domain.Entities
{
    public class PaymentCard
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public long AppRegistryId { get; set;}
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public string CardType { get; set; }
        public string CardLast4Number { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string Bank { get; set; }
        public string Channel { get; set; }
        public bool Reusable { get; set; }
        public string CountryCode { get; set; }
    }
}
