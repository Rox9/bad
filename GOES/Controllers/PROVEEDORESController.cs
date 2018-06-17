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
    public class PROVEEDORESController : Controller
    {
        private BDLUPITAEntities db = new BDLUPITAEntities();

        // GET: PROVEEDORES
        public ActionResult Index()
        {
            var pROVEEDORES = db.PROVEEDORES.Include(p => p.MUNICIPIOS);
            return View(pROVEEDORES.ToList());
        }

        // GET: PROVEEDORES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROVEEDORES pROVEEDORES = db.PROVEEDORES.Find(id);
            if (pROVEEDORES == null)
            {
                return HttpNotFound();
            }
            return View(pROVEEDORES);
        }

        // GET: PROVEEDORES/Create
        public ActionResult Create()
        {
            ViewBag.MUNICIPIO_ID = new SelectList(db.MUNICIPIOS, "MUNICIPIO_ID", "MUNICIPIO_NOMBRE");
            return View();
        }

        // POST: PROVEEDORES/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PROVEEDOR_ID,MUNICIPIO_ID,PROVEEDOR_EMPRESA,PROVEEDOR_CONTACTO,PROVEEDOR_TELEFONO1,PROVEEDOR_TELEFONO2,PROVEEDOR_CORREO,PROVEEDOR_NIT,PROVEEDOR_DESCRIPCION,PROVEEDOR_DIRECCION")] PROVEEDORES pROVEEDORES)
        {
            if (ModelState.IsValid)
            {
                db.PROVEEDORES.Add(pROVEEDORES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MUNICIPIO_ID = new SelectList(db.MUNICIPIOS, "MUNICIPIO_ID", "MUNICIPIO_NOMBRE", pROVEEDORES.MUNICIPIO_ID);
            return View(pROVEEDORES);
        }

        // GET: PROVEEDORES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROVEEDORES pROVEEDORES = db.PROVEEDORES.Find(id);
            if (pROVEEDORES == null)
            {
                return HttpNotFound();
            }
            ViewBag.MUNICIPIO_ID = new SelectList(db.MUNICIPIOS, "MUNICIPIO_ID", "MUNICIPIO_NOMBRE", pROVEEDORES.MUNICIPIO_ID);
            return View(pROVEEDORES);
        }

        // POST: PROVEEDORES/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PROVEEDOR_ID,MUNICIPIO_ID,PROVEEDOR_EMPRESA,PROVEEDOR_CONTACTO,PROVEEDOR_TELEFONO1,PROVEEDOR_TELEFONO2,PROVEEDOR_CORREO,PROVEEDOR_NIT,PROVEEDOR_DESCRIPCION,PROVEEDOR_DIRECCION")] PROVEEDORES pROVEEDORES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROVEEDORES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MUNICIPIO_ID = new SelectList(db.MUNICIPIOS, "MUNICIPIO_ID", "MUNICIPIO_NOMBRE", pROVEEDORES.MUNICIPIO_ID);
            return View(pROVEEDORES);
        }

        // GET: PROVEEDORES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROVEEDORES pROVEEDORES = db.PROVEEDORES.Find(id);
            if (pROVEEDORES == null)
            {
                return HttpNotFound();
            }
            return View(pROVEEDORES);
        }

        // POST: PROVEEDORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROVEEDORES pROVEEDORES = db.PROVEEDORES.Find(id);
            db.PROVEEDORES.Remove(pROVEEDORES);
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
