using System;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Shared.Entities
{
    public class  Entity : ValueObject
    {
          protected Entity(Guid id)
        {
            this.id = Guid.NewGuid();   
        }

        public Guid id { get; private set; }
    }

}
