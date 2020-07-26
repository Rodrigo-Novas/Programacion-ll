using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException: Exception
    {

        public ArchivosException():this(string.Empty, null)
        {

        }

        public ArchivosException(Exception innerException) : this(string.Empty, innerException)
        {

        }

        public ArchivosException(string message):this(message, null)
        {

        }

        public ArchivosException(string message, Exception innerException):base(message, innerException)
        {

        }

    }
}
