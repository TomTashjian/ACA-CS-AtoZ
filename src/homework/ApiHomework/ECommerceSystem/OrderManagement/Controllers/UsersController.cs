using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Data.Entities;

namespace OrderManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly OrderDbContext _orderDbContext;

        public UsersController(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_orderDbContext.Users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _orderDbContext.Users.Add(user);
            _orderDbContext.SaveChanges();
            return Ok();
        }
    }
}
