using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        

        public AlumnoRepetidoException():this(String.Empty)
        {

        }

        public AlumnoRepetidoException(string message):this(message, null)
        {

        }

        public AlumnoRepetidoException(string message, Exception innerException):base(message,innerException)
        {

        }

    }
}
