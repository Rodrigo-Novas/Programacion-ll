using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Backend
{
    public class Correo: IMostrar<List<Paquete>>
    {

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;



        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
               return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public static Correo operator+(Correo c, Paquete p)
        {
            
            foreach(Paquete pAux in c.Paquetes)
            {
                if(p == pAux)
                {
                    throw new TrackingIdRepetidoException("Error: El paquete ya se encuentra en la lista");
                }
               
            }

            c.Paquetes.Add(p);
            Thread hiloPaquete = new Thread(p.mockCicloDeVida);
            c.mockPaquetes.Add(hiloPaquete);
            hiloPaquete.Start();
            return c;

        }


        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder str = new StringBuilder(null);
            if (elemento is Correo)
            {
                foreach (Paquete p in ((Correo)elemento).Paquetes)
                {
                   
                    str.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
                }
            }
            return str.ToString();
        }
       public void FinEntregas()
        {
           
           foreach(Thread t in this.mockPaquetes) //Recorro lista
            {
                if(t !=null && t.IsAlive) //chequeo si no esta apuntando a null y si esta vivo y lo aborto
                {
                    t.Abort();
                }
            }

           
        }


    }
}
