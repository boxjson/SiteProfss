using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiteProfss_V01.Models.Clases;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using SiteProfss_v01.Models.DB;
using SiteProfss_v01.Models;

namespace SiteProfss_v01.Controllers
{
    public class EmpresasController : Controller
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

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registrar(Empresa pUsuario)
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

        // GET: Empresas
        //public ActionResult Index()
        //{
        //    return View(db.vmEmpresas.ToList());
        //}

        // GET: Empresas/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmEmpresa vmEmpresa = db.vmEmpresas.Find(id);
        //    if (vmEmpresa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vmEmpresa);
        //}

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Email,Password,ConfirmPassword,NombreEmpresa")] vmEmpresa vmEmpresa)
        {
            if (ModelState.IsValid)
            {
                Empresa oEmpresa = new Empresa
                {
                    Email = vmEmpresa.Email,
                    Password = vmEmpresa.Password,
                    NombreEmpresa = vmEmpresa.NombreEmpresa
                };

                db.Usuarios.Add(oEmpresa);
                db.SaveChanges();
                await Registrar(oEmpresa);
                return RedirectToAction("Index");
            }

            return View(vmEmpresa);
        }

        // GET: Empresas/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmEmpresa vmEmpresa = db.vmEmpresas.Find(id);
        //    if (vmEmpresa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vmEmpresa);
        //}

        // POST: Empresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Password,ConfirmPassword,NombreEmpresa")] vmEmpresa vmEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vmEmpresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vmEmpresa);
        }

        // GET: Empresas/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    vmEmpresa vmEmpresa = db.vmEmpresas.Find(id);
        //    if (vmEmpresa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vmEmpresa);
        //}

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    vmEmpresa vmEmpresa = db.vmEmpresas.Find(id);
        //    db.vmEmpresas.Remove(vmEmpresa);
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
