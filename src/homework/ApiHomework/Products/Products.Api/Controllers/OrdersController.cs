using ECommerceSystem.Api.Models.RequestModels;
using ECommerceSystem.Api.Models.ResponseModels;
using ECommerceSystem.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public OrderResponseModel CreateOrder(OrderRequestModel orderRequestModel)
        {
            var order = _orderService.Repo.AddOrder(orderRequestModel);
            if (_orderService.Repo.GetOrderById(order.Id) == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new OrderResponseModel();
            }
            return new OrderResponseModel()
            {
                Id = order.Id,
                ProductId = order.ProductId,
                CustomerId = order.CustomerId
            };
        }

        [HttpGet("{id}")]
        public OrderResponseModel GetOrderById(int id)
        {
            var order = _orderService.Repo.GetOrderById(id);
            if (order == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new OrderResponseModel();
            }
            return new OrderResponseModel()
            {
                Id = order.Id,
                ProductId = order.ProductId,
                CustomerId = order.CustomerId
            };
        }

        [HttpPut("{id}")]
        public OrderResponseModel UpdateOrderById(int id, [FromBody] OrderRequestModel orderRequestModel)
        {
            _orderService.Repo.UpdateOrderById(id, orderRequestModel);
            var order = _orderService.Repo.GetOrderById(id);
            if (order == null)
            {
                return new OrderResponseModel();
            }
            return new OrderResponseModel()
            {
                Id = order.Id,
                ProductId = order.ProductId,
                CustomerId = order.CustomerId
            };
        }

        [HttpDelete("{id}")]
        public void DeleteOrderById(int id)
        {
            // TODO: might want to handle the case where the order is not found
            _orderService.Repo.DeleteOrder(id);
        }
    }
}
