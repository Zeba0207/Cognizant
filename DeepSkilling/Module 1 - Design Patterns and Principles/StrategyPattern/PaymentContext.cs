namespace StrategyPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ExecutePayment(int amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}