namespace BlazingPizza.Data;

using Microsoft.EntityFrameworkCore;


public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<PizzaSpecial> Specials { get; set; }
}
