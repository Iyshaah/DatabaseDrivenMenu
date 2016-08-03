using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseDrivenMenu.Models;

namespace DatabaseDrivenMenu.Controllers
{
    public class Class_DbDrivenMenuController : Controller
    {
        private Class_DbDrivenMenuDBContext db = new Class_DbDrivenMenuDBContext();

        // GET: Class_DbDrivenMenu
        public ActionResult Index()
        {
            return View(db.Class_DbDrivenMenus.ToList());
        }

        // GET: Class_DbDrivenMenu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_DbDrivenMenu class_DbDrivenMenu = db.Class_DbDrivenMenus.Find(id);
            if (class_DbDrivenMenu == null)
            {
                return HttpNotFound();
            }
            return View(class_DbDrivenMenu);
        }

        // GET: Class_DbDrivenMenu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class_DbDrivenMenu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Parent_ID")] Class_DbDrivenMenu class_DbDrivenMenu)
        {
            if (ModelState.IsValid)
            {
                db.Class_DbDrivenMenus.Add(class_DbDrivenMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(class_DbDrivenMenu);
        }

        // GET: Class_DbDrivenMenu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_DbDrivenMenu class_DbDrivenMenu = db.Class_DbDrivenMenus.Find(id);
            if (class_DbDrivenMenu == null)
            {
                return HttpNotFound();
            }
            return View(class_DbDrivenMenu);
        }

        // POST: Class_DbDrivenMenu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Parent_ID")] Class_DbDrivenMenu class_DbDrivenMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(class_DbDrivenMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(class_DbDrivenMenu);
        }

        // GET: Class_DbDrivenMenu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_DbDrivenMenu class_DbDrivenMenu = db.Class_DbDrivenMenus.Find(id);
            if (class_DbDrivenMenu == null)
            {
                return HttpNotFound();
            }
            return View(class_DbDrivenMenu);
        }

        // POST: Class_DbDrivenMenu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class_DbDrivenMenu class_DbDrivenMenu = db.Class_DbDrivenMenus.Find(id);
            db.Class_DbDrivenMenus.Remove(class_DbDrivenMenu);
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
