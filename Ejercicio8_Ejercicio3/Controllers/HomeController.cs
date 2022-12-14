using _08_Ejercicio8;
using Ejercicio8_Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio8_Ejercicio3.Controllers
{
    public class HomeController : Controller
    {

      


        /// <summary>
        /// Se rellena los atributos del objeto persona  y se pasa mediante model a la vista
        /// </summary>
        /// <returns></returns>
        public ActionResult Editar()
        {
            clsPersona personaAModificar = new clsPersona();
            personaAModificar.Id = 1;
            personaAModificar.Nombre = "Sebastián";
            personaAModificar.Apellido = "András apellido";
            personaAModificar.FechaNaci = DateTime.Now.Date;


            return View(personaAModificar);

        }


        /// <summary>
        /// Aquí recoge los datos del formulario creado en la vista Index, y modificamos los datos del objeto persona por los recogido del formulario.
        /// Luego se redirige a controller PersonaModificada y se le pasa la persona como parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Editar(clsPersona persona)
        {
            if (!ModelState.IsValid)
            {
                return View(persona);
            }

            
           

            return View("PersonaModificada", persona);

        }



        /// <summary>
        /// En este controller se le pasa a la vista un viewBag con los datos de la persona ya modificada
        /// </summary>
        /// <param name="personaAModificar"></param>
        /// <returns></returns>
        public ActionResult PersonaModificada(clsPersona personaAModificar)
        {

           

            return View();
        }

    }
}