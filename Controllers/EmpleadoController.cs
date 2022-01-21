using SIS_CA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SIS_CA.Controllers
{
    public class EmpleadoController : Controller
    {
        private Empleado en = new Empleado();
        [HttpGet]
        // GET: Empleado
        public ActionResult Index()
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Resgistrar nuevo empleado";
            return View(en.Listar());
            
        }
        [HttpPost]
        public ActionResult Index(string Primer_nombre, string Segundo_nombre, string Primer_apellido, string Segundo_apellido, DateTime Fecha_ingreso, int id_cargo, string estado)
        {
            if (en.Insertar(Primer_nombre,Segundo_nombre,Primer_apellido,Segundo_apellido,Fecha_ingreso,id_cargo,estado))
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Empleado Registrado";
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "El empleado no se ha podido registrar";
            }
            return View(en.Listar());
        }

    }
}