using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Interfaces
{
    public interface IMostrar<T>
    {
        string MostrarDatos(IMostrar<T> elemento);
    }
}
