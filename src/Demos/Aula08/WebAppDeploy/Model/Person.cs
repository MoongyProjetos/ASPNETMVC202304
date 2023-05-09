using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppDeploy.Model
{
    [Table("Persons")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public int Age { get; set; }
    }
}
