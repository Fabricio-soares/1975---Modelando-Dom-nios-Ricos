using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace  PaymentContext.Domain.ValueObject
{
    public class Email : PaymentContext.Shared.ValueObjects.ValueObject  
     {
        public Email(string email)
        {
            this.email = email;
            
            AddNotifications(new Contract()
                .Requires()
                .IsEmail
                (email ,"string", "String is Null")
                );
        }

        public string email { get; set; }
    }
}