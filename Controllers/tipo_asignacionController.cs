using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCA.Models;
using WebAppCA.Entity;

namespace WebAppCA.Controllers
{
    public class tipo_asignacionController : Controller
    {
        // GET: tipo_asignacion
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Tipo_asignacion()
        {
            List<Tipo_asignacion> concepto = new List<Tipo_asignacion>();
            using (Model db = new Model())
            {
                concepto = db.Tipo_asignacion.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new {data= concepto }, JsonRequestBehavior.AllowGet);
        }

    }
}