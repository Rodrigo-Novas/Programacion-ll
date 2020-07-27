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
using Backend.DAO;
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

        /// <summary>
        /// Evento para agregar paquete a correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                paquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            paquete.InformaEstado += paq_InformaEstado;
            
                correo = correo + paquete;
            }
            catch(TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        /// <summary>
        /// Informa estado del paquete e invoca el metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            try
            { 
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                    if (((Paquete)sender).Estado == Paquete.EEstado.Entregado)
                    {
                        try
                        {
                            PaqueteDAO.Insertar(((Paquete)sender));
                        }
                        catch(Exception E)
                        {
                            MessageBox.Show(E.Message);
                        }
                    }
                        ActualizarEstados();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza el estado
        /// </summary>
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                try
                { 
                if (p.Estado == Paquete.EEstado.ingresado)
                {
                    lstEstadoIngresado.Items.Add(p);

                }
                if(p.Estado == Paquete.EEstado.enViaje)
                {
                    lstEstadoEnViaje.Items.Add(p);
                    lstEstadoIngresado.Items.Clear();
                }
                if(p.Estado == Paquete.EEstado.Entregado)
                {
                    lstEstadoEntregado.Items.Add(p);
                    
                    lstEstadoEnViaje.Items.Clear();
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Finaliza los hilos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
               else if (elemento is Paquete)
                {
                  rtbMostrar.Text = ((Paquete)elemento).MostrarDatos((Paquete)elemento);
                }
                

                rtbMostrar.Text.Guarda("salida.txt");
            }
        }

        /// <summary>
        /// Muestra todos los paquetes en el correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// Muestra el paquete seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolMenuStripItem_Click(object sender, EventArgs e)
        {
             
        }

        private void grpbEstadoPaquete_Enter(object sender, EventArgs e)
        {

        }

        private void mostarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
