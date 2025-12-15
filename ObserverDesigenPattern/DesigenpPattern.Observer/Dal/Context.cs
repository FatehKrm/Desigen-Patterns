using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesigenpPattern.Observer.Dal
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PBR2LIP;database=ObserverDesigenPattern;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<WelcomeMessage> welcomeMessages { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<UserProccess> userProccesses { get; set; }
    }
}
