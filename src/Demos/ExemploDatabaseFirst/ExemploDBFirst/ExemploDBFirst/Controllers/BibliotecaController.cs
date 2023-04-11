using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploDBFirst.Controllers
{
    public class BibliotecaController : Controller
    {
        // GET: Biblioteca
        public ActionResult Index()
        {
            var bibliotecaLisboa = new Biblioteca();
            bibliotecaLisboa.Nome = "Lisboa 2";
            bibliotecaLisboa.Endereco = "Praça do Comércio";
            bibliotecaLisboa.Telefone = "+351126789";

            var livro1 = new Livros();
            livro1.Nome = "O exorcista 2";
            livro1.Autor = "Nao sei";
            livro1.NumeroPaginas = 1000;
            livro1.Biblioteca = bibliotecaLisboa;

            var livro2 = new Livros();
            livro2.Nome = "Israel em abril 2";
            livro2.Autor = "Érico Veríssimo";
            livro2.NumeroPaginas = 500;
            livro2.Biblioteca = bibliotecaLisboa;

            //var listaLivros = new List<Livros> { livro1, livro2 };

            //bibliotecaLisboa.Livros = listaLivros;



            BibliotecaDB db = new BibliotecaDB();
            db.Livros.Add(livro1);
            db.Livros.Add(livro2);
            db.SaveChanges();


            return View();
        }
    }
}