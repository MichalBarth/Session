using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SessionDemo.Models
{
    public class Basket
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        
        public decimal Price { get; set; }

        [IgnoreDataMember]
        public decimal PriceWithVat => Price * vat;

        [IgnoreDataMember]
        public string Description { get; set; }

        private decimal vat { get; } = 1.21m;
    }
}
