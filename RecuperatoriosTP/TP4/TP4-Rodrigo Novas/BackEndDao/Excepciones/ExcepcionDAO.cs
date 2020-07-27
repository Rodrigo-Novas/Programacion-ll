using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Excepciones
{
   public class ExcepcionDAO: Exception
    {
        /// <summary>
        /// Constructor con mensaje
        /// </summary>
        /// <param name="message"></param>
        public ExcepcionDAO(string message):this(message, null)
        {

        }
        /// <summary>
        /// Constructor con mensaje a inner exception
        /// </summary>
        /// <param name="innerException"></param>
        public ExcepcionDAO(Exception innerException):this(string.Empty, innerException)
        {

        }
        /// <summary>
        /// Constructor con inner y con mensaje
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ExcepcionDAO(string message, Exception innerException):base(message, innerException)
        {

        }

    }
}
