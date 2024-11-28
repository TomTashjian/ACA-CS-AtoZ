namespace OrderManagement.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
