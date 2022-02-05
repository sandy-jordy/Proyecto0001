using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCA.Entity;
using WebAppCA.Models;

namespace WebAppCA.Controllers
{
    public class detalle_asignacionController : Controller
    {
        // GET: detalle_asignacion
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Guardar(Detalle_asignacion oDesignacion)
        {
            bool respuesta = true;
            try
            {
                if (oDesignacion.id_empleado !=0)
                {
                    using (Model db = new Model())
                    {
                        db.Detalle_asignacion.Add(oDesignacion);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    
                }
            }
            catch
            {
                respuesta = false;

            }

            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);

        }


        public JsonResult Listar_detalle_asignacion(int idasignacion)
        {
            List<SP_mostrar_detalle_asignacion_Result> lEmpleado = new List<SP_mostrar_detalle_asignacion_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.SP_mostrar_detalle_asignacion(idasignacion).ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Buscar_detalle_asignacion(int idDasignacion)
        {

            Detalle_asignacion oPersona = new Detalle_asignacion();

            using (Model db = new Model())
            {

                oPersona = (from p in db.Detalle_asignacion.Where(x => x.id_detalle_asignacion == idDasignacion)
                            select p).FirstOrDefault();
                db.Configuration.LazyLoadingEnabled = false;
            }

            return Json(oPersona, JsonRequestBehavior.AllowGet);
            
        }
        public JsonResult Eliminar_detalle_asig(int idDasignacion)
        {
            bool respuesta = true;
            try
            {
                using (Model db = new Model())
                {
                    Detalle_asignacion oDasig = new Detalle_asignacion();
                    oDasig = (from p in db.Detalle_asignacion.Where(x => x.id_detalle_asignacion == idDasignacion)
                                 select p).FirstOrDefault();
                    db.Detalle_asignacion.Remove(oDasig);
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