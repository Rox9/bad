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
    public class OFERTASController : Controller
    {
        private BDLUPITAEntities db = new BDLUPITAEntities();

        // GET: OFERTAS
        public ActionResult Index()
        {
            var oFERTAS = db.OFERTAS.Include(o => o.LICITACIONES).Include(o => o.PROVEEDORES);
            return View(oFERTAS.ToList());
        }

        // GET: OFERTAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFERTAS oFERTAS = db.OFERTAS.Find(id);
            if (oFERTAS == null)
            {
                return HttpNotFound();
            }
            return View(oFERTAS);
        }

        // GET: OFERTAS/Create
        public ActionResult Create()
        {
            ViewBag.LICITACION_ID = new SelectList(db.LICITACIONES, "LICITACION_ID", "LICITACION_DESCRIPCION");
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA");
            return View();
        }

        // POST: OFERTAS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OFERTA_ID,LICITACION_ID,PROVEEDOR_ID,OFERTA_PRECIO,OFERTA_DESCRIPCION")] OFERTAS oFERTAS)
        {
            if (ModelState.IsValid)
            {
                db.OFERTAS.Add(oFERTAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LICITACION_ID = new SelectList(db.LICITACIONES, "LICITACION_ID", "LICITACION_DESCRIPCION", oFERTAS.LICITACION_ID);
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", oFERTAS.PROVEEDOR_ID);
            return View(oFERTAS);
        }

        // GET: OFERTAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFERTAS oFERTAS = db.OFERTAS.Find(id);
            if (oFERTAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.LICITACION_ID = new SelectList(db.LICITACIONES, "LICITACION_ID", "LICITACION_DESCRIPCION", oFERTAS.LICITACION_ID);
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", oFERTAS.PROVEEDOR_ID);
            return View(oFERTAS);
        }

        // POST: OFERTAS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OFERTA_ID,LICITACION_ID,PROVEEDOR_ID,OFERTA_PRECIO,OFERTA_DESCRIPCION")] OFERTAS oFERTAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oFERTAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LICITACION_ID = new SelectList(db.LICITACIONES, "LICITACION_ID", "LICITACION_DESCRIPCION", oFERTAS.LICITACION_ID);
            ViewBag.PROVEEDOR_ID = new SelectList(db.PROVEEDORES, "PROVEEDOR_ID", "PROVEEDOR_EMPRESA", oFERTAS.PROVEEDOR_ID);
            return View(oFERTAS);
        }

        // GET: OFERTAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFERTAS oFERTAS = db.OFERTAS.Find(id);
            if (oFERTAS == null)
            {
                return HttpNotFound();
            }
            return View(oFERTAS);
        }

        // POST: OFERTAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OFERTAS oFERTAS = db.OFERTAS.Find(id);
            db.OFERTAS.Remove(oFERTAS);
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
