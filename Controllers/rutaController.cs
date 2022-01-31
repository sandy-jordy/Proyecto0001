using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCA.Models;

namespace WebAppCA.Controllers
{
    public class rutaController : Controller
    {
        // GET: ruta
        public ActionResult Index()
        {
            return View();
        }



        public JsonResult Listar()
        {
            List<Ruta> lRuta = new List<Ruta>();
            using (Model db = new Model())
            {
                lRuta = db.Ruta.ToList();
                db.Configuration.LazyLoadingEnabled = false;
            }
            return Json(new { data = lRuta }, JsonRequestBehavior.AllowGet);
        }




        public JsonResult Obtener(int idruta)
        {
            Ruta oRuta = new Ruta();

            using (Model db = new Model())
            {

                oRuta = (from p in db.Ruta.Where(x => x.id_ruta == idruta)
                            select p).FirstOrDefault();
                db.Configuration.LazyLoadingEnabled = false;
            }

            return Json(oRuta, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar(Ruta oRuta)
        {

            bool respuesta = true;
            try
            {
                if (oRuta.id_ruta== 0)
                {
                    using (Model db = new Model())
                    {
                        db.Ruta.Add(oRuta);
                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Ruta tempRuta = (from p in db.Ruta
                                               where p.id_ruta == oRuta.id_ruta
                                               select p).FirstOrDefault();


                        tempRuta.Ruta1 = oRuta.Ruta1;


                        db.SaveChanges();
                        db.Configuration.LazyLoadingEnabled = false;
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                respuesta = false;

            }

            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);


        }

        public JsonResult Eliminar(int idruta)
        {
            bool respuesta = true;
            try
            {
                using (Model db = new Model())
                {
                    Ruta oRuta= new Ruta();
                    oRuta = (from p in db.Ruta.Where(x => x.id_ruta == idruta)
                                select p).FirstOrDefault();
                    db.Ruta.Remove(oRuta);
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