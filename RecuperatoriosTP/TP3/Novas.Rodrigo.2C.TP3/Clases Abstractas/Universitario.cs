using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;


        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        /// </summary>
        public Universitario():base()
        {

        }

        /// <summary>
        /// CONSTRUCTOR QUE INICIALIZA LEGAJO Y LA CLASE BASE
        /// </summary>
        /// <param name="legajo"></param>LEGAJO
        /// <param name="nombre"></param>NOMBRE
        /// <param name="apellido"></param>APELLIDO
        /// <param name="dni"></param>DNI
        /// <param name="nacionalidad"></param>NACIONALIDAD
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Determina si el objeto especificado es igual al objeto actual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Universitario && this is Universitario) //si obj es universitario y si la instancia tambien es de tipo universitario 
            {

                Universitario auxUniv = (Universitario)obj; //casteo obj como universitario para poder comparar dni y legajo

                if (auxUniv.DNI == this.DNI || auxUniv.legajo == this.legajo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Muestra datos universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {

            StringBuilder str = new StringBuilder();

            str.AppendLine(base.ToString());
            str.AppendLine("El legajo es: " + this.legajo);
            return str.ToString();
        }
        /// <summary>
        /// participar en clase para sus derivadas
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase(); //abstracto

        /// <summary>
        /// veridica que el primer universitario sea igual al segundo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Distinto universitario uno y universitario dos
        /// </summary>
        /// <param name="pg1"></param>unviersiario1
        /// <param name="pg2"></param>universitario2
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);

        }

    }
}
