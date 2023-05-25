using ExemploController.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExemploController.Controllers
{
    public class Valores
    {
        public int valorA { get; set; }
        public int valorB { get; set; }
    }
    public class CalculadoraController : Controller
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int SomarExemploDireto(int valor)
        {
            return 1000 * valor;
        }

        [HttpPost]
        public int SomarExemplo(Valores valor)
        {
            return valor.valorA + valor.valorB;
        }

        [HttpPost]
        public int Dividir(Valores valor)
        {
            return valor.valorA / valor.valorB;
        }


        [Authorize]        
        public int Multiplicar(int a, int b)
        {
            Console.WriteLine($"{DateTime.Now} - Usuario chamou o método");
            ///
            ///


            Console.WriteLine($"{DateTime.Now} - Método X terminou");


            return a * b;
        }

        ///www.minhaapp.pt/ <summary>
        /// www.minhaapp.pt/calculadora/pagina/
        /// www.minhaapp.pt/batata
        /// </summary>
        /// <returns></returns>("batata")]
        /// 
        [MeuLogger]        
        public IActionResult Pagina()
        {
            ViewBag.Conteudo = DateTime.Now.ToString();
            return View();
        }

        public IActionResult PaginaDeRosto()
        {
            return View("2 + 2");
        }
    }
}
