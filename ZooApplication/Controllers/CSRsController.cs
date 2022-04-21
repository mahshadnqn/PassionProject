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
    public class CSRsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CSRs
        public ActionResult Index()
        {
            return View(db.CSRs.ToList());
        }

        // GET: CSRs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CSRs cSRs = db.CSRs.Find(id);
            if (cSRs == null)
            {
                return HttpNotFound();
            }
            return View(cSRs);
        }

        // GET: CSRs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CSRs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fname,Lname,Status")] CSRs cSRs)
        {
            if (ModelState.IsValid)
            {
                db.CSRs.Add(cSRs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cSRs);
        }

        // GET: CSRs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CSRs cSRs = db.CSRs.Find(id);
            if (cSRs == null)
            {
                return HttpNotFound();
            }
            return View(cSRs);
        }

        // POST: CSRs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fname,Lname,Status")] CSRs cSRs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cSRs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cSRs);
        }

        // GET: CSRs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CSRs cSRs = db.CSRs.Find(id);
            if (cSRs == null)
            {
                return HttpNotFound();
            }
            return View(cSRs);
        }

        // POST: CSRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CSRs cSRs = db.CSRs.Find(id);
            db.CSRs.Remove(cSRs);
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
