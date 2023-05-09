using Microsoft.EntityFrameworkCore;

namespace IntroBlazor.Data.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }
        public DbSet<Estudante> Estudantes { get; set; }
    }
}
