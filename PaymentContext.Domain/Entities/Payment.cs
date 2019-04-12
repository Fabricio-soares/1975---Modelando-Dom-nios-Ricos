using System;
using ContextPayment.Domanin.ValueObject;
using PaymentContext.Domain.ValueObject;

namespace ContextPayment.Domanin.Entities
{
    public abstract class Payment   
    {
        protected Payment(DateTime dataPagameto, DateTime expirationPayment,
         decimal total, decimal totalPago, string proprietario, Document document,
          Address Address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            DatePayment = dataPagameto;
            ExpirationPayment = expirationPayment;
            Total = total;
            TotalPago = totalPago;
            Property = proprietario;
            Document = document;
            Address = Address;
            Email = email;


        }

        public String Number { get;  private set; } 
        public DateTime DatePayment { get; private set; } 
        public DateTime ExpirationPayment { get; private set; } 
        public Decimal Total { get; private set; } 
        public Decimal TotalPago { get; private set; } 
        public String Property { get; private set; } 
        public Document Document { get; private set; } 
        public Address Address { get; private set; } 
        public Email Email { get; private set; } 

    }
   
}