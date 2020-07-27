using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Backend.Excepciones;
namespace Backend.DAO
{
   static class PaqueteDAO
    {
        private static SqlCommand sqlCommand;
        private static SqlConnection sqlConnection;
        private static string Connectiontring = @"Data Source=.\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True";

        /// <summary>
        /// Constructor estatico que inicializa la conexion
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO.sqlConnection = new SqlConnection(PaqueteDAO.Connectiontring);
            PaqueteDAO.sqlCommand = new SqlCommand();
            PaqueteDAO.sqlCommand.Connection = PaqueteDAO.sqlConnection;
        }


        /// <summary>
        /// Metodo que agrega un paquete a la base de datos
        /// </summary>
        /// <param name="p"></param>Paquete a agregar
        /// <returns></returns>True si se agrego correctamente, false si no
        public static bool Insertar(Paquete p)
        {
            bool ok = true;

            try
            {
                sqlConnection.Open();
                PaqueteDAO.sqlCommand.CommandText = "INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, alumno) VALUES ('" + p.DireccionEntrega + "','" + p.TrackingID + "','" + "Rodrigo Novas" + "')";
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ok = false;
                throw new ExcepcionDAO("Error al tratar de insertar", e);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return ok;
        }
    }
}
