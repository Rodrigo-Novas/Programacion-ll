﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo //hereda de vehiculo
    {

        #region "Constructores"
        public Camioneta(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }
        #endregion


        #region "Propiedades"
        /// <summary>
        /// Retorna el tamaño de camioneta (Las camionetas son grandes)
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodos sobrescritos"
        /// <summary>
        /// Muestra los datos de camioneta
        /// </summary>
        /// <returns>retorna los datos formateados</returns>
        public override sealed string Mostrar() //el override no puede ser private solo puede ser protected o public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());  //como traer base si no tiene metodo motrar
            sb.AppendLine(string.Format("TAMAÑO: {0}", this.Tamanio.ToString()));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion 
    }
}
