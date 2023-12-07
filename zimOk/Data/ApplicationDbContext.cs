using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using zimOk.Models;

namespace zimOk.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<zimOk.Models.Product> Product { get; set; } = default!;
        public DbSet<zimOk.Models.Order> Order { get; set; } = default!;
        public DbSet<zimOk.Models.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<zimOk.Models.CartItem> CartItem { get; set; } = default!;
    }
}
