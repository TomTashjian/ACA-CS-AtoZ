using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Entities;

namespace OrderManagement.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
