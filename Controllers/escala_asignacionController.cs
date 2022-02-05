using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppCA.Entity;
using WebAppCA.Models;

namespace WebAppCA.Controllers
{
    public class escala_asignacionController : Controller
    {
        // GET: escala_asignacion
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Tipo_escala_asignacion()
        {
            List<Escala_asignacion> concepto = new List<Escala_asignacion>();
            using (Model db = new Model())
            {
                concepto = db.Escala_asignacion.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = concepto }, JsonRequestBehavior.AllowGet);
        }
    }
}