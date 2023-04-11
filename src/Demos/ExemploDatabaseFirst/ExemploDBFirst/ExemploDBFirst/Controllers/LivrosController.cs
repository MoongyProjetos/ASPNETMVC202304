using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExemploDBFirst;

namespace ExemploDBFirst.Controllers
{
    public class LivrosController : Controller
    {
        private BibliotecaDB db = new BibliotecaDB();

        // GET: Livros
        public ActionResult Index()
        {
            var livros = db.Livros.Include(l => l.Biblioteca).ToList();
            return View(livros);
        }




        // GET: Livros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            return View(livros);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            ViewBag.BibliotecaId = new SelectList(db.Biblioteca, "Id", "Nome");
            return View(new Livros());
        }

        // POST: Livros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Autor,Editora,BibliotecaId,NumeroPaginas")] Livros livros)
        {
            if (ModelState.IsValid)
            {
                db.Livros.Add(livros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BibliotecaId = new SelectList(db.Biblioteca, "Id", "Nome", livros.BibliotecaId);
            return View(livros);
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            ViewBag.BibliotecaId = new SelectList(db.Biblioteca, "Id", "Nome", livros.BibliotecaId);
            return View(livros);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Autor,Editora,BibliotecaId,NumeroPaginas")] Livros livros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BibliotecaId = new SelectList(db.Biblioteca, "Id", "Nome", livros.BibliotecaId);
            return View(livros);
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            return View(livros);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Livros livros = db.Livros.Find(id);
            db.Livros.Remove(livros);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
