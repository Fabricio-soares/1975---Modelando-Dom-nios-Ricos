using System;
using System.Collections.Generic;
using System.Linq;
using ContextPayment.Domanin.Entities;
using ContextPayment.Domanin.ValueObject;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.Entities
{
  public class BoletoPayment : Payment
    {
        public BoletoPayment(DateTime dataPagameto, DateTime expirationPayment, decimal total, decimal totalPago, string proprietario, Document document, Address Address, Email email) : base(dataPagameto, expirationPayment, total, totalPago, proprietario, document, Address, email)
        {
        }

        public String Barcode { get; set; } 
        public String BoletoNumber{ get; set; } 

    }   
}