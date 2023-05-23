namespace BlazingPizza.Model;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a pre-configured template for a pizza a user can order
/// </summary>
public class PizzaSpecial
{
    public int Id { get; set; }


    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string Name { get; set; }

    [Range(0.00, 50.00)]
    public decimal BasePrice { get; set; }

    public string Description { get; set; }


    [Url]
    public string ImageUrl { get; set; }

    public string GetFormattedBasePrice() => BasePrice.ToString("0.00");

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public int? FixedSize { get; set; }
}
