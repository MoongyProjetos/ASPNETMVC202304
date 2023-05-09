using System.ComponentModel.DataAnnotations;

namespace ExemploRazor.Models
{
    public class Livro
    {
        public int Id { get; set; }


        [MinLength(30, ErrorMessage = "Opa, falta coisa aqui")]
        public string? Nome { get; set; }

        [Display(Name = "Número do ISBN")]
        public string? ISBN { get; set; }
        public byte[]? CapaLivro { get; set; }
    }
}
