using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using System.Runtime;
using System.IO;
using Excepciones;
using Archivos;
namespace Clases_Instanciables
{
   public class Jornada //faltan los metodos para manipular archivos
    {
        private List<Alumno> alumnos;
        private Universidad.EClase clase;
        private Profesor instructor;
        /// <summary>
        /// Constructor por defecto instancia la lista
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Consrtuctor de instancia
        /// </summary>
        /// <param name="clase"></param>clase
        /// <param name="instructor"></param>profesor de la clase
        public Jornada(Universidad.EClase clase, Profesor instructor) : this()
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
        public Universidad.EClase Clase
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

        /// <summary>
        /// operador == para jornada y alumno. el alumno participa de la clase 
        /// </summary>
        /// <param name="j"></param>jornado
        /// <param name="a"></param>alumno
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            if (j.alumnos != null)
            {
                foreach (Alumno auxA in j.alumnos)
                {
                    if (auxA == a)
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
        /// <summary>
        /// Operador para verificar si es distinto
        /// </summary>
        /// <param name="j"></param>jornada 
        /// <param name="a"></param>alumno
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Operador para agregar alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        /// <summary>
        /// To string de alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

           
            str.AppendLine("Clase de: " + this.Clase + " Por: " + Instructor.ToString());

            if (this.Alumnos.Count != 0)
            {

                str.AppendLine("Alumnos: ");
                foreach (Alumno a in this.Alumnos)
                {
                    str.AppendLine(a.ToString());
                }
            }
            else
            {
                str.AppendLine("no hay alumnos");
            }
            retorno = str.ToString();

            return retorno;
        }


        /// <summary>
        /// Metodo para guardar los datos de la jornada en un archivo
        /// </summary>
        /// <param name="j"></param>Jornada a ser guardada
        /// <returns></returns>True si se pudo guardar, false si no
        public static bool Guardar(Jornada j)
        {
            Texto tex = new Texto();
            bool ok = true;

            if (tex.Guardar("Jornada.txt", j.ToString()) == false)
            {
                ok = false;
                IOException e = new IOException();
                throw new ArchivosException(e);
            }

            return ok;
        }


        /// <summary>
        /// Metodo para leer los datos de una jornada guardada en un archivo
        /// </summary>
        /// <returns></returns>Devuelve los datos de la jornada guardada
        public static string Leer()
        {
            Texto tex = new Texto();
            string retorno = "";

            if (tex.Leer("Jornada.txt", out retorno) == false)
            {
                IOException e = new IOException();
                throw new ArchivosException(e);
            }

            return retorno;
        }


    }
}
