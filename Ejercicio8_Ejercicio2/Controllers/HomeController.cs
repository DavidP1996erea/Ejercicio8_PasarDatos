using Ejercicio8_Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio8_Ejercicio2.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Index principal que contendrá el input y el botón
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {


            return View();
        }


        /// <summary>
        /// Este index HttPost recoge el input del formulario creado en Index, que se llamará como el input.
        /// También se meterá en un TemData para poder usarlo en Saludo. En el return se llama a la vista Saludo.
        /// </summary>
        /// <param name="nombreInput"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(String nombreInput)
        {

            ViewBag.nombre="Buenas "+ nombreInput;

            return View("Saludo");

        }

        /// <summary>
        /// Devolverá un ViewBag con los datos necesarios, que recibirá la view Saludo
        /// </summary>
        /// <returns></returns>
        public ActionResult Saludo()
        {
                      

            return View();
        }



    }
}