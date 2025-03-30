using Microsoft.EntityFrameworkCore;

namespace Store_CRUD_MVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
    }
}
