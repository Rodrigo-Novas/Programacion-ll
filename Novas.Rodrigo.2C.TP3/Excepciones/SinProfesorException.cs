using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class SinProfesorException:Exception
    {


        public SinProfesorException() : this(string.Empty)
        {

        }
        public SinProfesorException(string message) : this(message, null)
        {

        }

        public SinProfesorException(Exception innerException) : this(string.Empty, innerException)
        {

        }

        public SinProfesorException(string message, Exception innerException):base(message, innerException)
        {

        }

    }
}
