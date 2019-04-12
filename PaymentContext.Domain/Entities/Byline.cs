using System;
using System.Collections.Generic;
using System.Linq;
using ContextPayment.Domanin.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _Payment;
        public Subscription(DateTime? dateExpiration)
        {
            DateCreation = DateTime.Now;
            lastDateChange = DateTime.Now;
            DateExpiration = dateExpiration;
            Active = true;
            _Payment = new List<Payment>();
        }


        public DateTime DateCreation { get; private set; } 
        public DateTime lastDateChange { get; private set; } 
        public DateTime? DateExpiration  { get; private set; } 
        public bool Active { get; private set; } 
        public IReadOnlyCollection<Payment> Payments { get{return _Payment.ToArray();} }
        public void addPagamentos(Payment add) => _Payment.Add(add);
        public void DesativarAssinaturaPagamentos() => Active = false;

    }


}