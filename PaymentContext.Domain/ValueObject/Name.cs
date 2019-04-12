using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace  PaymentContext.Domain.ValueObject
{
    public class Name : PaymentContext.Shared.ValueObjects.ValueObject  
    {
        public Name(string fistName, string lestName)
        {
            FistName = fistName;
            LestName = lestName;

             AddNotifications(new Contract()
                .Requires()
                .HasMaxLen
                (fistName ,10,"fistName", "String is Null")
                .HasMaxLen(lestName ,10,"fistName", "String is Null")
                .HasMinLen(fistName ,5,"fistName", "String is Null")
                .HasMinLen(lestName ,5,"fistName", "String is Null")
                );

               
            
        }

        public string FistName { get; private set; } 
        public string LestName { get; private set; } 
    }
}