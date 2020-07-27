using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables 
{
    public sealed class Profesor : Universitario
    {

        private Queue<Universidad.EClase> clasesDelDia;
        private static Random random;


        /// <summary>
        /// Constructor que instancia random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor inicializa queue
        /// </summary>
        public Profesor():base()
        {
            this.clasesDelDia = new Queue<Universidad.EClase>();
        }

        /// <summary>
        /// Constructor instancia clases del dia y metodo randomClases
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClase>();
            _randomClases();
        }


        /// <summary>
        /// Construye datos de profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.MostrarDatos());
            str.AppendLine(this.ParticiparEnClase());
            return str.ToString();
        }

        /// <summary>
        /// To string de los datos de profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine(MostrarDatos());
            

            retorno = str.ToString();

            return retorno;

        }


        /// <summary>
        /// establece una clase al azar
        /// </summary>
        private void _randomClases() 
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClase)random.Next(0, 4));//agrego un random a la queue casteandolo de tipo Eclase
                Thread.Sleep(300);
            }
        }
        /// <summary>
        /// Determina la clase que imparte el profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder str = new StringBuilder(null);

            str.AppendLine("CLASES DEL DIA: ");
            if (this.clasesDelDia != null)
            {
                for (int i = 0; i < clasesDelDia.Count; i++)
                {
                    str.AppendLine(clasesDelDia.ElementAt(i).ToString());
                }
            }
            else
            {
                str.AppendLine("No hay clases");
            }

            return str.ToString();

        }

        /// <summary>
        /// Operador de igual igual profesor y clase
        /// </summary>
        /// <param name="i"></param>profesor
        /// <param name="clase"></param> clase
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClase clase)
        {
            bool retorno = false;

            if (i.clasesDelDia != null)
            {
                foreach (Universidad.EClase c in i.clasesDelDia)
                {
                    if (c == clase)
                    {
                        retorno = true;
                    }

                }
            }
            return retorno;

        }

        /// <summary>
        /// Negacion del operador ==
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClase clase)
        {
            return !(i == clase);
        }

       
    }
}
