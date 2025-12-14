using Microsoft.EntityFrameworkCore;

namespace DesigenPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PBR2LIP;database=CQRSDb;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
