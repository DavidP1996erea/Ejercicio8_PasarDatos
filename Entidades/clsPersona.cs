using System;

namespace _08_Ejercicio8
{
    public class clsPersona {



        #region Atributos
        private int id; 
        private String nombre;
        private String apellido;
        #endregion



        #region Constructor por defecto
        public clsPersona()
        {

        }
        #endregion



        #region Constructor
        public clsPersona(String nombre, int id,String apellido)
        {

            this.nombre = nombre;
            this.id = id;   
            this.apellido = apellido;
        }
        #endregion



        #region Propiedades

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
        #endregion



    }
}