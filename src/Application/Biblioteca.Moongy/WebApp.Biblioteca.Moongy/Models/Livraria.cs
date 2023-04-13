using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Biblioteca.Moongy.Models
{
    [Table("Biblioteca")]
    public class Livraria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Eita, nome grande"), Display(Name = "Nome da Biblioteca")]
        public string? Nome { get; set; }
        [MaxLength(150)]
        public string? Endereco { get; set; }

        [MaxLength(15)]
        public string? Telefone { get; set; }


        [MaxLength(150)]
        public string? Email { get; set; }


        [MaxLength(200)]
        public string? WebPage { get; set; }

        public virtual List<Livro>? Livros { get; set; }
    }
}
