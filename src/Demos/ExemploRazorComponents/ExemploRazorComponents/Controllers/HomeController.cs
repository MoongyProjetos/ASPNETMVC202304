using ExemploRazorComponents.Models;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using System.Diagnostics;

namespace ExemploRazorComponents.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult ExemploAulaComponentes()
        {
            var lsitaLivros = new List<Livro>
            {
                new Livro{Id = 32, Nome = "Memórias Póstumas", UrlDaCapa = "https://kbimages1-a.akamaihd.net/0ad5646a-aa7d-4fb2-b057-e1b852c77310/1200/1200/False/memorias-postumas-de-bras-cubas-9.jpg" },
                new Livro{Id = 64, Nome = "Dom Casmurro", UrlDaCapa = "https://kbimages1-a.akamaihd.net/6c02a9c1-c781-4bea-b424-d39e4508e63b/1200/1200/False/dom-casmurro-74.jpg" },
                new Livro{Id = 128, Nome = "O Ateneu" },
                new Livro{Id = 256, Nome = "O Cortiço" },
                new Livro{Id = 512, Nome = "O menino maluquinho" , UrlDaCapa = "https://static.fnac-static.com/multimedia/Images/PT/MC/a6/07/a0/10487718/1540-1/tsp20170802172000/O-Menino-Maluquinho.jpg"},
                new Livro{Id = 64, Nome = "O olho do mundo" },
            };

            return View(lsitaLivros);
        }


        public string ObterUrlDaImagem(string url)
        {
            return url;
        }

        public IActionResult ExemploAulaLivro()
        {
            var novoLivro = new Livro { Id = 314, Nome = "Harry Potter" };
            return View(novoLivro);
        }


        public IActionResult ExemploAulaEditorLivro()
        {
            var novoLivro = new Livro { Id = 314, Nome = "Harry Potter" };
            return View(novoLivro);
        }


        public IActionResult ExemploAulaPartialView()
        {
            var novoLivro = new Livro { Id = 314, Nome = "Harry Potter" };
            return PartialView(novoLivro);
        }




        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}