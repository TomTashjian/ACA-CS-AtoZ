using ECommerceSystem.Api.Repositories;

namespace ECommerceSystem.Api.Services
{
    public class OrderService
    {
        public readonly OrdersRepository Repo;
        public OrderService(OrdersRepository orderRepository)
        {
            Repo = orderRepository;
        }
    }
}
