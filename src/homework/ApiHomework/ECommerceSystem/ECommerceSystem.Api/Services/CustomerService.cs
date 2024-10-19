using ECommerceSystem.Api.Repositories;

namespace ECommerceSystem.Api.Services
{
    public class CustomerService
    {
        public readonly CustomersRepository Repo;
        public CustomerService(CustomersRepository customerRepository)
        {
            Repo = customerRepository;
        }
    }
}
