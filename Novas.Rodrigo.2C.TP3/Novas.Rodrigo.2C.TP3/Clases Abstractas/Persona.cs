using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }; //Arg=0 , Ext=1


        
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
       


        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {

            this.Nacionalidad = nacionalidad;

            this.Nombre = nombre;

            this.Apellido = apellido;

        }



        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, dni.ToString(), nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }




        
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }



        public string Apellido
        {

            get
            {
                return this.apellido;
            }


            set
            {
                this.apellido = ValidarNombreApellido(value);
            }

        }
        public int DNI
        {
            get
            {
                return this.dni;
            }


            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value); //validar dni int
            }

        }
        public ENacionalidad Nacionalidad
        {
            get

            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value); //validar dni string
            }
        }
        


        private int ValidarDni(ENacionalidad nacionalidad, int dato) //Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999
        {


            if (nacionalidad == ENacionalidad.Argentino || nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato >= 1 && dato <= 89999999 && nacionalidad == ENacionalidad.Argentino)
                {
                    return dato;
                }
                else if (dato >= 90000000 && dato <= 99999999 && nacionalidad == ENacionalidad.Extranjero)
                {
                    return dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no coincide con el numero de documento") ;
                }

            }
            else
            {
                throw new NacionalidadInvalidaException("Nacionalidad Incorrecta");
            }

        }


        private int ValidarDni(ENacionalidad nacionalidad, string dato)

        {
            int auxDni;

            if (Regex.IsMatch(dato, @"^[0-9]+[0-9\.]*$")) //^ es el comienzo de la cadena debe ir de cero a 9  y el final debe ir de ceroa  9 tambien
            {

                dato = dato.Replace(".", "");
                if (int.TryParse(dato, out auxDni))
                {
                    return ValidarDni(nacionalidad, auxDni);
                }
                else
                {
                    throw new FormatException("No se puede convertir texto a entero");
                }

            }
            else
            {
                throw new DniInvalidoException("El dni tiene caracteres que no corresponden");

            }


        }


        private string ValidarNombreApellido(string dato)
        {

            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))//valida solo letras
            {

                return dato;

            }

            else
            {
                return string.Empty;
            }

        }

        /// <summary>
        /// Coloca los datos de Persona
        /// </summary>
        /// <returns>Devuelve los datos de persona en string</returns>
        public override string ToString()
        {

            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Nombre completo: " + this.Nombre + ", " + this.Apellido);
            str.AppendLine("Nacionalidad: " + this.Nacionalidad);
            str.AppendLine("Dni: " + this.DNI);

            retorno = str.ToString();

            return retorno;
        }


    }
}
