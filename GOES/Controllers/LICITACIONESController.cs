using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GOES;

namespace GOES.Controllers
{
    public class LICITACIONESController : Controller
    {
        private BDLUPITAEntities db = new BDLUPITAEntities();

        // GET: LICITACIONES
        public ActionResult Index()
        {
            var lICITACIONES = db.LICITACIONES.Include(l => l.SOLICITUDES);
            return View(lICITACIONES.ToList());
        }

        // GET: LICITACIONES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LICITACIONES lICITACIONES = db.LICITACIONES.Find(id);
            if (lICITACIONES == null)
            {
                return HttpNotFound();
            }
            return View(lICITACIONES);
        }

        // GET: LICITACIONES/Create
        public ActionResult Create()
        {
            ViewBag.SOLICITUD_ID = new SelectList(db.SOLICITUDES, "SOLICITUD_ID", "SOLICITUD_RESPONSABLE");
            return View();
        }

        // POST: LICITACIONES/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LICITACION_ID,SOLICITUD_ID,LICITACION_NUMERO,LICITACION_ANIO,LICITACION_INICIO,LICITACION_FINALIZACION,LICITACION_DESCRIPCION")] LICITACIONES lICITACIONES)
        {
            if (ModelState.IsValid)
            {
                db.LICITACIONES.Add(lICITACIONES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SOLICITUD_ID = new SelectList(db.SOLICITUDES, "SOLICITUD_ID", "SOLICITUD_RESPONSABLE", lICITACIONES.SOLICITUD_ID);
            return View(lICITACIONES);
        }

        // GET: LICITACIONES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LICITACIONES lICITACIONES = db.LICITACIONES.Find(id);
            if (lICITACIONES == null)
            {
                return HttpNotFound();
            }
            ViewBag.SOLICITUD_ID = new SelectList(db.SOLICITUDES, "SOLICITUD_ID", "SOLICITUD_RESPONSABLE", lICITACIONES.SOLICITUD_ID);
            return View(lICITACIONES);
        }

        // POST: LICITACIONES/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LICITACION_ID,SOLICITUD_ID,LICITACION_NUMERO,LICITACION_ANIO,LICITACION_INICIO,LICITACION_FINALIZACION,LICITACION_DESCRIPCION")] LICITACIONES lICITACIONES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lICITACIONES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SOLICITUD_ID = new SelectList(db.SOLICITUDES, "SOLICITUD_ID", "SOLICITUD_RESPONSABLE", lICITACIONES.SOLICITUD_ID);
            return View(lICITACIONES);
        }

        // GET: LICITACIONES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LICITACIONES lICITACIONES = db.LICITACIONES.Find(id);
            if (lICITACIONES == null)
            {
                return HttpNotFound();
            }
            return View(lICITACIONES);
        }

        // POST: LICITACIONES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LICITACIONES lICITACIONES = db.LICITACIONES.Find(id);
            db.LICITACIONES.Remove(lICITACIONES);
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
