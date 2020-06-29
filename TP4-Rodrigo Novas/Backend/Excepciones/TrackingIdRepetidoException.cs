using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Interfaces
{
   public class TrackingIdRepetidoException: Exception
    {

        /// <summary>
        /// Constructor que permite detallar la excepcion
        /// </summary>
        /// <param name="innere"></param>Detalle de la excepcion
        public TrackingIdRepetidoException(Exception innerException) : this(string.Empty, innerException)
        {

        }

        /// <summary>
        /// Constructor que permite escribir un mensaje
        /// </summary>
        /// <param name="mensaje"></param>Mensaje de la excepcion
        public TrackingIdRepetidoException(string mensaje) : this(mensaje, null)
        {

        }


        /// <summary>
        /// Constructor que permite escribir un mensaje y detallar la eexcepcion
        /// </summary>
        /// <param name="mensaje"></param>Mensaje de la excepcion
        /// <param name="inner"></param>Excepcion a detallar
        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }


    }
}
