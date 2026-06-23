using System;

namespace DependencyInjectionPattern
{
    public class CustomerRepository : ICustomerRepository
    {
        public void GetCustomer()
        {
            Console.WriteLine("Customer details retrieved from database.");
        }
    }
}