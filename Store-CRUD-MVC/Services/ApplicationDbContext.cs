using Microsoft.EntityFrameworkCore;
using Store_CRUD_MVC.Models;

namespace Store_CRUD_MVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
