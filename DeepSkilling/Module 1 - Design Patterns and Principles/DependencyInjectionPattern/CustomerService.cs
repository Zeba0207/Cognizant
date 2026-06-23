namespace DependencyInjectionPattern
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void DisplayCustomer()
        {
            _repository.GetCustomer();
        }
    }
}