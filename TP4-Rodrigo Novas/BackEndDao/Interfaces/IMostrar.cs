using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Interfaces
{
    
    public interface IMostrar<T>
    {   
        /// <summary>
        /// Metodo que van a implementar los metodos que utilicen esta interfaz
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        string MostrarDatos(IMostrar<T> elemento);
    }
}
