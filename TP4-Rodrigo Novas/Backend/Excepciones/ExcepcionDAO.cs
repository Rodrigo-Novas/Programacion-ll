using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Excepciones
{
   public class ExcepcionDAO: Exception
    {

        public ExcepcionDAO(string message):this(message, null)
        {

        }

        public ExcepcionDAO(Exception innerException):this(string.Empty, innerException)
        {

        }

        public ExcepcionDAO(string message, Exception innerException):base(message, innerException)
        {

        }

    }
}
