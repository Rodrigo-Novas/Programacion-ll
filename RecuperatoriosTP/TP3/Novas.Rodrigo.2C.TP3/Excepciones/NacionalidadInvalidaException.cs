using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public NacionalidadInvalidaException():this(string.Empty, null)
        {

        }

        /// <summary>
        /// Constructor que permite escribir una excepcion
        /// </summary>
        /// <param name="innerExceptione"></param>Excepcion

        public NacionalidadInvalidaException( Exception innerException) : this(string.Empty, innerException)
        {

        }


        /// <summary>
        /// Constructor que permite escribir un mensaje
        /// </summary>
        /// <param name="mensaje"></param>Mensaje de la excepcion

        public NacionalidadInvalidaException(string message):this(message, null)
        {

        }
        /// <summary>
        /// Constructor que permite escribir un mensaje y una excepcion
        /// </summary>
        /// <param name="mensaje" name="innerException"></param>Mensaje de la excepcion y excepcion
        public NacionalidadInvalidaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
