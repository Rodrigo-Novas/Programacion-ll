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
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca">marca del vehjiculo</param>
        /// <param name="codigo">codigo unico del vehiculo</param>
        /// <param name="color">color del vehiculo</param>
        public enum ETipo
        { 
            Monovolumen, 
            Sedan 
        }
        

       //atributos
        ETipo tipo;
       

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>Marca del auto
        /// <param name="codigo"></param>codigo del auto
        /// <param name="color"></param>color de auto
        /// <param name="tipo"></param>tipo de auto
        public Automovil (EMarca marca, string codigo, ConsoleColor color, ETipo tipo) 
            : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }


        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>marca del auto
        /// <param name="chasis"></param>chasis del auto
        /// <param name="color"></param>color del auto
        public Automovil(EMarca marca, string codigo, ConsoleColor color)
            :this(marca, codigo, color, ETipo.Monovolumen)          
        {           
        }





       

        /// <summary>
        ///ReadOnly Los automoviles son medianos
        /// </summary>
        /// 
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
       

      

        /// <summary>
        /// Muestra datos de automovil
        /// </summary>
        /// <returns>retorna datos de automovil formateados</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder(null);

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(string.Format("TAMAÑO : {0}",  this.Tamanio));
            sb.AppendLine(string.Format("TIPO : {0}", this.tipo));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
       
    }
}
