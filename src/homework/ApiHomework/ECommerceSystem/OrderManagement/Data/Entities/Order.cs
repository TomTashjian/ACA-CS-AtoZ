namespace OrderManagement.Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
