namespace DependencyInjectionPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository repository = new CustomerRepository();

            CustomerService service = new CustomerService(repository);

            service.DisplayCustomer();
        }
    }
}