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



        public Universitario()
        {

        }


        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }


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


        protected virtual string MostrarDatos()
        {

            StringBuilder str = new StringBuilder();

            str.AppendLine(base.ToString());
            str.AppendLine("El legajo es: " + this.legajo);
            return str.ToString();
        }

        protected abstract string ParticiparEnClase(); //abstracto


        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);

        }

    }
}
