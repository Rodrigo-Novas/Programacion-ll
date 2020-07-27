using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Clases_Instanciables;

namespace Clases_Selladas
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado };

        private Universidad.EClase clase;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {

        }


        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clase = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder(null);

            str.AppendLine(base.MostrarDatos());
            str.AppendLine("Su clase es: " + this.clase);
            str.AppendLine("Su clase es: " + this.estadoCuenta);

            return str.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


        protected override string ParticiparEnClase()
        {
            StringBuilder str = new StringBuilder(null);

            str.AppendLine("TOMA CLASE DE: " + this.clase.ToString()); //Revisar el tostring

            return str.ToString();
        }


        public static bool operator ==(Alumno a, Universidad.EClase clase)
        {
            if (a.clase == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Alumno a, Universidad.EClase clase)
        {
            return !(a == clase);
        }

    }
}
