using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiteProfss_v01.Models.DB;
using SiteProfss_v01.Models.Clases;
using System.Web.UI;

namespace SiteProfss_v01.Controllers
{
    public class OfertasController : Controller
    {
        private DB_SiteProfss db = new DB_SiteProfss();

        // GET: Ofertas
        public ActionResult Index()
        {
            var ofertas = db.Ofertas.Include(o => o.Categoria).Include(o => o.Departamento).Include(o => o.Empresa).Include(o => o.TiempoContratacion);
            return View(ofertas.ToList());
        }

        public ActionResult ListarOfertas(string p)
        {
            var lstOfertas = (db.Ofertas.Where(o => o.Descripcion.Contains(p) || o.Titulo.Contains(p)).Select(o => o).OrderBy(o => o.FechaPublicacion).Include(o => o.Categoria).Include(o => o.Departamento).Include(o => o.Empresa).Include(o => o.TiempoContratacion)).ToList();

            var lstvmOfertas = new List<vmOferta>();
            foreach (Oferta o in lstOfertas)
            {
                lstvmOfertas.Add(new vmOferta
                {
                    Id = o.Id,
                    Titulo = o.Titulo,
                    Descripcion = o.Descripcion,
                    FechaPublicacion = o.FechaPublicacion,
                    AreaLaboral = o.AreaLaboral,
                    CantidadVacantes = o.CantidadVacantes,
                    HabilidadesRequeridas = o.HabilidadesRequeridas,
                    EdadDesde = o.EdadDesde,
                    EdadHasta = o.EdadHasta,
                    Remuneracion = o.Remuneracion,
                    TransporteRecorrido = o.TransporteRecorrido,
                    FechaLimiteSolicitud = o.FechaLimiteSolicitud,
                    Categoria = o.Categoria,
                    Departamento = o.Departamento,
                    TiempoContratacion = o.TiempoContratacion
                });
            }
            return View(lstvmOfertas);

        }

        // GET: Ofertas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            return View(oferta);
        }

        // GET: Ofertas/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo");
            ViewBag.EmpresaId = new SelectList(db.Usuarios, "Id", "Email");
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo");
            return View();
        }

        // POST: Ofertas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Descripcion,FechaPublicacion,ArearLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,Anulada,EmpresaId,CategoriaId,DepartamentoId,TiempoContratacionId")] Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                db.Ofertas.Add(oferta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", oferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", oferta.DepartamentoId);
            ViewBag.EmpresaId = new SelectList(db.Usuarios, "Id", "Email", oferta.EmpresaId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", oferta.TiempoContratacionId);
            return View(oferta);
        }

        // GET: Ofertas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", oferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", oferta.DepartamentoId);
            ViewBag.EmpresaId = new SelectList(db.Usuarios, "Id", "Email", oferta.EmpresaId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", oferta.TiempoContratacionId);
            return View(oferta);
        }

        // POST: Ofertas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Descripcion,FechaPublicacion,AreaLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,Anulada,EmpresaId,CategoriaId,DepartamentoId,TiempoContratacionId")] Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oferta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Codigo", oferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "Codigo", oferta.DepartamentoId);
            ViewBag.EmpresaId = new SelectList(db.Usuarios, "Id", "Email", oferta.EmpresaId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Codigo", oferta.TiempoContratacionId);
            return View(oferta);
        }

        // GET: Ofertas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            return View(oferta);
        }

        // POST: Ofertas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Oferta oferta = db.Ofertas.Find(id);
            db.Ofertas.Remove(oferta);
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
