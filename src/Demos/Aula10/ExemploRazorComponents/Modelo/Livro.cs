using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Livro
    {
        public int Id { get; set; }

        [Display(Name = "Meu livro")]
        [Required(ErrorMessage = "Ops, você esqueceu do nome")]
        [MinLength(30)]
        public string? Nome { get; set; }

        [DisplayFormat(DataFormatString = "YYYYMMDD")]
        public DateTime? DataLancamento { get; set; }


        public string? UrlDaCapa { get; set; }
    }
}