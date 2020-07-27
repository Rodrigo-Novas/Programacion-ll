using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        /// <summary>
        /// Tipos de estado de cuenta
        /// </summary>
        public enum EEstadoCuenta
        {
          AlDia, Deudor, Becado 
        };

        private Universidad.EClase clase;
        private EEstadoCuenta estadoCuenta;


        /// <summary>
        /// ctor por defecto
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="id"></param>id del alumno
        /// <param name="nombre"></param>nombre del alumno
        /// <param name="apellido"></param>apellido del alumno
        /// <param name="dni"></param>dni del alumno
        /// <param name="nacionalidad"></param>nacionalidad del alumno
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma) 
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clase = claseQueToma;
        }
        /// <summary>
        /// ctor de instancia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma, EEstadoCuenta estadoCuenta) 
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        /// <summary>
        /// Muestra datos de alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            

            
            return string.Format("{0}\n\nESTADO DE CUENTA {1}\nTOMA CLASES DE {2}", base.MostrarDatos(), this.estadoCuenta == EEstadoCuenta.AlDia ? "Cuota al día" : this.estadoCuenta.ToString(), this.clase);
            
        }
        /// <summary>
        /// override de to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Determina la clase que toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder str = new StringBuilder(null);

            str.AppendLine(String.Format("TOMA CLASE DE: {0} ", this.clase)); //Revisar el tostring

            return str.ToString();
        }

        /// <summary>
        /// Sobrecarga de operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClase clase)
        {
            return !(a == clase);
        }

    }
}
