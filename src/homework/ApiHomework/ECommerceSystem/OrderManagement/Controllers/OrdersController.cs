using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Data.Entities;

namespace OrderManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderDbContext _orderDbContext;
        public OrdersController(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;    
        }
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderDbContext.Orders);
        }
        [HttpPost]
        public IActionResult AddOrder(Order order )
        {
            _orderDbContext.Orders.Add(order);
            _orderDbContext.SaveChanges();
            return Ok();
        }
        [HttpPost("bulk")]
        public IActionResult AddOrder(Order[] orders)
        {
            _orderDbContext.Orders.AddRange(orders);
            _orderDbContext.SaveChanges();
            return Ok();
        }
    }
}
