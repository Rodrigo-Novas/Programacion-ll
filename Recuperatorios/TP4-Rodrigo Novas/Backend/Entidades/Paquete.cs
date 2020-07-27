using Backend.DAO;
using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Backend
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado { ingresado, enViaje, Entregado }

        private string direccionEntrega;
        private string trackingID;
        private EEstado estado;
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;


        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.Estado = EEstado.ingresado;
        }

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }

            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }

            set
            {
                this.estado = value;
            }
        }


        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }


        public void mockCicloDeVida()
        {

            do
            {
                this.InformaEstado.Invoke(this, null);

                Thread.Sleep(5000);
                if (this.Estado == EEstado.ingresado)
                {
                    this.Estado = EEstado.enViaje;
                }
                else
                {
                    this.Estado = EEstado.Entregado;
                }
               
            }while(this.Estado != EEstado.Entregado);

           

            this.InformaEstado.Invoke(this, null);
            PaqueteDAO.Insertar(this);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            StringBuilder str = new StringBuilder(null);

            if (elemento is Paquete)
            {
                str.Append(string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega));
            }

            return str.ToString();
        }

        public override string ToString()
        {


            return string.Format("{0} ({1})", this.MostrarDatos(this), this.Estado);
            
        }


        public static bool operator ==(Paquete p1, Paquete p2)
         {
            if(p1.TrackingID == p2.trackingID)
            {
                return true;
            }
            else
            {
                return false;
            }


         }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }



    }

}

