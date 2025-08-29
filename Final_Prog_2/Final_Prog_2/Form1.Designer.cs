namespace Final_Prog_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosEmp = new System.Windows.Forms.GroupBox();
            this.tbCuitEmp = new System.Windows.Forms.TextBox();
            this.tbRSEmp = new System.Windows.Forms.TextBox();
            this.btnCrearEmp = new System.Windows.Forms.Button();
            this.gbGestionV = new System.Windows.Forms.GroupBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnCrearCli = new System.Windows.Forms.Button();
            this.tbTopeCli = new System.Windows.Forms.TextBox();
            this.tbNombreCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCuitCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSistema = new System.Windows.Forms.GroupBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.tbMontoPago = new System.Windows.Forms.TextBox();
            this.tbCuitPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCompra = new System.Windows.Forms.GroupBox();
            this.tbCuitCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCargarProd = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.tbKilos = new System.Windows.Forms.TextBox();
            this.btnImportarCueCli = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnImportarProd = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gbDatosEmp.SuspendLayout();
            this.gbGestionV.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbSistema.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social:";
            // 
            // gbDatosEmp
            // 
            this.gbDatosEmp.Controls.Add(this.btnCrearEmp);
            this.gbDatosEmp.Controls.Add(this.tbRSEmp);
            this.gbDatosEmp.Controls.Add(this.tbCuitEmp);
            this.gbDatosEmp.Controls.Add(this.label1);
            this.gbDatosEmp.Controls.Add(this.label2);
            this.gbDatosEmp.Location = new System.Drawing.Point(12, 12);
            this.gbDatosEmp.Name = "gbDatosEmp";
            this.gbDatosEmp.Size = new System.Drawing.Size(201, 111);
            this.gbDatosEmp.TabIndex = 2;
            this.gbDatosEmp.TabStop = false;
            this.gbDatosEmp.Text = "Datos Empresa";
            // 
            // tbCuitEmp
            // 
            this.tbCuitEmp.Location = new System.Drawing.Point(89, 22);
            this.tbCuitEmp.Name = "tbCuitEmp";
            this.tbCuitEmp.Size = new System.Drawing.Size(100, 20);
            this.tbCuitEmp.TabIndex = 3;
            // 
            // tbRSEmp
            // 
            this.tbRSEmp.Location = new System.Drawing.Point(89, 56);
            this.tbRSEmp.Name = "tbRSEmp";
            this.tbRSEmp.Size = new System.Drawing.Size(100, 20);
            this.tbRSEmp.TabIndex = 4;
            // 
            // btnCrearEmp
            // 
            this.btnCrearEmp.Location = new System.Drawing.Point(114, 82);
            this.btnCrearEmp.Name = "btnCrearEmp";
            this.btnCrearEmp.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEmp.TabIndex = 3;
            this.btnCrearEmp.Text = "Crear";
            this.btnCrearEmp.UseVisualStyleBackColor = true;
            this.btnCrearEmp.Click += new System.EventHandler(this.btnCrearEmp_Click);
            // 
            // gbGestionV
            // 
            this.gbGestionV.Controls.Add(this.gbCompra);
            this.gbGestionV.Controls.Add(this.gbPago);
            this.gbGestionV.Controls.Add(this.gbCliente);
            this.gbGestionV.Enabled = false;
            this.gbGestionV.Location = new System.Drawing.Point(219, 12);
            this.gbGestionV.Name = "gbGestionV";
            this.gbGestionV.Size = new System.Drawing.Size(577, 303);
            this.gbGestionV.TabIndex = 3;
            this.gbGestionV.TabStop = false;
            this.gbGestionV.Text = "Gestion Ventas";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbCuitCli);
            this.gbCliente.Controls.Add(this.btnCrearCli);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.tbTopeCli);
            this.gbCliente.Controls.Add(this.tbNombreCli);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Location = new System.Drawing.Point(6, 19);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(200, 150);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Crear Cliente";
            // 
            // btnCrearCli
            // 
            this.btnCrearCli.Location = new System.Drawing.Point(119, 120);
            this.btnCrearCli.Name = "btnCrearCli";
            this.btnCrearCli.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCli.TabIndex = 7;
            this.btnCrearCli.Text = "Crear";
            this.btnCrearCli.UseVisualStyleBackColor = true;
            this.btnCrearCli.Click += new System.EventHandler(this.btnCrearCli_Click);
            // 
            // tbTopeCli
            // 
            this.tbTopeCli.Location = new System.Drawing.Point(89, 56);
            this.tbTopeCli.Name = "tbTopeCli";
            this.tbTopeCli.Size = new System.Drawing.Size(100, 20);
            this.tbTopeCli.TabIndex = 9;
            // 
            // tbNombreCli
            // 
            this.tbNombreCli.Location = new System.Drawing.Point(89, 22);
            this.tbNombreCli.Name = "tbNombreCli";
            this.tbNombreCli.Size = new System.Drawing.Size(100, 20);
            this.tbNombreCli.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tope:";
            // 
            // tbCuitCli
            // 
            this.tbCuitCli.Location = new System.Drawing.Point(89, 94);
            this.tbCuitCli.Name = "tbCuitCli";
            this.tbCuitCli.Size = new System.Drawing.Size(100, 20);
            this.tbCuitCli.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CUIT:";
            // 
            // gbSistema
            // 
            this.gbSistema.Controls.Add(this.btnImportarProd);
            this.gbSistema.Controls.Add(this.btnImportarCueCli);
            this.gbSistema.Location = new System.Drawing.Point(12, 123);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Size = new System.Drawing.Size(200, 192);
            this.gbSistema.TabIndex = 1;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Sistema";
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.btnPago);
            this.gbPago.Controls.Add(this.tbMontoPago);
            this.gbPago.Controls.Add(this.tbCuitPago);
            this.gbPago.Controls.Add(this.label6);
            this.gbPago.Controls.Add(this.label7);
            this.gbPago.Location = new System.Drawing.Point(6, 175);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(200, 122);
            this.gbPago.TabIndex = 1;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(117, 93);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(75, 23);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pagar";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // tbMontoPago
            // 
            this.tbMontoPago.Location = new System.Drawing.Point(92, 54);
            this.tbMontoPago.Name = "tbMontoPago";
            this.tbMontoPago.Size = new System.Drawing.Size(100, 20);
            this.tbMontoPago.TabIndex = 9;
            // 
            // tbCuitPago
            // 
            this.tbCuitPago.Location = new System.Drawing.Point(92, 20);
            this.tbCuitPago.Name = "tbCuitPago";
            this.tbCuitPago.Size = new System.Drawing.Size(100, 20);
            this.tbCuitPago.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CUIT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto:";
            // 
            // gbCompra
            // 
            this.gbCompra.Controls.Add(this.tbCuitCompra);
            this.gbCompra.Controls.Add(this.label8);
            this.gbCompra.Controls.Add(this.tbKilos);
            this.gbCompra.Controls.Add(this.btnGenerarPedido);
            this.gbCompra.Controls.Add(this.lbProductos);
            this.gbCompra.Controls.Add(this.btnCargarProd);
            this.gbCompra.Controls.Add(this.label10);
            this.gbCompra.Controls.Add(this.label9);
            this.gbCompra.Controls.Add(this.cbProductos);
            this.gbCompra.Location = new System.Drawing.Point(212, 19);
            this.gbCompra.Name = "gbCompra";
            this.gbCompra.Size = new System.Drawing.Size(359, 278);
            this.gbCompra.TabIndex = 2;
            this.gbCompra.TabStop = false;
            this.gbCompra.Text = "Compra - Pedido";
            // 
            // tbCuitCompra
            // 
            this.tbCuitCompra.Location = new System.Drawing.Point(154, 223);
            this.tbCuitCompra.Name = "tbCuitCompra";
            this.tbCuitCompra.Size = new System.Drawing.Size(121, 20);
            this.tbCuitCompra.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "CUIT:";
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(154, 19);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(121, 21);
            this.cbProductos.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Productos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Kilos:";
            // 
            // btnCargarProd
            // 
            this.btnCargarProd.Location = new System.Drawing.Point(84, 76);
            this.btnCargarProd.Name = "btnCargarProd";
            this.btnCargarProd.Size = new System.Drawing.Size(201, 23);
            this.btnCargarProd.TabIndex = 16;
            this.btnCargarProd.Text = "Cargar Producto";
            this.btnCargarProd.UseVisualStyleBackColor = true;
            this.btnCargarProd.Click += new System.EventHandler(this.btnCargarProd_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.HorizontalScrollbar = true;
            this.lbProductos.ItemHeight = 14;
            this.lbProductos.Location = new System.Drawing.Point(11, 105);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(342, 102);
            this.lbProductos.TabIndex = 17;
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(84, 249);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(201, 23);
            this.btnGenerarPedido.TabIndex = 18;
            this.btnGenerarPedido.Text = "Generar Pedido";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // tbKilos
            // 
            this.tbKilos.Location = new System.Drawing.Point(154, 50);
            this.tbKilos.Name = "tbKilos";
            this.tbKilos.Size = new System.Drawing.Size(121, 20);
            this.tbKilos.TabIndex = 19;
            // 
            // btnImportarCueCli
            // 
            this.btnImportarCueCli.Location = new System.Drawing.Point(36, 37);
            this.btnImportarCueCli.Name = "btnImportarCueCli";
            this.btnImportarCueCli.Size = new System.Drawing.Size(127, 48);
            this.btnImportarCueCli.TabIndex = 5;
            this.btnImportarCueCli.Text = "Exportar Cuentas Clientes - Pedidos";
            this.btnImportarCueCli.UseVisualStyleBackColor = true;
            this.btnImportarCueCli.Click += new System.EventHandler(this.btnImportarCueCli_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "Archivo CSV (*.CSV) |*.csv";
            // 
            // btnImportarProd
            // 
            this.btnImportarProd.Location = new System.Drawing.Point(36, 116);
            this.btnImportarProd.Name = "btnImportarProd";
            this.btnImportarProd.Size = new System.Drawing.Size(127, 48);
            this.btnImportarProd.TabIndex = 6;
            this.btnImportarProd.Text = "Importar Productos";
            this.btnImportarProd.UseVisualStyleBackColor = true;
            this.btnImportarProd.Click += new System.EventHandler(this.btnImportarProd_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Archivo CSV (*.CSV) |*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 327);
            this.Controls.Add(this.gbSistema);
            this.Controls.Add(this.gbGestionV);
            this.Controls.Add(this.gbDatosEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatosEmp.ResumeLayout(false);
            this.gbDatosEmp.PerformLayout();
            this.gbGestionV.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbSistema.ResumeLayout(false);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbCompra.ResumeLayout(false);
            this.gbCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosEmp;
        private System.Windows.Forms.TextBox tbRSEmp;
        private System.Windows.Forms.TextBox tbCuitEmp;
        private System.Windows.Forms.Button btnCrearEmp;
        private System.Windows.Forms.GroupBox gbGestionV;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnCrearCli;
        private System.Windows.Forms.TextBox tbTopeCli;
        private System.Windows.Forms.TextBox tbNombreCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCuitCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbSistema;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.TextBox tbMontoPago;
        private System.Windows.Forms.TextBox tbCuitPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.TextBox tbCuitCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Button btnCargarProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbKilos;
        private System.Windows.Forms.Button btnImportarCueCli;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnImportarProd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

