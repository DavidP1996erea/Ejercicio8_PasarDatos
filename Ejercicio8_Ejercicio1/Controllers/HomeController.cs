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



        public ActionResult Saludo(String nombre)
        {
           
            String saludar = "Buenas " + nombre ;

            ViewBag.saludar = saludar;

            return View();
        }

    }
}