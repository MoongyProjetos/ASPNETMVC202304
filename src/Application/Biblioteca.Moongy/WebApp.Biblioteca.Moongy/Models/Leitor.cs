using System.ComponentModel.DataAnnotations;

namespace WebApp.Biblioteca.Moongy.Models
{
    public class Leitor
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string? Nome { get; set; }


        [MaxLength(9), Display(Name = "Número da Identificação Fiscal")]
        public string? NIF { get; set; }
    }
}
