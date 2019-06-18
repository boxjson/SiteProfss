using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteProfss_v01.Models.DB;
using SiteProfss_v01.Models.Clases;


namespace SiteProfss_v01.Controllers
{
    public class dbd_SolicitanteController : Controller
    {
        public DB_SiteProfss db = new DB_SiteProfss();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarAlertasSolicitante(int idSolc)
        {
            var lstAlertas = (db.Alertas.Where(a => a.SolicitanteId == idSolc).Select(a => a).OrderBy(a => a.FechaCreacion));
            return View(lstAlertas);
        }

        public ActionResult CrearAlerta()
        {
            
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria", "Seleccionar");
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento", "Seleccionar");
            return View();
        }

        // POST: /Alerta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearAlerta([Bind(Include = "Id,Parametro, CategoriaId,DepartamentoId")] vmAlerta vmalerta)
        {
            if (ModelState.IsValid)
            {
                using (db= new DB_SiteProfss())
                {
                    Alerta oAlerta = new Alerta
                   {
                       Parametro = vmalerta.Parametro,
                       FechaCreacion = DateTime.Now,
                       Activa = true,
                       SolicitanteId = db.Usuarios.FirstOrDefault(u => u.Email == User.Identity.Name).Id,
                       CategoriaId = vmalerta.CategoriaId,
                       DepartamentoId = vmalerta.DepartamentoId


                   };
                    db.Alertas.Add(oAlerta);
                    db.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }

            
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "NombreCategoria", vmalerta.CategoriaId);
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "Id", "NombreDepartamento", vmalerta.DepartamentoId);
            return View(vmalerta);
        }
    }
}
