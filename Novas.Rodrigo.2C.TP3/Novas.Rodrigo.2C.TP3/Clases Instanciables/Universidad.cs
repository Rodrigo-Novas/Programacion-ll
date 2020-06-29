using Clases_Abstractas;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace Clases_Instanciables
{
    public class Universidad //faltan guardar y leer
    {
        public enum EClase { Programacion, Laboratorio, Legislacion, SPD };

        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;



        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

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

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
           
        }

        
        public Jornada this[int i] //indexador/ uso esto porque dice que se debe acceder a una jornada especifica a travez del indexador usando el get de la lista de jornadas puedo hacerlo
        {
            get
            {
                Jornada jor = null;
                if (i >= 0 && i < this.Jornadas.Count) //si jornada es mayor o igual a cero y es menor a la cantidad de jornadas
                {
                    jor = this.Jornadas[i]; //agrego ese indice a jornada
                }

                return jor; //devuelvo jornada con el indice indexado
            }
            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
            }
        }

        public static bool operator==(Universidad u, Alumno a)
        {
            bool retorno = false;
            foreach(Alumno auxA in u.alumnos)
            {
                if(auxA == a)
                {
                    retorno = true;
                    return retorno;
                }
               
            }

            return retorno;
        }
        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }


        public static bool operator ==(Universidad u, Profesor p)
        {
            bool retorno = false;
            foreach (Profesor auxA in u.profesores)
            {
                if (auxA == p)
                {
                    retorno = true;
                    return retorno;
                }

            }

            return retorno;
        }

        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }


        public static Universidad operator +(Universidad u, Profesor p)
        {
            if(u!=p)
            {
                u.profesores.Add(p);
            }
            return u;
        }


        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException("Ya existe alumno");
            }

            return u;
        }
        /// <summary>
        /// Agrega una nueva jornada de clase. Asigna un profesor a la misma 
        /// y a los alumnos que tomen esa clase.
        /// </summary>
        /// <param name="g"></param>Universidad a la cual se le agregara una clase
        /// <param name="clase"></param>Clase a ser agregada
        /// <returns></returns>La universidad con la nueva jornada de clase cargada
        public static Universidad operator +(Universidad u, EClase clase)
        {
            Jornada jornadaAux = new Jornada(clase, u==clase);

            foreach (Alumno a in u.Alumnos)
            {
                if (a == clase)
                {
                    jornadaAux.Alumnos.Add(a);
                }
            }

            u.Jornadas.Add(jornadaAux);

            return u;

        }

        public static Profesor operator ==(Universidad u, EClase clase)
        {

            
            foreach(Profesor p in u.Instructores)
            {
               if (p==clase)
                {
                    return p;
                }
               
            }

            
            throw new SinProfesorException("No hay profesor");

        }

        public static Profesor operator !=(Universidad u, EClase clase)
        {

           
            foreach (Profesor p in u.Instructores)
            {
                if (p != clase)
                {
                    return p;
                }
               
            }


            throw new SinProfesorException("No hay profesor");

        }


        /// <summary>
        /// Metodo que devuelve los datos de la universidad
        /// </summary>
        /// <param name="uni"></param>Universidad de la que se quieren mostrar los datos
        /// <returns></returns>Devuelve una cadena de caracteres con los datos de la universidad
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            foreach (Jornada j in uni.Jornadas)
            {
                str.AppendLine(j.ToString());
                str.AppendLine("<------------------------------------------------>");
            }
            
            retorno = str.ToString();

            return retorno;
        }


        /// <summary>
        /// Metodo sobreescrito
        /// </summary>
        /// <returns></returns>Devuelve todos los datos de la universidad
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Metodo para guardar los datos de la universidad en un archivo
        /// </summary>
        /// <param name="uni"></param>Universidad a ser guardada
        /// <returns></returns>True si se pudo guardar, false si no
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            bool ok = true;

            if (xml.Guardar("Universidad.xml", uni) == false)
            {
                ok = false;
                SerializationException e = new SerializationException();
                throw new ArchivosException(e);
            }

            return ok;
        }


        /// <summary>
        /// Metodo para leer los datos de una universidad guardada en un archivo
        /// </summary>
        /// <param name="uni"></param>Universidad a la que se le van a pasar todos los datos
        /// <returns></returns>Universidad con todos los datos
        public static Universidad Leer(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            if (xml.Leer("Universidad.xml", out uni) == false)
            {
                SerializationException e = new SerializationException();
                throw new ArchivosException(e);
            }

            return uni;
        }


    }
}
