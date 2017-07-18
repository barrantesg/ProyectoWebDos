using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoEmpresarial.Models;

namespace ProyectoEmpresarial.Controllers
{
    public class SoportesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Soporte()
        {          
            return View();
        }
        public ActionResult TablaSoporte()
        {
            return View();
        }
        // GET: Soportes
        public ActionResult Index()
        {
            return View(db.Soportes.ToList());
        }

        // GET: Soportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soporte soporte = db.Soportes.Find(id);
            if (soporte == null)
            {
                return HttpNotFound();
            }
            return View(soporte);
        }

        // GET: Clientes/Create //Carga los datos de la BD
        public ActionResult Create()
        {
            int a = 0;
            List<SelectListItem> items = new List<SelectListItem>();

            foreach (var cliente in db.Clientes.ToList())
            {
                items.Add(new SelectListItem { Text = cliente.nombre, Value = a.ToString() });
                a++;
            }

            ViewBag.Cliente_Pertenece = items;

            return View();
        }

        // POST: Soportes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,problema,descripcion,personaReporta,cliente,estadoActual")] Soporte soporte)
        {
            if (ModelState.IsValid)
            {
                db.Soportes.Add(soporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soporte);
        }

        // GET: Soportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soporte soporte = db.Soportes.Find(id);
            if (soporte == null)
            {
                return HttpNotFound();
            }
            return View(soporte);
        }

        // POST: Soportes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,problema,descripcion,personaReporta,cliente,estadoActual")] Soporte soporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soporte);
        }

        // GET: Soportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soporte soporte = db.Soportes.Find(id);
            if (soporte == null)
            {
                return HttpNotFound();
            }
            return View(soporte);
        }

        // POST: Soportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soporte soporte = db.Soportes.Find(id);
            db.Soportes.Remove(soporte);
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
