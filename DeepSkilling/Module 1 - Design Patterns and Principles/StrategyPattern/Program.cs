using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentContext creditCard =
                new PaymentContext(new CreditCardPayment());

            creditCard.ExecutePayment(5000);

            PaymentContext paypal =
                new PaymentContext(new PayPalPayment());

            paypal.ExecutePayment(3000);
        }
    }
}