using System;

namespace AdapterPattern
{
    public class PayPalGateway
    {
        public void SendPayment(double amount)
        {
            Console.WriteLine($"Payment of ₹{amount} processed through PayPal.");
        }
    }
}