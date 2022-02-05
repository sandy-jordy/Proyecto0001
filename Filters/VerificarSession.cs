
using System.Web;
using System.Web.Mvc;
using WebAppCA.Entity;
using WebAppCA.Controllers;

namespace VentasWeb.Filters
{
    public class VerificarSession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            usp_ObtenerUsuario_Result oUsuario = (usp_ObtenerUsuario_Result)HttpContext.Current.Session["Usuario"];

            if (oUsuario == null)
            {

                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }
            }
            else
            {

                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }


            base.OnActionExecuting(filterContext);
        }
    }
}