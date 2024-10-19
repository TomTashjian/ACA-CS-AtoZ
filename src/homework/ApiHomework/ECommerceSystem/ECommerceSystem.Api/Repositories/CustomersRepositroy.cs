using ECommerceSystem.Api.Entities;
using ECommerceSystem.Api.Models.RequestModels;

namespace ECommerceSystem.Api.Repositories
{
    public class CustomersRepository
    {
        private List<Customer> _customers { get; set; }
        private int _nextId { get; set; }

        public CustomersRepository()
        {
            _customers = new List<Customer>();
            _nextId = 1;
        }

        public Customer AddCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = new Customer
            {
                Id = _nextId,
                Name = customerRequestModel.Name,
                Email = customerRequestModel.Email
            };
            _customers.Add(customer);
            _nextId++;
            return customer;
        }

        public Customer? GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public void UpdateCustomerById(int id, CustomerRequestModel customerRequestModel)
        {
            var customerToUpdate = _customers.FirstOrDefault(c => c.Id == id);
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = customerRequestModel.Name;
                customerToUpdate.Email = customerRequestModel.Email;
            }
        }

        public void DeleteCustomer(int id)
        {
            var customerToDelete = _customers.FirstOrDefault(c => c.Id == id);
            if (customerToDelete != null)
            {
                _customers.Remove(customerToDelete);
            }
            Reorder();
            _nextId--;
        }

        #region Private Methods
        private void Reorder()
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                _customers[i].Id = i + 1;
            }
        }
        #endregion
    }
}
