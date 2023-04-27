using Microsoft.EntityFrameworkCore;

namespace WebAppDeploy.Model
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options): base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }    
}
