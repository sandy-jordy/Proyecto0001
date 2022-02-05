using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebAppCA.Models;
namespace WebAppCA.Controllers
{
    public class AgenciaController : Controller
    {
        // GET: Agencia
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
        
        public JsonResult Listar()
        {
            List<Agencia> lAgencia = new List<Agencia>();
            using (Model db = new Model())
            {
                lAgencia = db.Agencia.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lAgencia }, JsonRequestBehavior.AllowGet);
        }
       



        public JsonResult Obtener(int idagencia)
        {
            Agencia oAgencia = new Agencia();

            using (Model db = new Model())
            {

                oAgencia = (from p in db.Agencia.Where(x => x.id_agencia == idagencia)
                            select p).FirstOrDefault();
                db.Configuration.LazyLoadingEnabled = false;
            }

            return Json(oAgencia, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar(Agencia oAgencia)
        {
            
            bool respuesta = true;
            try
            {
                if (oAgencia.id_agencia == 0)
                {
                    using (Model db = new Model())
                    {
                        db.Agencia.Add(oAgencia);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Agencia tempagencia = (from p in db.Agencia
                                                 where p.id_agencia == oAgencia.id_agencia
                                                 select p).FirstOrDefault();

                        tempagencia.id_pais = oAgencia.id_pais;
                        tempagencia.Nombre_agencia = oAgencia.Nombre_agencia;

                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
                respuesta = false;   

            }
            
            return Json(new { resultado = respuesta}, JsonRequestBehavior.AllowGet);
            
         
        }

        public JsonResult Eliminar(int idagencia)
        {
            bool respuesta = true;
            try
            {
                using (Model db = new Model())
                {
                    Agencia oAgencia = new Agencia();
                    oAgencia = (from p in db.Agencia.Where(x => x.id_agencia== idagencia)
                                 select p).FirstOrDefault();
                    db.Agencia.Remove(oAgencia);
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