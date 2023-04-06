using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Biblioteca.Moongy.Models;

namespace WebApp.Biblioteca.Moongy.Controllers
{
    public class LivroController : Controller
    {
        private readonly List<Livro> CatalogoDeLivros;
        public LivroController()
        {
            CatalogoDeLivros = new List<Livro>
            {
                new Livro{ Id = 1, Nome = "Harry Potter", Autor = "JK" },
                new Livro{ Id = 2, Nome = "Lord of the Rings", Autor = "JRRTolkien" },
            };
        }


        // GET: LivroController/Details/5
        public ActionResult Details(int id)
        {
            var livroEscolhido = CatalogoDeLivros.First(l => l.Id == id);
            return View(livroEscolhido);
        }

     
        // POST: LivroController/Create
        [HttpPost]
        public void Create(Livro livroNovo)
        {
            CatalogoDeLivros.Add(livroNovo);
        }
    }
}


//Create  => POST      ---Criar Livro Novo  ==< Response 201 (created)
//Read    => GET       ---Listar livros / ver detalhes == 200 OK
//Update  => PUT/PATCH ---Atualizar dados do Livre    == 204 NoContent
//Delete  => Delete    ---Apagar                       == 204 NoContent