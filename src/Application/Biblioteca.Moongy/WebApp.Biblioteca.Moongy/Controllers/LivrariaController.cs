using Microsoft.AspNetCore.Mvc;
using WebApp.Biblioteca.Moongy.Models;

namespace WebApp.Biblioteca.Moongy.Controllers
{
    public class LivrariaController : Controller
    {
        public IActionResult Index()
        {
            var ctx = new BibliotecaContext();

            var leitor = new Models.Leitor
            {
                Id = 155,
                Nome = "Luiz",
                NIF = "123456789"
            };
            ctx.Leitores.Add(leitor);



            ctx.SaveChanges();

            return View();
        }
    }
}
