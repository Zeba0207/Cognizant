namespace AdapterPattern
{
    public class StripeAdapter : PaymentProcessor
    {
        private readonly StripeGateway _stripeGateway;

        public StripeAdapter(StripeGateway stripeGateway)
        {
            _stripeGateway = stripeGateway;
        }

        public void ProcessPayment(double amount)
        {
            _stripeGateway.MakePayment(amount);
        }
    }
}