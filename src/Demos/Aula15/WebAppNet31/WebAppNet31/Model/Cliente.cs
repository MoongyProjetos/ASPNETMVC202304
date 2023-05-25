using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace WebAppNet31.Model
{
    public class Cliente
    {
        [Display(Name = "meu id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
