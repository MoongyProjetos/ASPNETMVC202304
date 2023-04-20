using System.Text.Json.Serialization;

public class MeuLivro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }


    // [JsonPropertyName("Nome")]
    // public string EnglishName { get; set; }

[JsonPropertyName("ISBN")]
    public string EnglishISBNTest { get; set; }
}