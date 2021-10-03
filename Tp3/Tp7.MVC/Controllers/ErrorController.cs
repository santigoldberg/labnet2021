using System.Web.Mvc;
using Tp7.MVC.Models;

namespace Tp7.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string mensajeError)
        {
            ErrorView error = new ErrorView { mensajeError = mensajeError };
            return View(error);
        }

        
    }
}