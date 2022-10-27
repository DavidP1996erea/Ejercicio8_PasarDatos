using Ejercicio8_Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Ejercicio8_Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



            return View();  
        }


        /// <summary>
        /// Se crea un controller llamado Saludo, que recibe como parámetro un String nombre, que se creó en el Html.ActionLink.
        /// Eviará un ViewBag con un saludo y el nombre que se haya puesto en el Html.ActionLink
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public ActionResult Saludo(String nombre)
        {
           
            String saludar = "Buenas " + nombre ;

            ViewBag.saludar = saludar;

            return View();
        }

    }
}