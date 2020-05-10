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

        #region "Enumeradores"
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda
        }
       public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

        #region "Atributos"
        //atributos
        private EMarca marca;
        private string chasis;
        private  ConsoleColor color;
        #endregion

        #region "Constructores"

        public Vehiculo (string chasis, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        #endregion

        #region "Propiedades"
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}
        #endregion

        #region "Metodos"
        
        /// <summary>
        /// Publica los datos del vehiculo formateados
        /// </summary>
        /// <returns>Retorna string completo</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder(null);

            sb.AppendLine(string.Format("CHASIS: {0}\r\n", this.chasis)); //agrego string format para poder darle formato al string que coloco
            sb.AppendLine(string.Format("MARCA : {0}\r\n", this.marca.ToString()));
            sb.AppendLine(string.Format("COLOR : {0}\r\n", this.color.ToString()));
            sb.AppendLine("---------------------");

            return sb.ToString();

        }

        #endregion


        #region "Operadores"

        /// <summary>
        /// Realiza el string de operator de forma explicita debe ser casteado por el programador
        /// </summary>
        /// <param name="p"></param>
        ///<returns>Retorna metodo mostrar</returns>
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar(); //retorno metodo mostrar
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna de bool de vehiculo igual</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna bool de vehiculo distinto</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis); //reutilizo el otro operador
        }
        #endregion


       



    }
}
