using ECommerceSystem.Api.Models.RequestModels;
using ECommerceSystem.Api.Models.ResponseModels;
using ECommerceSystem.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public CustomerResponseModel CreateCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = _customerService.Repo.AddCustomer(customerRequestModel);
            if (_customerService.Repo.GetCustomerById(customer.Id) == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new CustomerResponseModel();
            }
            return new CustomerResponseModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email
            };
        }

        [HttpGet("{id}")]
        public CustomerResponseModel GetCustomerById(int id)
        {
            var customer = _customerService.Repo.GetCustomerById(id);
            if (customer == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new CustomerResponseModel();
            }
            return new CustomerResponseModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email
            };
        }

        [HttpPut("{id}")]
        public CustomerResponseModel UpdateCustomerById(int id, [FromBody] CustomerRequestModel customerRequestModel)
        {
            _customerService.Repo.UpdateCustomerById(id, customerRequestModel);
            var customer = _customerService.Repo.GetCustomerById(id);
            if (customer == null)
            {
                return new CustomerResponseModel();
            }
            return new CustomerResponseModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email
            };
        }

        [HttpDelete("{id}")]
        public void DeleteCustomerById(int id)
        {
            // TODO: might want to handle the case where the customer is not found
            _customerService.Repo.DeleteCustomer(id);
        }
    }
}
