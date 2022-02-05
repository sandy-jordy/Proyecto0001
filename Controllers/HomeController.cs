using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAppCA.Entity;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static usp_ObtenerUsuario_Result SesionUsuario;
        public ActionResult Index()
        {
            if (Session["Usuario"] != null)
            {
                SesionUsuario = (usp_ObtenerUsuario_Result)Session["Usuario"];
                ViewBag.NombreUsuario = SesionUsuario.Nombres + " " + SesionUsuario.Apellidos;
                ViewBag.RolUsuario = SesionUsuario.DescripcionRol;
                return View();
            }
            else
            {
                SesionUsuario = new usp_ObtenerUsuario_Result();
                return RedirectToAction("Index", "Login");
            }
            

        }

        public ActionResult CerrarSesion()
        {
            //FormsAuthentication.SignOut();
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Login");

        }
        [Authorize]
        public ActionResult Empleado()
        {
            if (Session["Usuario"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }
        public ActionResult Asistencia()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}