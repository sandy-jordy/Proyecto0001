using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppCA.Models;
using WebAppCA.Entity;
using System.Web.Security;

namespace WebAppCA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string correo, string clave)
        {

            usp_ObtenerUsuario_Result ousuario = new usp_ObtenerUsuario_Result();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                FormsAuthentication.SetAuthCookie(ousuario.Correo, false);
                ousuario = db.usp_ObtenerUsuario(correo, clave).FirstOrDefault();

                db.Configuration.LazyLoadingEnabled = false;
            }
            

            if (ousuario == null)
            {
                ViewBag.Error = "Usuario o contraseña no correcta";
                return View();
            }

            Session["Usuario"] = ousuario;

            return RedirectToAction("Index", "Home");
        }
    }
}