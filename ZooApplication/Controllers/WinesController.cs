using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZooApplication.Models;

namespace ZooApplication.Controllers
{
    public class WinesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Wines
        public ActionResult Index()
        {
            return View(db.Wines.ToList());
        }

        // GET: Wines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wines wines = db.Wines.Find(id);
            if (wines == null)
            {
                return HttpNotFound();
            }
            return View(wines);
        }

        // GET: Wines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Country,description")] Wines wines)
        {
            if (ModelState.IsValid)
            {
                db.Wines.Add(wines);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wines);
        }

        // GET: Wines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wines wines = db.Wines.Find(id);
            if (wines == null)
            {
                return HttpNotFound();
            }
            return View(wines);
        }

        // POST: Wines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Country,description")] Wines wines)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wines).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wines);
        }

        // GET: Wines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wines wines = db.Wines.Find(id);
            if (wines == null)
            {
                return HttpNotFound();
            }
            return View(wines);
        }

        // POST: Wines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wines wines = db.Wines.Find(id);
            db.Wines.Remove(wines);
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
