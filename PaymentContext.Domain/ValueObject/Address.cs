using Flunt.Validations;
using PaymentContext.Shared.Entities;
using PaymentContext.Shared.ValueObjects;

namespace ContextPayment.Domanin.ValueObject
{
    public class Address : PaymentContext.Shared.ValueObjects.ValueObject 
    {
        public Address(string street, string number, string city, string country)
        {
            Street = street;
            Number = number;
            City = city;
            Country = country;

            
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}