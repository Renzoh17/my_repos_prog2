namespace ejercicio1
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
            this.cbDNI = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.cbNroCuenta = new System.Windows.Forms.CheckBox();
            this.txtCtaCte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDNI
            // 
            this.cbDNI.Location = new System.Drawing.Point(65, 12);
            this.cbDNI.Name = "cbDNI";
            this.cbDNI.Size = new System.Drawing.Size(100, 20);
            this.cbDNI.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(218, 41);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 53);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // cbNroCuenta
            // 
            this.cbNroCuenta.AutoSize = true;
            this.cbNroCuenta.Location = new System.Drawing.Point(6, 19);
            this.cbNroCuenta.Name = "cbNroCuenta";
            this.cbNroCuenta.Size = new System.Drawing.Size(99, 17);
            this.cbNroCuenta.TabIndex = 3;
            this.cbNroCuenta.Text = "Nro Cuenta Cte";
            this.cbNroCuenta.UseVisualStyleBackColor = true;
            // 
            // txtCtaCte
            // 
            this.txtCtaCte.Location = new System.Drawing.Point(111, 17);
            this.txtCtaCte.Name = "txtCtaCte";
            this.txtCtaCte.Size = new System.Drawing.Size(81, 20);
            this.txtCtaCte.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNroCuenta);
            this.groupBox1.Controls.Add(this.txtCtaCte);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turnos";
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.Location = new System.Drawing.Point(18, 125);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.ScrollAlwaysVisible = true;
            this.lbxTurnos.Size = new System.Drawing.Size(194, 82);
            this.lbxTurnos.TabIndex = 8;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(218, 125);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 38);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(218, 169);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 38);
            this.btnImportar.TabIndex = 10;
            this.btnImportar.Text = "Importar Ctas Ctes";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(103, 213);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 38);
            this.btnAtender.TabIndex = 11;
            this.btnAtender.Text = "Atender cliente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(18, 213);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(66, 17);
            this.rbCompras.TabIndex = 12;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Location = new System.Drawing.Point(18, 234);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(55, 17);
            this.rbPagos.TabIndex = 13;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Archivo CSV (*.CSV) |*.CSV";
            this.ofd.InitialDirectory = "Application.StartUp";
            // 
            // sfd
            // 
            this.sfd.Filter = "Archivo CSV (*.CSV) |*.CSV";
            this.sfd.InitialDirectory = "Application.StartUp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 264);
            this.Controls.Add(this.rbPagos);
            this.Controls.Add(this.rbCompras);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.cbDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cbDNI;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.CheckBox cbNroCuenta;
        private System.Windows.Forms.TextBox txtCtaCte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.RadioButton rbCompras;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

