using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteProfss_v01.Models.DB;
using SiteProfss_v01.Models.Clases;
using System.Net;
using System.Data.Entity;

namespace SiteProfss_v01.Controllers
{
    public class dbd_EmpresaController : Controller
    {
        private DB_SiteProfss db = new DB_SiteProfss();

        // GET: dbdEmpresa
        public ActionResult Index()
        {
            return View();
        }


        // GET: Ofertas/Create
        public ActionResult CrearOferta()
        {
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento");
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Descripcion");
            return View();
        }

        // POST: Ofertas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearOferta([Bind(Include = "Id,Titulo,Descripcion,AreaLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,CategoriaId,DepartamentoId,TiempoContratacionId")] vmOferta vmOferta)
        {
            if (ModelState.IsValid)
            {
                Oferta oOferta = new Oferta
                {
                    Titulo = vmOferta.Titulo,
                    Descripcion = vmOferta.Descripcion,
                    FechaPublicacion = DateTime.Now,
                    AreaLaboral = vmOferta.AreaLaboral,
                    CantidadVacantes = vmOferta.CantidadVacantes,
                    HabilidadesRequeridas = vmOferta.HabilidadesRequeridas,
                    EdadDesde = vmOferta.EdadDesde,
                    EdadHasta = vmOferta.EdadHasta,
                    Remuneracion = vmOferta.Remuneracion,
                    TransporteRecorrido = vmOferta.TransporteRecorrido,
                    FechaLimiteSolicitud = vmOferta.FechaLimiteSolicitud,
                    Anulada = false,
                    EmpresaId = db.Usuarios.FirstOrDefault(u => u.Email == User.Identity.Name).Id,
                    CategoriaId = vmOferta.CategoriaId,
                    DepartamentoId = vmOferta.DepartamentoId,
                    TiempoContratacionId = vmOferta.TiempoContratacionId

                };

                db.Ofertas.Add(oOferta);
                db.SaveChanges();
                return RedirectToAction("ListarOfertasEmpresa", new { pEmpresaId = oOferta.EmpresaId });
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria", vmOferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento", vmOferta.DepartamentoId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Descripcion", vmOferta.TiempoContratacionId);
            return View(vmOferta);
        }

        public ActionResult EditarOferta(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Oferta oOferta = db.Ofertas.Find(id);
            if (oOferta == null)
            {
                return HttpNotFound();
            }

            vmOferta vmOferta = new vmOferta
            {
                Id = oOferta.Id,
                Titulo = oOferta.Titulo,
                Descripcion = oOferta.Descripcion,
                AreaLaboral = oOferta.AreaLaboral,
                CantidadVacantes = oOferta.CantidadVacantes,
                HabilidadesRequeridas = oOferta.HabilidadesRequeridas,
                EdadDesde = oOferta.EdadDesde,
                EdadHasta = oOferta.EdadHasta,
                Remuneracion = oOferta.Remuneracion,
                TransporteRecorrido = oOferta.TransporteRecorrido,
                FechaLimiteSolicitud = oOferta.FechaLimiteSolicitud,

            };

            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria", vmOferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento", vmOferta.DepartamentoId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Descripcion", vmOferta.TiempoContratacionId);

            return View(vmOferta);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarOferta([Bind(Include = "Id,Titulo,Descripcion,AreaLaboral,CantidadVacantes,HabilidadesRequeridas,EdadDesde,EdadHasta,Remuneracion,TransporteRecorrido,FechaLimiteSolicitud,CategoriaId,DepartamentoId,TiempoContratacionId")] vmOferta vmOferta)
        {
            if (ModelState.IsValid)
            {
                Oferta oOferta = db.Ofertas.Find(vmOferta.Id);
                oOferta.Titulo = vmOferta.Titulo;
                oOferta.Descripcion = vmOferta.Descripcion;
                oOferta.AreaLaboral = vmOferta.AreaLaboral;
                oOferta.CantidadVacantes = vmOferta.CantidadVacantes;
                oOferta.HabilidadesRequeridas = vmOferta.HabilidadesRequeridas;
                oOferta.EdadDesde = vmOferta.EdadDesde;
                oOferta.EdadHasta = vmOferta.EdadHasta;
                oOferta.Remuneracion = vmOferta.Remuneracion;
                oOferta.TransporteRecorrido = vmOferta.TransporteRecorrido;
                oOferta.FechaLimiteSolicitud = vmOferta.FechaLimiteSolicitud;
                oOferta.CategoriaId = vmOferta.CategoriaId;
                oOferta.DepartamentoId = vmOferta.DepartamentoId;
                oOferta.TiempoContratacionId = vmOferta.TiempoContratacionId;

                db.Entry(oOferta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListarOfertasEmpresa", new { pEmpresaId = oOferta.EmpresaId });
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria", vmOferta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento", vmOferta.DepartamentoId);
            ViewBag.TiempoContratacionId = new SelectList(db.TiemposContratacion, "Id", "Descripcion", vmOferta.TiempoContratacionId);
            return View(vmOferta);
        }

        public ActionResult ListarOfertasEmpresa(int pEmpresaId)
        {
            var lstOfertas = (db.Ofertas.Where(o => o.EmpresaId == pEmpresaId).Select(o => o).OrderBy(o => o.FechaPublicacion).Include(o => o.Categoria).Include(o => o.Departamento).Include(o => o.TiempoContratacion)).ToList();
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
        public ActionResult DetallesOferta(int? id)
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

    }
}

       