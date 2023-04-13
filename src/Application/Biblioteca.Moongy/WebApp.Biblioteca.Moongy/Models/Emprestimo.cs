using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Biblioteca.Moongy.Models
{
    [Table(name:"Locacao")]
    public class Emprestimo
    {
        [Column(name:"EmprestimoId"), 
         Key, 
         DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Chucrutes { get; set; }

        [Required]
        public DateTime DataLocacao { get; set; }

        [Required]
        public Leitor? Leitor { get; set; }

        [Required]
        public Livro? Livro { get; set; }

        public DateTime DataDevolucao { get; set; }
    }
}
