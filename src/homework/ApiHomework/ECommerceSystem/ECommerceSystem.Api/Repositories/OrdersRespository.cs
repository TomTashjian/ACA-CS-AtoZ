using ECommerceSystem.Api.Entities;
using ECommerceSystem.Api.Models.RequestModels;

namespace ECommerceSystem.Api.Repositories
{
    public class OrdersRepository
    {
        private List<Order> _orders { get; set; }
        private int _nextId { get; set; }

        public OrdersRepository()
        {
            _orders = new List<Order>();
            _nextId = 1;
        }

        public Order AddOrder(OrderRequestModel orderRequestModel)
        {
            var order = new Order
            {
                Id = _nextId,
                ProductId = orderRequestModel.ProductId,
                CustomerId = orderRequestModel.CustomerId
            };
            _orders.Add(order);
            _nextId++;
            return order;
        }

        public Order? GetOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public List<Order> GetOrders()
        {
            return _orders;
        }

        public void UpdateOrderById(int id, OrderRequestModel orderRequestModel)
        {
            var orderToUpdate = _orders.FirstOrDefault(o => o.Id == id);
            if (orderToUpdate != null)
            {
                orderToUpdate.ProductId = orderRequestModel.ProductId;
                orderToUpdate.CustomerId = orderRequestModel.CustomerId;
            }
        }

        public void DeleteOrder(int id)
        {
            var orderToDelete = _orders.FirstOrDefault(o => o.Id == id);
            if (orderToDelete != null)
            {
                _orders.Remove(orderToDelete);
            }
            Reorder();
            _nextId--;
        }

        #region Private Methods
        private void Reorder()
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                _orders[i].Id = i + 1;
            }
        }
        #endregion
    }
}
