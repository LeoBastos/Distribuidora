using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Distribuidora.Context;
using Distribuidora.Models;

namespace Distribuidora.Controllers
{
    public class ItensDoPedidoController : Controller
    {
        private DistribuidoraContext db = new DistribuidoraContext();

        // GET: ItensDoPedido
        public ActionResult Index()
        {
            return View(db.itensDoPedido.ToList());
        }

        // GET: ItensDoPedido/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItensDoPedido itensDoPedido = db.itensDoPedido.Find(id);
            if (itensDoPedido == null)
            {
                return HttpNotFound();
            }
            return View(itensDoPedido);
        }

        // GET: ItensDoPedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItensDoPedido/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItensDoPedidoId,QuantidadeItens,Preco,ValorTotal")] ItensDoPedido itensDoPedido)
        {
            if (ModelState.IsValid)
            {
                db.itensDoPedido.Add(itensDoPedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itensDoPedido);
        }

        // GET: ItensDoPedido/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItensDoPedido itensDoPedido = db.itensDoPedido.Find(id);
            if (itensDoPedido == null)
            {
                return HttpNotFound();
            }
            return View(itensDoPedido);
        }

        // POST: ItensDoPedido/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItensDoPedidoId,QuantidadeItens,Preco,ValorTotal")] ItensDoPedido itensDoPedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itensDoPedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itensDoPedido);
        }

        // GET: ItensDoPedido/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItensDoPedido itensDoPedido = db.itensDoPedido.Find(id);
            if (itensDoPedido == null)
            {
                return HttpNotFound();
            }
            return View(itensDoPedido);
        }

        // POST: ItensDoPedido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItensDoPedido itensDoPedido = db.itensDoPedido.Find(id);
            db.itensDoPedido.Remove(itensDoPedido);
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
