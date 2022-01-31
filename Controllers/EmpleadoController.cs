using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebAppCA.Models;
using WebAppCA.Entity;
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

        public JsonResult Tipo_concepto()
        {
            List<Concepto> concepto = new List<Concepto>();
            using (Model db = new Model())
            {
                concepto = db.Concepto.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new {data=concepto }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Obtener(int idempleado)
        {
            Empleado oPersona = new Empleado();

            using (Model db = new Model())
            {
                
                oPersona = (from p in db.Empleado.Where(x => x.id_empleado == idempleado)
                            select p).FirstOrDefault();
                db.Configuration.LazyLoadingEnabled = false;
            }

            return Json(oPersona, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar(Empleado oEmpleado)
        {
            bool respuesta = true;
            try
            {
                if (oEmpleado.id_empleado == 0)
                {
                    using (Model db = new Model())
                    {
                        db.Empleado.Add(oEmpleado);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Empleado tempempleado = (from p in db.Empleado
                                                where p.id_empleado == oEmpleado.id_empleado
                                                select p).FirstOrDefault();

                        tempempleado.Primer_nombre = oEmpleado.Primer_nombre;
                        tempempleado.Segundo_nombre = oEmpleado.Segundo_nombre;
                        tempempleado.Primer_apellido = oEmpleado.Primer_apellido;
                        tempempleado.Segundo_apellido = oEmpleado.Segundo_apellido;
                        tempempleado.Fecha_ingreso = oEmpleado.Fecha_ingreso;
                        tempempleado.id_cargo = oEmpleado.id_cargo;
                        tempempleado.Estado = oEmpleado.Estado;

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

        public JsonResult Eliminar(int idempleado)
        {
            bool respuesta = true;
            try
            {
                using (Model db = new Model())
                {
                    Empleado oEmpleado = new Empleado();
                    oEmpleado = (from p in db.Empleado.Where(x => x.id_empleado == idempleado)
                                select p).FirstOrDefault();
                    db.Empleado.Remove(oEmpleado);
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

        public JsonResult Listar_E(int idempleado)
        {
            List<mostrar_empleado_id_Result> lEmpleado = new List<mostrar_empleado_id_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.mostrar_empleado_id(idempleado).ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Listar_EA()
        {
            List<SP_mostrar_empleados_Activos_Result> lEmpleado = new List<SP_mostrar_empleados_Activos_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.SP_mostrar_empleados_Activos().ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lEmpleado }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult Obtener_empAsis(int idempleado)
        {
            List<SP_mostrar_empleado_asistencia_Result> lEmpleado = new List<SP_mostrar_empleado_asistencia_Result>();
            using (Control_de_asistenciaEntities db = new Control_de_asistenciaEntities())
            {
                lEmpleado = db.SP_mostrar_empleado_asistencia(idempleado).ToList();
                db.Configuration.LazyLoadingEnabled = false;

            }
            return Json(new {data=lEmpleado}, JsonRequestBehavior.AllowGet);
        }



    }
}