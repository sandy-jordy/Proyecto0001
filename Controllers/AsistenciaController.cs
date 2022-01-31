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
            return View();
        }

        [HttpPost]
        public JsonResult Guardar_ASISTENCIA(Asistencia oAsistencia)
        {
            bool respuesta = true;
            try
            {
               
                    using (Model db = new Model())
                    {
                        db.Asistencia.Add(oAsistencia);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
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