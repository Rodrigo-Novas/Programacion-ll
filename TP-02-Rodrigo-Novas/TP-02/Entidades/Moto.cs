using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        #region "Constructores"
        public Moto(EMarca marca, string codigo, ConsoleColor color): base(codigo, marca, color)
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos sobreescritos"
        /// <summary>
        /// Muestra datos de moto
        /// </summary>
        /// <returns>retorna datos moto formateado</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio.ToString()));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
