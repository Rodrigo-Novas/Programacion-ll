using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No se puede instanciar vehiculo.
    /// </summary>


    public  abstract class Vehiculo //la hago abstracta para que pueda heredar y para que no pueda ser instanciada
    {
        /// <summary>
        /// Enumeradores
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda
        }
       public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }

        

        
        //atributos
        private EMarca marca;
        private string chasis;
        private  ConsoleColor color;



        /// <summary>
        /// Constructor de intancia. inicializa los atributos de la instancia
        /// </summary>
        /// <param name="marca">marca del vehjiculo</param>
        /// <param name="chasis">codigo unico del vehiculo</param>
        /// <param name="color">color del vehiculo</param>
        public Vehiculo (string chasis, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

       

        
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}
        

        
        
        /// <summary>
        /// Publica los datos del vehiculo formateados
        /// </summary>
        /// <returns>Retorna string completo</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder(null);

            sb.AppendLine(string.Format("CHASIS: {0}\r\n", this.chasis)); //agrego string format para poder darle formato al string que coloco
            sb.AppendLine(string.Format("MARCA : {0}\r\n", this.marca));
            sb.AppendLine(string.Format("COLOR : {0}\r\n", this.color));
            sb.AppendLine("---------------------");

            return sb.ToString();

        }

       


        

        /// <summary>
        /// Realiza el string de operator de forma explicita debe ser casteado por el programador
        /// </summary>
        /// <param name="p"></param>un vehiculo
        ///<returns>Retorna metodo mostrar</returns>
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar(); //retorno metodo mostrar
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>vehiulo que se desea comparar
        /// <param name="v2"></param>vehiulo que se desea comparar
        /// <returns>retorna de bool de vehiculo igual</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>Vehiculo que se desea comparar
        /// <param name="v2"></param>Vehiculo que se desea comparar
        /// <returns>retorna bool de vehiculo distinto</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2); //reutilizo el otro operador
        }
       


       



    }
}
