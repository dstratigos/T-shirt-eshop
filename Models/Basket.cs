using Dimitrios_Stratigos_Assignment4.Strategies;
using System;
using System.Collections.Generic;


namespace Dimitrios_Stratigos_Assignment4.Models
{
    public class Basket
    {
        private IPaymentMethod _paymentMethod;
        public PaymentEnum Payment { get; set; }

        public List<TShirt> TShirts { get; set; } = new List<TShirt>();
        private int _totalPayable;


        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }


        public void PaymentMethod()
        {
            var method = _paymentMethod.SetPayment(Payment);
            Console.WriteLine($"You chose to {method}");
        }

        public int TotalPayable()
        {
            _totalPayable = 0;

            foreach (var item in TShirts)
            {
                _totalPayable += item.Price;
            }

            return _totalPayable;
        }
    }
}
