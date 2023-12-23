using CCC.Models;
using Microsoft.EntityFrameworkCore;

namespace CusCarCom.Models
{
    public class CCCContext:DbContext
    {
        public CCCContext(DbContextOptions<CCCContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Car> Cars { get; set; } = null;
        public DbSet<Company> Companies { get; set; } = null;
    }
}
