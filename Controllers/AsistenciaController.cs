using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCA.Models;
namespace WebAppCA.Controllers

{
    public class AsistenciaController : Controller
    {
        // GET: Asistencia
        public ActionResult Index()
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

        [HttpPost]
        public JsonResult Guardar_ASISTENCIA(Asistencia oAsistencia)
        {
            bool respuesta = true;
            try
            {
                if (oAsistencia.id_asistencia == 0)
                {
                    using (Model db = new Model())
                    {
                        db.Asistencia.Add(oAsistencia);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Asistencia tempasistencia = (from p in db.Asistencia
                                                     where p.id_asistencia == oAsistencia.id_asistencia
                                                     select p).FirstOrDefault();

                        tempasistencia.id_empleado = oAsistencia.id_empleado;
                        tempasistencia.id_concepto = oAsistencia.id_concepto;
                        tempasistencia.Fecha_asistencia = oAsistencia.Fecha_asistencia;

                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                }

            catch
            {
                respuesta = false;

            }
            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);


        } 
        
    }
}