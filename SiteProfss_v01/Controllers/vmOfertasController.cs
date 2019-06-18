using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiteProfss_v01.Models.Clases;
using SiteProfss_v01.Models.DB;

namespace SiteProfss_v01.Controllers
{
    public class vmOfertasController : Controller
    {
        private DB_SiteProfss db = new DB_SiteProfss();

        //// GET: vmOfertas
        //public ActionResult Index()
        //{
        //    var vmOfertas = db.vmOfertas.Include(v => v.Categoria).Include(v => v.Departamento).Include(v => v.TiempoContratacion);
        //    return View(vmOfertas.ToList());
        //}

        //// GET: vmOfertas/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmOferta vmOferta = db.vmOfertas.Find(id);
        //    if (vmOferta == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vmOferta);
        //}

        //// GET: vmOfertas/Create
        //public ActionResult Create()
        //{
        //    ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo");
        //    ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
        //    ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo");
        //    return View();
        //}

        //// POST: vmOfertas/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Titulo,Descripcion,AreaLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,CategoriaId,DepartamentoId,TiempoContratacionId")] vmOferta vmOferta)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.vmOfertas.Add(vmOferta);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", vmOferta.CategoriaId);
        //    ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", vmOferta.DepartamentoId);
        //    ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", vmOferta.TiempoContratacionId);
        //    return View(vmOferta);
        //}

        //// GET: vmOfertas/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmOferta vmOferta = db.vmOfertas.Find(id);
        //    if (vmOferta == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", vmOferta.CategoriaId);
        //    ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", vmOferta.DepartamentoId);
        //    ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", vmOferta.TiempoContratacionId);
        //    return View(vmOferta);
        //}

        //// POST: vmOfertas/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Titulo,Descripcion,AreaLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,CategoriaId,DepartamentoId,TiempoContratacionId")] vmOferta vmOferta)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(vmOferta).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", vmOferta.CategoriaId);
        //    ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", vmOferta.DepartamentoId);
        //    ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", vmOferta.TiempoContratacionId);
        //    return View(vmOferta);
        //}

        //// GET: vmOfertas/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmOferta vmOferta = db.vmOfertas.Find(id);
        //    if (vmOferta == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vmOferta);
        //}

        //// POST: vmOfertas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    vmOferta vmOferta = db.vmOfertas.Find(id);
        //    db.vmOfertas.Remove(vmOferta);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
