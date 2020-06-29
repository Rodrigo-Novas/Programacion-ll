using Novas.Rodrigo._2C.TP3.Clases_selladas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novas.Rodrigo._2C.TP3.Clases
{
    class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClase clase;
        private Profesor instructor;

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClase clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        /// <summary>
        /// Propiedad de lectura/escritura de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }

        }


        /// <summary>
        /// Propiedad de lectura/escritura de la clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }


        /// <summary>
        /// Propiedad de lectura/escritura del profesor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }

            set
            {
                this.instructor = value;
            }
        }
    

        public static bool operator ==(Jornada j, Alumno a)
        {
            if(j.alumnos != null)
            { 
                foreach(Alumno auxA in j.alumnos)
                {
                    if(auxA == a)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
          
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j!=a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

    }
}
