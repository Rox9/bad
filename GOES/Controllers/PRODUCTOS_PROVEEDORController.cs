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
    public class PRODUCTOS_PROVEEDORController : Controller
    {
        private BDLUPITAEntities db = new BDLUPITAEntities();

        // GET: PRODUCTOS_PROVEEDOR
        public ActionResult Index()
        {
            var pRODUCTOS_PROVEEDOR = db.PRODUCTOS_PROVEEDOR.Include(p => p.PROVEEDORES);
            return View(pRODUCTOS_PROVEEDOR.ToList());
        }

        // GET: PRODUCTOS_PROVEEDOR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR = db.PRODUCTOS_PROVEEDOR.Find(id);
            if (pRODUCTOS_PROVEEDOR == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTOS_PROVEEDOR);
        }

        // GET: PRODUCTOS_PROVEEDOR/Create
        public ActionResult Create()
        {
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA");
            return View();
        }

        // POST: PRODUCTOS_PROVEEDOR/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PROD_PROVEEDOR_ID,PROVEEDOR_ID,PROD_PROVEEDOR_NOMBRE,PROD_PROVEEDOR_MARCA,PROD_PROVEEDOR_MODELO,PROD_PROVEEDOR_ANIO,PROD_PROVEEDOR_BTU,PROD_PROVEEDOR_POTENCIA,PROD_PROVEEDOR_COLOR,PROD_PROVEEDOR_EXISTENCIAS,PROD_PROVEEDOR_DESCRIPCION,PROD_PROVEEDOR_VOLTAJE,PROD_PROVEEDOR_AREA")] PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR)
        {
            if (ModelState.IsValid)
            {
                db.PRODUCTOS_PROVEEDOR.Add(pRODUCTOS_PROVEEDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", pRODUCTOS_PROVEEDOR.PROVEEDOR_ID);
            return View(pRODUCTOS_PROVEEDOR);
        }

        // GET: PRODUCTOS_PROVEEDOR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR = db.PRODUCTOS_PROVEEDOR.Find(id);
            if (pRODUCTOS_PROVEEDOR == null)
            {
                return HttpNotFound();
            }
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", pRODUCTOS_PROVEEDOR.PROVEEDOR_ID);
            return View(pRODUCTOS_PROVEEDOR);
        }

        // POST: PRODUCTOS_PROVEEDOR/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PROD_PROVEEDOR_ID,PROVEEDOR_ID,PROD_PROVEEDOR_NOMBRE,PROD_PROVEEDOR_MARCA,PROD_PROVEEDOR_MODELO,PROD_PROVEEDOR_ANIO,PROD_PROVEEDOR_BTU,PROD_PROVEEDOR_POTENCIA,PROD_PROVEEDOR_COLOR,PROD_PROVEEDOR_EXISTENCIAS,PROD_PROVEEDOR_DESCRIPCION,PROD_PROVEEDOR_VOLTAJE,PROD_PROVEEDOR_AREA")] PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUCTOS_PROVEEDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", pRODUCTOS_PROVEEDOR.PROVEEDOR_ID);
            return View(pRODUCTOS_PROVEEDOR);
        }

        // GET: PRODUCTOS_PROVEEDOR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR = db.PRODUCTOS_PROVEEDOR.Find(id);
            if (pRODUCTOS_PROVEEDOR == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTOS_PROVEEDOR);
        }

        // POST: PRODUCTOS_PROVEEDOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCTOS_PROVEEDOR pRODUCTOS_PROVEEDOR = db.PRODUCTOS_PROVEEDOR.Find(id);
            db.PRODUCTOS_PROVEEDOR.Remove(pRODUCTOS_PROVEEDOR);
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
