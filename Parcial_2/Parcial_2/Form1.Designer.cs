namespace Parcial_2
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNroCtaCte = new System.Windows.Forms.CheckBox();
            this.txtCtacte = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.btnImportarCtasCtes = new System.Windows.Forms.Button();
            this.btnExportarTickets = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(45, 9);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(134, 22);
            this.tbDNI.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.txtCtacte);
            this.groupBox1.Controls.Add(this.cbNroCtaCte);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos:";
            // 
            // cbNroCtaCte
            // 
            this.cbNroCtaCte.AutoSize = true;
            this.cbNroCtaCte.Location = new System.Drawing.Point(6, 21);
            this.cbNroCtaCte.Name = "cbNroCtaCte";
            this.cbNroCtaCte.Size = new System.Drawing.Size(116, 20);
            this.cbNroCtaCte.TabIndex = 3;
            this.cbNroCtaCte.Text = "Nro Cuenta Cte";
            this.cbNroCtaCte.UseVisualStyleBackColor = true;
            // 
            // txtCtacte
            // 
            this.txtCtacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtacte.Location = new System.Drawing.Point(128, 19);
            this.txtCtacte.Name = "txtCtacte";
            this.txtCtacte.Size = new System.Drawing.Size(101, 22);
            this.txtCtacte.TabIndex = 3;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(253, 37);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 58);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportarTickets);
            this.groupBox2.Controls.Add(this.btnImportarCtasCtes);
            this.groupBox2.Controls.Add(this.rbPagos);
            this.groupBox2.Controls.Add(this.rbCompras);
            this.groupBox2.Controls.Add(this.btnAtenderCliente);
            this.groupBox2.Controls.Add(this.lbxTurnos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.HorizontalScrollbar = true;
            this.lbxTurnos.ItemHeight = 16;
            this.lbxTurnos.Location = new System.Drawing.Point(6, 21);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(223, 100);
            this.lbxTurnos.TabIndex = 5;
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Location = new System.Drawing.Point(103, 127);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(75, 44);
            this.btnAtenderCliente.TabIndex = 5;
            this.btnAtenderCliente.Text = "Atender cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(6, 127);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(80, 20);
            this.rbCompras.TabIndex = 5;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Location = new System.Drawing.Point(6, 151);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(65, 20);
            this.rbPagos.TabIndex = 6;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            // 
            // btnImportarCtasCtes
            // 
            this.btnImportarCtasCtes.Location = new System.Drawing.Point(235, 21);
            this.btnImportarCtasCtes.Name = "btnImportarCtasCtes";
            this.btnImportarCtasCtes.Size = new System.Drawing.Size(75, 44);
            this.btnImportarCtasCtes.TabIndex = 7;
            this.btnImportarCtasCtes.Text = "Importar Ctas Ctes";
            this.btnImportarCtasCtes.UseVisualStyleBackColor = true;
            this.btnImportarCtasCtes.Click += new System.EventHandler(this.btnImportarCtasCtes_Click);
            // 
            // btnExportarTickets
            // 
            this.btnExportarTickets.Location = new System.Drawing.Point(235, 77);
            this.btnExportarTickets.Name = "btnExportarTickets";
            this.btnExportarTickets.Size = new System.Drawing.Size(75, 44);
            this.btnExportarTickets.TabIndex = 8;
            this.btnExportarTickets.Text = "Exportar Tickets";
            this.btnExportarTickets.UseVisualStyleBackColor = true;
            this.btnExportarTickets.Click += new System.EventHandler(this.btnExportarTickets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parcial 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCtacte;
        private System.Windows.Forms.CheckBox cbNroCtaCte;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportarTickets;
        private System.Windows.Forms.Button btnImportarCtasCtes;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.RadioButton rbCompras;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.ListBox lbxTurnos;
    }
}

