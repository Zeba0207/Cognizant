using System;

namespace AdapterPattern
{
    public class StripeGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of ₹{amount} processed through Stripe.");
        }
    }
}