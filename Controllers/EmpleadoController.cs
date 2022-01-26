using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebAppCA.Models;
namespace WebAppCA.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        

        public JsonResult Listar()
        {
            List<Empleado> lEmpleado = new List<Empleado>();
            using (Model db = new Model())
            {
                lEmpleado = db.Empleado.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Tipo_cargo()
        {
            List<Cargo> cargos = new List<Cargo>();
            using (Model db = new Model())
            {
                cargos = db.Cargo.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = cargos }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Guardar(int tipo)
        {
            List<Cargo> cargos = new List<Cargo>();
            using (Model db = new Model())
            {
                cargos = db.Cargo.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = cargos }, JsonRequestBehavior.AllowGet);
        }


    }
}