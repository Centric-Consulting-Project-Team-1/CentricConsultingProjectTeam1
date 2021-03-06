using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CentricConsultingProjectTeam1.DAL;
using CentricConsultingProjectTeam1.Models;

namespace CentricConsultingProjectTeam1.Controllers
{
    public class RecognizesController : Controller
    {
        private CentricConsultingProjectTeam1Context db = new CentricConsultingProjectTeam1Context();

        // GET: Recognizes
        public ActionResult Index()
        {
            return View(db.Recognizes.ToList());
        }

        // GET: Recognizes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognize recognize = db.Recognizes.Find(id);
            if (recognize == null)
            {
                return HttpNotFound();
            }
            return View(recognize);
        }

        // GET: Recognizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recognizes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecognizeID,EmployeeID,CoreValueIndicator,MessageOption,Message")] Recognize recognize)
        {
            if (ModelState.IsValid)
            {
                db.Recognizes.Add(recognize);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognize);
        }

        // GET: Recognizes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognize recognize = db.Recognizes.Find(id);
            if (recognize == null)
            {
                return HttpNotFound();
            }
            return View(recognize);
        }

        // POST: Recognizes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecognizeID,EmployeeID,CoreValueIndicator,MessageOption,Message")] Recognize recognize)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognize).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognize);
        }

        // GET: Recognizes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognize recognize = db.Recognizes.Find(id);
            if (recognize == null)
            {
                return HttpNotFound();
            }
            return View(recognize);
        }

        // POST: Recognizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recognize recognize = db.Recognizes.Find(id);
            db.Recognizes.Remove(recognize);
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
