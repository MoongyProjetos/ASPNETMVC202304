using Microsoft.EntityFrameworkCore;

namespace WebApp.Biblioteca.Moongy.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
        {
        }

        public BibliotecaContext()
        {

        }

        public DbSet<Livraria> Bibliotecas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<Emprestimo> Locacoes { get; set; }
    }
}
