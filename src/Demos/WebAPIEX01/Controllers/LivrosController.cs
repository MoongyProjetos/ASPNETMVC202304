using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAPIEX01.models;

[ApiController]
[Route("[controller]")]
public class LivrosController : ControllerBase
{

    private List<Livro> Livraria;

    public LivrosController()
    {
        Livraria = new List<Livro>();
        Livraria.Add(new Livro {Id = 1, Nome = "Harry Potter", ISBN = "ISBN1"});
        Livraria.Add(new Livro {Id = 2, Nome = "O Senhor do Anéis", ISBN="ISBN2"});
    } 

    [HttpGet]
    public List<Livro> Get()
    {
        var conteudo = System.IO.File.ReadAllText(@"exemplo.json");
        var paypalexemplo = JsonSerializer.Deserialize<PaypalObject>(conteudo);
       

        return Livraria;
    }

    [HttpPost]
    public Livro CriarNovoLivro(int id, string nome){
        return new Livro{Id=id, Nome = nome};
    }


    [HttpPost]
    [Route("NovosLivros")]
    public List<Livro> CriarNovosLivros(Livro LivroNovo){
        Livraria.Add(LivroNovo);
        return Livraria;
    }
}