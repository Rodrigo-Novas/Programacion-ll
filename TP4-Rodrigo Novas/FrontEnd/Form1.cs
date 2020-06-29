using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Backend.Archivos;
using Backend.Interfaces;
namespace FrontEnd
{
    public partial class frmPpal : Form
    {
        Correo correo = null;
        Paquete paquete = null;
        public frmPpal()
        {
            InitializeComponent();
            correo = new Correo(); //inicializa la lista
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            paquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            paquete.InformaEstado += paq_InformaEstado;
            try
            {
                correo = correo + paquete;
            }
            catch(TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                if (p.Estado == Paquete.EEstado.ingresado)
                {
                    lstEstadoIngresado.Items.Add(p.ToString());

                }
                if(p.Estado == Paquete.EEstado.enViaje)
                {
                    lstEstadoEnViaje.Items.Add(p.ToString());
                    lstEstadoIngresado.Items.Clear();
                }
                if(p.Estado == Paquete.EEstado.Entregado)
                {
                    lstEstadoEntregado.Items.Add(p.ToString());
                    
                    lstEstadoEnViaje.Items.Clear();
                }
            }
        }

        private void frmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
        /// <summary>
        /// Muestra los datos de los paquetes en el rich text box
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>Los paquetes a mostrar
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            

            if (elemento != null)
            {
             
               if (elemento is Correo)
                {
                    rtbMostrar.Text = ((Correo)elemento).MostrarDatos((Correo)elemento);

                }
                if (elemento is Paquete)
                {
                  rtbMostrar.Text = ((Paquete)elemento).MostrarDatos((Paquete)elemento);
                }
                

                rtbMostrar.Text.Guarda("salida.txt");
            }
        }


        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolMenuStripItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem); //no funciona esta parte
        }

        private void grpbEstadoPaquete_Enter(object sender, EventArgs e)
        {

        }
    }
}
