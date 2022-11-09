using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace _08_Ejercicio8
{
    public class clsPersona {



        #region Atributos
        private int id;
        private String nombre;
        private String apellido;
        private DateTime fechaNaci;
        #endregion



        #region Constructor por defecto
        public clsPersona()
        {

        }
        #endregion



        #region Constructor
        public clsPersona(String nombre, int id,String apellido, DateTime fechaNaci)
        {

            this.nombre = nombre;
            this.id = id;   
            this.apellido = apellido;
            this.fechaNaci = fechaNaci;
        }
        #endregion



        #region Propiedades

      
        [HiddenInput(DisplayValue = false)]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        [Required(ErrorMessage = "Campo obligatorio")]
        public String Nombre
        {

            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(40, ErrorMessage ="No debe tener más de 40 carácteres")]
        public String Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNaci
        {
            get { return fechaNaci; }
            set { fechaNaci = value; }
        }
        #endregion



    }
}