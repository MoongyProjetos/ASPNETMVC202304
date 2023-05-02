using ExemploRazor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExemploRazor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Exemplo()
        {
            return View();
        }


        public IActionResult ListarLivros()
        {
            var livros = new List<Livro>
            {
                new Livro{ Id = 1, Nome = "TLOTR", ISBN = "1234"},
                new Livro{ Id = 2, Nome = "HarryPotter", ISBN = "4321"},
            };

            return View(livros);
        }


        public IActionResult CriarNovoLivro()
        {
            return View();
        }


        public IActionResult EditarLivro()
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