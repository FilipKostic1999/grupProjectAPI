using CCC.Models;
using Microsoft.EntityFrameworkCore;

namespace CusCarCom.Models
{
    // Klassen som representerar kontexten för databasen
    public class CCCContext : DbContext
    {
        // Konstruktorn för CCCContext tar emot DbContextOptions och skickar dessa till basklassen
        public CCCContext(DbContextOptions<CCCContext> options) : base(options)
        {

        }

        // DbSet som representerar en uppsättning av Customer-objekt i databasen
        public DbSet<Customer> Customers { get; set; } = null;

        // DbSet som representerar en uppsättning av Car-objekt i databasen
        public DbSet<Car> Cars { get; set; } = null;

        // DbSet som representerar en uppsättning av Company-objekt i databasen
        public DbSet<Company> Companies { get; set; } = null;
    }
}
