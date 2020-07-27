using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Backend.Archivos
{
   static public class GuardaString
    {
       public static bool Guarda(this string texto, string archivo)
        {
            bool corrio = true;
            StreamWriter str = null; //lo declaro aca porque sino el finally no puede tomarlo
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
                str = new StreamWriter(filePath, true);
                str.Write(string.Format("{0} /n", texto));
            }
            catch (Exception)
            {
                corrio = false;
            }
            finally
            {
                if(str != null) //si el objeto str no apunta a null entonces cerrar instancia
                { 
                str.Close();
                }
            }

            return corrio;
        }
    }
}
