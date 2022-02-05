using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCA.Entity;
using WebAppCA.Models;

namespace WebAppCA.Controllers
{
    public class AsignacionController : Controller
    {
        public usp_ObtenerUsuario_Result SesionUsuario { get; private set; }

        // GET: Asignacion
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
        public JsonResult Obtener(int idasignacion)
        {
            Asignacion oPersona = new Asignacion();

            using (Model db = new Model())
            {

                oPersona = (from p in db.Asignacion.Where(x => x.id_asignacion == idasignacion)
                            select p).FirstOrDefault();
                db.Configuration.LazyLoadingEnabled = false;
            }

            return Json(oPersona, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Guardar(Asignacion oAsignacion)
        {
            bool respuesta = true;
            try
            {
                if (oAsignacion.id_asignacion == 0)
                {
                    using (Model db = new Model())
                    {
                        db.Asignacion.Add(oAsignacion);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Asignacion tempasignacion = (from p in db.Asignacion
                                                 where p.id_asignacion == oAsignacion.id_asignacion
                                                 select p).FirstOrDefault();

                        tempasignacion.id_ruta = oAsignacion.id_ruta;
                        tempasignacion.Fecha = oAsignacion.Fecha;
                        tempasignacion.Camion = oAsignacion.Camion;
                        tempasignacion.Cajas = oAsignacion.Cajas;
                        tempasignacion.KM = oAsignacion.KM;

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

        public JsonResult Listar_asignacion()
        {
            if (Session["Usuario"] != null)
            {
                SesionUsuario = (usp_ObtenerUsuario_Result)Session["Usuario"];
            }
            else
            {
                SesionUsuario = new usp_ObtenerUsuario_Result();
            }
            List<usp_mostrar_asignacion_Result> lEmpleado = new List<usp_mostrar_asignacion_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.usp_mostrar_asignacion(SesionUsuario.IdSucursal).ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Listar_Ruta()
        {
            if (Session["Usuario"] != null)
            {
                SesionUsuario = (usp_ObtenerUsuario_Result)Session["Usuario"];
            }
            else
            {
                SesionUsuario = new usp_ObtenerUsuario_Result();
            }
            List<usp_mostrar_ruta_Result> lEmpleado = new List<usp_mostrar_ruta_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.usp_mostrar_ruta(SesionUsuario.IdSucursal).ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Listar_Emp_asignacion()
        {
            if (Session["Usuario"] != null)
            {
                SesionUsuario = (usp_ObtenerUsuario_Result)Session["Usuario"];
            }
            else
            {
                SesionUsuario = new usp_ObtenerUsuario_Result();
            }
            List<SP_mostrar_empleados_activos_asignacion_Result> lEmpleado = new List<SP_mostrar_empleados_activos_asignacion_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.SP_mostrar_empleados_activos_asignacion(SesionUsuario.IdSucursal).ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }
    }
}