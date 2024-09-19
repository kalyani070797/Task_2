using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Infrastructure.Tables;

namespace Task_2.Infrastructure.PracticeDbContext
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>options): base(options) 
        { 
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Mapping> Mapping { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Rating> Rating {  get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderId)
                .HasMaxLength(10) // Set the appropriate length for your order ID
                .IsRequired();
        }
    }
}
