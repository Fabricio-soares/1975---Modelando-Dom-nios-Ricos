using PaymentContext.Domain.Enum;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.ValueObject
{
    public class Document : PaymentContext.Shared.ValueObjects.ValueObject 
    {
        public Document(string number, EtypeDocument type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EtypeDocument Type { get; private set; }
    }
    
}