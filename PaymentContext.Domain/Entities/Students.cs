using System;
using System.Collections.Generic;
using ContextPayment.Domanin.ValueObject;
using Flunt.Validations;
using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Students : Entity 
    {
        private List<Subscription> _subscription;
 

         public Students(Name name, Document document, Email email, Guid id): base(id) 
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();

        }

        public Name Name { get; set; }
        public Document Document { get; private set; } 
        public Email Email { get; private set; } 
        public Address Address { get; private set; } 
        public IReadOnlyCollection<Subscription> subscription { get{return _subscription.ToArray();} } 


        public void AddAssinaturas(Subscription add){
            //Se jรก tiver assinatura ativa, Cancela
            var hasSubscriptionActive = false;
            foreach (var sub in subscription) {
              hasSubscriptionActive = true;
            }

            AddNotifications(new Contract().Requires().IsFalse(hasSubscriptionActive,"hasSubscriptionActive","Voce já é assinate"));

        }
    }

    }
