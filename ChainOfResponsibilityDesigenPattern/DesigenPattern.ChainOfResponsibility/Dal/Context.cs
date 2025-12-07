using Microsoft.EntityFrameworkCore;

namespace DesigenPattern.ChainOfResponsibility.Dal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PBR2LIP;database=ChainOfResponsibilityDesigenPattern;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<CustomerProccess> CustomerProccesses { get; set; }
    }
}
