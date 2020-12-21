using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QUANLYSINHVIEN.Models;

namespace QUANLYSINHVIEN.Controllers
{
    public class accoutsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: accouts
        public ActionResult Index()
        {
            return View(db.Accouts.ToList());
        }

        // GET: accouts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // GET: accouts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: accouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,Username,Password,RoleID")] accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Accouts.Add(accout);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accout);
        }

        // GET: accouts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: accouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,Username,Password,RoleID")] accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accout).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accout);
        }

        // GET: accouts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: accouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            accout accout = db.Accouts.Find(id);
            db.Accouts.Remove(accout);
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
