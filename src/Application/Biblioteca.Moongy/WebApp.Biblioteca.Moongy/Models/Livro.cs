using System.ComponentModel.DataAnnotations;

namespace WebApp.Biblioteca.Moongy.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Nome muito grande")]
        public string? Nome { get; set; }
        
        [MaxLength(150)]
        public string? Autor { get; set; }

        [MaxLength(50)]
        public string? Editora { get; set; }

        [Range(0,double.MaxValue)]
        public int NumeroPaginas { get; set; }

        [MaxLength(13, ErrorMessage = "Opa, faltam dígitos")]
        [RegularExpression(@"^[\d]{1}[-]{1}[\d]{3}[-]{1}[\d]{5}[-]{1}[\d]{0,1}$", ErrorMessage = "ISBN errado")]
        public string? ISBN { get; set; }


        public byte[]? CodigoBarras { get; set; }
        public virtual Livraria? Biblioteca { get; set; }
    }
}
