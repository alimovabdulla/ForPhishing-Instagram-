using For_Instagram.Models;
using Microsoft.EntityFrameworkCore;

namespace For_Instagram.DataContext
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options):base(options) 
        {
            
        }
        public DbSet<Login> Login { get; set; }
         
    }
}
