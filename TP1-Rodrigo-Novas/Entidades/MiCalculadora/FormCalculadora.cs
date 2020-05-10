using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperando.Items.AddRange(new string[] { "/", "*", "+", "-" }); //añado items al combo box
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            lblResultado.Text = String.Empty;
            cmbOperando.Text = string.Empty;

        }


        private static double Operar (string numero1, string numero2, string operando)
            {
            Numero numeroAux = new Numero(numero1);
            Numero numeroAux2 = new Numero(numero2);
           
            return Calculadora.Operar(numeroAux, numeroAux2, operando);
           
            }

        private void btnOperar_Click(object sender, EventArgs e)
        {
        lblResultado.Text= Operar(txtNumero1.Text, txtNumero2.Text, cmbOperando.Text).ToString(); //paso el resultado al label
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
         
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
    }
}
