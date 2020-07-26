namespace FrontEnd
{
    partial class frmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.grpbEstadoPaquete = new System.Windows.Forms.GroupBox();
            this.lblTrackinID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.grpbPaquete = new System.Windows.Forms.GroupBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbEstadoPaquete.SuspendLayout();
            this.grpbPaquete.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(21, 35);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(169, 134);
            this.lstEstadoIngresado.TabIndex = 4;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(238, 35);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(169, 134);
            this.lstEstadoEnViaje.TabIndex = 5;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(456, 35);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(169, 134);
            this.lstEstadoEntregado.TabIndex = 6;
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(21, 16);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "En Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entregado";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.HideSelection = false;
            this.rtbMostrar.Location = new System.Drawing.Point(40, 321);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(383, 108);
            this.rtbMostrar.TabIndex = 7;
            this.rtbMostrar.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(131, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(131, 73);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(98, 30);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // grpbEstadoPaquete
            // 
            this.grpbEstadoPaquete.Controls.Add(this.label2);
            this.grpbEstadoPaquete.Controls.Add(this.label1);
            this.grpbEstadoPaquete.Controls.Add(this.lblEstadoIngresado);
            this.grpbEstadoPaquete.Controls.Add(this.lstEstadoEntregado);
            this.grpbEstadoPaquete.Controls.Add(this.lstEstadoEnViaje);
            this.grpbEstadoPaquete.Controls.Add(this.lstEstadoIngresado);
            this.grpbEstadoPaquete.Location = new System.Drawing.Point(12, 37);
            this.grpbEstadoPaquete.Name = "grpbEstadoPaquete";
            this.grpbEstadoPaquete.Size = new System.Drawing.Size(651, 215);
            this.grpbEstadoPaquete.TabIndex = 8;
            this.grpbEstadoPaquete.TabStop = false;
            this.grpbEstadoPaquete.Text = "Estado Paquete";
            this.grpbEstadoPaquete.Enter += new System.EventHandler(this.grpbEstadoPaquete_Enter);
            // 
            // lblTrackinID
            // 
            this.lblTrackinID.AutoSize = true;
            this.lblTrackinID.Location = new System.Drawing.Point(6, 16);
            this.lblTrackinID.Name = "lblTrackinID";
            this.lblTrackinID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackinID.TabIndex = 9;
            this.lblTrackinID.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 78);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(9, 39);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(100, 20);
            this.mtxtTrackingID.TabIndex = 0;
            // 
            // grpbPaquete
            // 
            this.grpbPaquete.Controls.Add(this.btnAgregar);
            this.grpbPaquete.Controls.Add(this.btnMostrarTodos);
            this.grpbPaquete.Controls.Add(this.mtxtTrackingID);
            this.grpbPaquete.Controls.Add(this.lblTrackinID);
            this.grpbPaquete.Controls.Add(this.txtDireccion);
            this.grpbPaquete.Controls.Add(this.lblDireccion);
            this.grpbPaquete.Location = new System.Drawing.Point(444, 321);
            this.grpbPaquete.Name = "grpbPaquete";
            this.grpbPaquete.Size = new System.Drawing.Size(235, 123);
            this.grpbPaquete.TabIndex = 9;
            this.grpbPaquete.TabStop = false;
            this.grpbPaquete.Text = "Paquete";
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(116, 26);
            // 
            // mostarToolStripMenuItem
            // 
            this.mostarToolStripMenuItem.Name = "mostarToolStripMenuItem";
            this.mostarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostarToolStripMenuItem.Text = "Mostrar";
            this.mostarToolStripMenuItem.Click += new System.EventHandler(this.mostarToolStripMenuItem_Click);
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 445);
            this.Controls.Add(this.grpbPaquete);
            this.Controls.Add(this.grpbEstadoPaquete);
            this.Controls.Add(this.rtbMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Rodrigo.Novas.2°C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPpal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbEstadoPaquete.ResumeLayout(false);
            this.grpbEstadoPaquete.PerformLayout();
            this.grpbPaquete.ResumeLayout(false);
            this.grpbPaquete.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.GroupBox grpbEstadoPaquete;
        private System.Windows.Forms.Label lblTrackinID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.GroupBox grpbPaquete;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostarToolStripMenuItem;
    }
}

