namespace AdapterPattern
{
    public class PayPalAdapter : PaymentProcessor
    {
        private readonly PayPalGateway _payPalGateway;

        public PayPalAdapter(PayPalGateway payPalGateway)
        {
            _payPalGateway = payPalGateway;
        }

        public void ProcessPayment(double amount)
        {
            _payPalGateway.SendPayment(amount);
        }
    }
}