using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aroma_Indigo.Models;

namespace Aroma_Indigo.Controllers
{
    public class ClientTypeController : Controller
    {
        private AromaContext db = new AromaContext();

        //
        // GET: /ClientType/

        public ActionResult Index()
        {
            return View(db.ClientTypes.ToList());
        }

        //
        // GET: /ClientType/Details/5

        public ActionResult Details(int id = 0)
        {
            ClientType clienttype = db.ClientTypes.Find(id);
            if (clienttype == null)
            {
                return HttpNotFound();
            }
            return View(clienttype);
        }

        //
        // GET: /ClientType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ClientType/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientType clienttype)
        {
            if (ModelState.IsValid)
            {
                db.ClientTypes.Add(clienttype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienttype);
        }

        //
        // GET: /ClientType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ClientType clienttype = db.ClientTypes.Find(id);
            if (clienttype == null)
            {
                return HttpNotFound();
            }
            return View(clienttype);
        }

        //
        // POST: /ClientType/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientType clienttype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienttype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienttype);
        }

        //
        // GET: /ClientType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ClientType clienttype = db.ClientTypes.Find(id);
            if (clienttype == null)
            {
                return HttpNotFound();
            }
            return View(clienttype);
        }

        //
        // POST: /ClientType/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientType clienttype = db.ClientTypes.Find(id);
            db.ClientTypes.Remove(clienttype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}