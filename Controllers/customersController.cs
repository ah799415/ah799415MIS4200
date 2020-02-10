﻿using System;
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
    public class customersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: customers
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        // GET: customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet Pet = db.Pets.Find(id);
            if (Pet == null)
            {
                return HttpNotFound();
            }
            return View(Pet);
        }

        // GET: customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petID,ownerFirstName,ownerLastName,petName,ownerPhone,patientSince")] Pet Pet)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(Pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Pet);
        }

        // GET: customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet Pet = db.Pets.Find(id);
            if (Pet == null)
            {
                return HttpNotFound();
            }
            return View(Pet);
        }

        // POST: customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petID,ownerFirstName,ownerLastName,petName,ownerPhone,patientSince")] Pet Pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Pet);
        }

        // GET: customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet Pet = db.Pets.Find(id);
            if (Pet == null)
            {
                return HttpNotFound();
            }
            return View(Pet);
        }

        // POST: customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet Pet = db.Pets.Find(id);
            db.Pets.Remove(Pet);
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
