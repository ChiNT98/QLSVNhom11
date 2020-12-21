using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QUANLYSINHVIEN.Models;

namespace QUANLYSINHVIEN.Areas.Admin.Controllers
{
    public class DiemThisController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: Admin/DiemThis
        public ActionResult Index()
        {
            return View(db.DiemThis.ToList());
        }

        // GET: Admin/DiemThis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(id);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            return View(diemThi);
        }

        // GET: Admin/DiemThis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DiemThis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSv,TenSv,MaMh,TenMh,Diem")] DiemThi diemThi)
        {
            if (ModelState.IsValid)
            {
                db.DiemThis.Add(diemThi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diemThi);
        }

        // GET: Admin/DiemThis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(id);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            return View(diemThi);
        }

        // POST: Admin/DiemThis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSv,TenSv,MaMh,TenMh,Diem")] DiemThi diemThi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diemThi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diemThi);
        }

        // GET: Admin/DiemThis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(id);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            return View(diemThi);
        }

        // POST: Admin/DiemThis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DiemThi diemThi = db.DiemThis.Find(id);
            db.DiemThis.Remove(diemThi);
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
