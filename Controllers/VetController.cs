using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ah799415MIS4200.DAL;
using ah799415MIS4200.Models;

namespace ah799415MIS4200.Controllers
{
    public class VetController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.Vets.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet Vet = db.Vets.Find(id);
            if (Vet == null)
            {
                return HttpNotFound();
            }
            return View(Vet);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vetID,vetDescription,vetCost")] Vet Vet)
        {
            if (ModelState.IsValid)
            {
                db.Vets.Add(Vet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Vet);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet Vet = db.Vets.Find(id);
            if (Vet == null)
            {
                return HttpNotFound();
            }
            return View(Vet);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vetID,vetDescription,vetCost")] Vet Vet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Vet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Vet);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet Vet = db.Vets.Find(id);
            if (Vet == null)
            {
                return HttpNotFound();
            }
            return View(Vet);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vet Vet = db.Vets.Find(id);
            db.Vets.Remove(Vet);
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
