namespace Guia5_Repaso
{
    partial class Form1
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.cbBorrarProducto = new System.Windows.Forms.ComboBox();
            this.btnCerrarPresupuesto = new System.Windows.Forms.Button();
            this.btnIniciarPresupuesto = new System.Windows.Forms.Button();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCargarProductos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecioB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbCargarProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnBorrarProducto);
            this.gbCliente.Controls.Add(this.cbBorrarProducto);
            this.gbCliente.Controls.Add(this.btnCerrarPresupuesto);
            this.gbCliente.Controls.Add(this.btnIniciarPresupuesto);
            this.gbCliente.Controls.Add(this.tbDireccionCliente);
            this.gbCliente.Controls.Add(this.tbNombreCliente);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(253, 160);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Enabled = false;
            this.btnBorrarProducto.Location = new System.Drawing.Point(172, 122);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProducto.TabIndex = 7;
            this.btnBorrarProducto.Text = "Borrar";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // cbBorrarProducto
            // 
            this.cbBorrarProducto.FormattingEnabled = true;
            this.cbBorrarProducto.Location = new System.Drawing.Point(6, 124);
            this.cbBorrarProducto.Name = "cbBorrarProducto";
            this.cbBorrarProducto.Size = new System.Drawing.Size(160, 21);
            this.cbBorrarProducto.TabIndex = 6;
            // 
            // btnCerrarPresupuesto
            // 
            this.btnCerrarPresupuesto.Enabled = false;
            this.btnCerrarPresupuesto.Location = new System.Drawing.Point(172, 66);
            this.btnCerrarPresupuesto.Name = "btnCerrarPresupuesto";
            this.btnCerrarPresupuesto.Size = new System.Drawing.Size(75, 35);
            this.btnCerrarPresupuesto.TabIndex = 5;
            this.btnCerrarPresupuesto.Text = "Cerrar Presupuesto";
            this.btnCerrarPresupuesto.UseVisualStyleBackColor = true;
            this.btnCerrarPresupuesto.Click += new System.EventHandler(this.btnCerrarPresupuesto_Click);
            // 
            // btnIniciarPresupuesto
            // 
            this.btnIniciarPresupuesto.Location = new System.Drawing.Point(9, 66);
            this.btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            this.btnIniciarPresupuesto.Size = new System.Drawing.Size(75, 35);
            this.btnIniciarPresupuesto.TabIndex = 4;
            this.btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            this.btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            this.btnIniciarPresupuesto.Click += new System.EventHandler(this.btnIniciarPresupuesto_Click);
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Location = new System.Drawing.Point(75, 35);
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(172, 20);
            this.tbDireccionCliente.TabIndex = 3;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(75, 13);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(172, 20);
            this.tbNombreCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbCargarProductos
            // 
            this.gbCargarProductos.Controls.Add(this.btnAgregar);
            this.gbCargarProductos.Controls.Add(this.tbGrosor);
            this.gbCargarProductos.Controls.Add(this.tbLargo);
            this.gbCargarProductos.Controls.Add(this.tbCodigo);
            this.gbCargarProductos.Controls.Add(this.tbAncho);
            this.gbCargarProductos.Controls.Add(this.tbPrecioB);
            this.gbCargarProductos.Controls.Add(this.label7);
            this.gbCargarProductos.Controls.Add(this.label6);
            this.gbCargarProductos.Controls.Add(this.label5);
            this.gbCargarProductos.Controls.Add(this.label4);
            this.gbCargarProductos.Controls.Add(this.label3);
            this.gbCargarProductos.Enabled = false;
            this.gbCargarProductos.Location = new System.Drawing.Point(271, 12);
            this.gbCargarProductos.Name = "gbCargarProductos";
            this.gbCargarProductos.Size = new System.Drawing.Size(216, 100);
            this.gbCargarProductos.TabIndex = 2;
            this.gbCargarProductos.TabStop = false;
            this.gbCargarProductos.Text = "Cargar Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(135, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(149, 38);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(41, 20);
            this.tbGrosor.TabIndex = 9;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(149, 15);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(41, 20);
            this.tbLargo.TabIndex = 8;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(59, 62);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(41, 20);
            this.tbCodigo.TabIndex = 7;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(59, 38);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(41, 20);
            this.tbAncho.TabIndex = 6;
            // 
            // tbPrecioB
            // 
            this.tbPrecioB.Location = new System.Drawing.Point(59, 16);
            this.tbPrecioB.Name = "tbPrecioB";
            this.tbPrecioB.Size = new System.Drawing.Size(41, 20);
            this.tbPrecioB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grosor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Largo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PrecioB:";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(280, 133);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 11;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(406, 133);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 180);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.gbCargarProductos);
            this.Controls.Add(this.gbCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbCargarProductos.ResumeLayout(false);
            this.gbCargarProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.ComboBox cbBorrarProducto;
        private System.Windows.Forms.Button btnCerrarPresupuesto;
        private System.Windows.Forms.Button btnIniciarPresupuesto;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.GroupBox gbCargarProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbPrecioB;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
    }
}

