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
    public class ReunionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Reunion()
        {
            return View();
        }

        public ActionResult TablaReuniones()
        {
            return View();
        }

        // GET: Reunions
        public ActionResult Index()
        {
            return View(db.Reunions.ToList());
        }

        // GET: Reunions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // GET: Reunions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reunions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombreReunion,dia,hora,empleadoAsignado,virtua,cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Reunions.Add(reunion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reunion);
        }

        // GET: Reunions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // POST: Reunions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombreReunion,dia,hora,empleadoAsignado,virtua,cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reunion);
        }

        // GET: Reunions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // POST: Reunions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reunion reunion = db.Reunions.Find(id);
            db.Reunions.Remove(reunion);
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
