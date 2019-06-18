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
using SiteProfss_v01.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace SiteProfss_v01.Controllers
{
    public class SolicitantesController : Controller
    {
        private DB_SiteProfss db = new DB_SiteProfss();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        // GET: Solicitantes
        public ActionResult Index()
        {
            var lstUsuarios = db.Usuarios.ToList();
           
            var lstSolicitantes = new List<Solicitante>();

            foreach (Usuario u in lstUsuarios)
            {
                try
                {
                    lstSolicitantes.Add((Solicitante)u);
                }
                catch (InvalidCastException)
                {
                    continue;
                }
                
            }

            return View(lstSolicitantes);
        }

        // GET: Solicitantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitante eSolicitante = (Solicitante)db.Usuarios.Find(id);
            if (eSolicitante == null)
            {
                return HttpNotFound();
            }
            return View(eSolicitante);
        }

        // GET: Solicitantes/Create
        public ActionResult Create()
        {
            ViewBag.AnioAcademicoId = new SelectList(db.AniosAcademicos, "Id", "Descripcion", "Selecccionar");
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descripcion", "Selecccionar");
            return View();
        }

        // POST: Solicitantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id, NumeroCedula, Email,Password,ConfirmPassword,Nombres,Apellidos, SexoId, FechaNacimiento, AnioAcademicoId")] vmSolicitante eSolicitante)
        {
            if (ModelState.IsValid)
            {
                Solicitante oSlct = new Solicitante
                {
                    NumeroCedula = eSolicitante.NumeroCedula,
                    Nombres = eSolicitante.Nombres,
                    Apellidos = eSolicitante.Apellidos,
                    SexoId = eSolicitante.SexoId,
                    FechaNacimiento = eSolicitante.FechaNacimiento,
                    AnioAcademicoId = eSolicitante.AnioAcademicoId,
                    Email = eSolicitante.Email,
                    Password = eSolicitante.Password,
                };

                db.Usuarios.Add(oSlct);
                db.SaveChanges();   

                await Registrar(oSlct);

                return RedirectToAction("Index");

            }

            ViewBag.AnioAcademicoId = new SelectList(db.AniosAcademicos, "Id", "Descripcion", eSolicitante.AnioAcademicoId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descripcion", eSolicitante.SexoId);
            return View(eSolicitante);
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registrar(Solicitante pUsuario)
        {
            if (ModelState.IsValid)
            {
                var Usuario = new ApplicationUser { UserName = pUsuario.Email, Email = pUsuario.Email };
                var result = await UserManager.CreateAsync(Usuario, pUsuario.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(Usuario, isPersistent: false, rememberBrowser: false);

                    return RedirectToAction("Index", "Home");
                }
                AddErrors(result);
            }

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(pUsuario);
        }



        // GET: Solicitantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitante eSolicitante = (Solicitante)db.Usuarios.Find(id);
            if (eSolicitante == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnioAcademicoId = new SelectList(db.AniosAcademicos, "Id", "Descripcion", eSolicitante.AnioAcademicoId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descripcion", eSolicitante.SexoId);
            return View(eSolicitante);
        }

        // POST: Solicitantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Password,ConfirmPassword,Nombres,Apellidos,SexoId,AnioAcademicoId")] Solicitante eSolicitante)
        {
            if (ModelState.IsValid)
            {
                eSolicitante.Email = eSolicitante.Email;
                eSolicitante.Password = eSolicitante.Password;
                eSolicitante.Nombres = eSolicitante.Nombres;
                eSolicitante.Apellidos = eSolicitante.Apellidos;
                eSolicitante.SexoId = eSolicitante.SexoId;
                eSolicitante.AnioAcademicoId = eSolicitante.AnioAcademicoId;

                db.Entry(eSolicitante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnioAcademicoId = new SelectList(db.AniosAcademicos, "Id", "Codigo", eSolicitante.AnioAcademicoId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Codigo", eSolicitante.SexoId);
            return View(eSolicitante);
        }

        //GET: Solicitantes/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    eSolicitante eSolicitante = db.eSolicitantes.Find(id);
        //    if (eSolicitante == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(eSolicitante);
        //}

        //POST: Solicitantes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    eSolicitante eSolicitante = db.eSolicitantes.Find(id);
        //    db.eSolicitantes.Remove(eSolicitante);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
