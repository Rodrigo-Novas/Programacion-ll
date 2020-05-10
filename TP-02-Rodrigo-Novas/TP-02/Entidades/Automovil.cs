using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        #region "Enumeradores"
        public enum ETipo { Monovolumen, Sedan }
        #endregion

        #region "Atributos"
        ETipo tipo;
        #endregion


        #region "Constructores"

        public Automovil (EMarca marca, string codigo, ConsoleColor color, ETipo tipo) : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }


        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string codigo, ConsoleColor color):this(marca, codigo, color, ETipo.Monovolumen)
           
        {
            
        }


        #endregion


        #region "Propiedades"

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        /// 
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodos sobrescritos"

        /// <summary>
        /// Muestra datos de automovil
        /// </summary>
        /// <returns>retorna datos de automovil formateados</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder(null);

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(string.Format("TAMAÑO : {0}",  this.Tamanio.ToString()));
            sb.AppendLine(string.Format("TIPO : {0}", this.tipo));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
