using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppCA.Models;

namespace WebAppCA.Controllers
{
    public class AsignacionController : Controller
    {
        // GET: Asignacion
        public ActionResult Index()
        {
            return View();
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

                        tempasignacion.id_asignacion = oAsignacion.id_asignacion;
                        tempasignacion.id_agencia = oAsignacion.id_agencia;
                        tempasignacion.id_ruta = oAsignacion.id_ruta;
                        tempasignacion.id_pais = oAsignacion.id_pais;
                        tempasignacion.Fecha = oAsignacion.Fecha;
                        tempasignacion.Camion = oAsignacion.Camion;
                        tempasignacion.Cajas = oAsignacion.Cajas;
                        tempasignacion.KM = oAsignacion.KM;
                        tempasignacion.Agencia = oAsignacion.Agencia;
                        tempasignacion.Pais = oAsignacion.Pais;
                        tempasignacion.Ruta = oAsignacion.Ruta;
                        tempasignacion.Detalle_asignacion = oAsignacion.Detalle_asignacion;


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