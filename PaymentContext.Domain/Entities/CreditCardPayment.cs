using System;
using ContextPayment.Domanin.ValueObject;
using PaymentContext.Domain.ValueObject;

namespace ContextPayment.Domanin.Entities
{
   
      public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime dataPagameto, DateTime expirationPayment, decimal total, decimal totalPago, string proprietario, Document document, Address Address, Email email) : base(dataPagameto, expirationPayment, total, totalPago, proprietario, document, Address, email)
        {
        }

        public String CardName { get; set; } 
        public String NumberCard { get; set; } 
        public String LastTransaction { get; set; } 
    }
    
}