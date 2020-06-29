using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables 
{
    public sealed class Profesor : Universitario
    {

        private Queue<Universidad.EClase> clasesDelDia;
        private static Random random;



       static Profesor()
        {
            random = new Random();
        }

        private Profesor()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClase>();
            _randomClases();
        }



        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.MostrarDatos());

            return str.ToString();
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine(MostrarDatos());
            str.AppendLine(ParticiparEnClase());

            retorno = str.ToString();

            return retorno;

        }

        private void _randomClases() 
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClase)random.Next(0, 4));//agrego un random a la queue casteandolo de tipo Eclase
            }
        }

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

            return str.ToString();

        }


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
        public static bool operator !=(Profesor i, Universidad.EClase clase)
        {
            return !(i == clase);
        }

       
    }
}
