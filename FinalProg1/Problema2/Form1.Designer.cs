namespace Problema2
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
            this.GBinicio = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbUnidades = new System.Windows.Forms.TextBox();
            this.tbPrecioKM = new System.Windows.Forms.TextBox();
            this.lUnidades = new System.Windows.Forms.Label();
            this.lPrecioKM = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.btnComision = new System.Windows.Forms.Button();
            this.btnFinalizarDia = new System.Windows.Forms.Button();
            this.lbComision = new System.Windows.Forms.ListBox();
            this.gbComision = new System.Windows.Forms.GroupBox();
            this.lbViaje = new System.Windows.Forms.ListBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.lbOrden = new System.Windows.Forms.ListBox();
            this.GBinicio.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbComision.SuspendLayout();
            this.gbOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBinicio
            // 
            this.GBinicio.Controls.Add(this.lPrecioKM);
            this.GBinicio.Controls.Add(this.lUnidades);
            this.GBinicio.Controls.Add(this.tbPrecioKM);
            this.GBinicio.Controls.Add(this.tbUnidades);
            this.GBinicio.Controls.Add(this.btnAceptar);
            this.GBinicio.Location = new System.Drawing.Point(12, 12);
            this.GBinicio.Name = "GBinicio";
            this.GBinicio.Size = new System.Drawing.Size(220, 113);
            this.GBinicio.TabIndex = 0;
            this.GBinicio.TabStop = false;
            this.GBinicio.Text = "Inicio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(73, 84);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbUnidades
            // 
            this.tbUnidades.Location = new System.Drawing.Point(114, 19);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Size = new System.Drawing.Size(100, 20);
            this.tbUnidades.TabIndex = 1;
            // 
            // tbPrecioKM
            // 
            this.tbPrecioKM.Location = new System.Drawing.Point(114, 58);
            this.tbPrecioKM.Name = "tbPrecioKM";
            this.tbPrecioKM.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioKM.TabIndex = 2;
            // 
            // lUnidades
            // 
            this.lUnidades.AutoSize = true;
            this.lUnidades.Location = new System.Drawing.Point(28, 22);
            this.lUnidades.Name = "lUnidades";
            this.lUnidades.Size = new System.Drawing.Size(52, 13);
            this.lUnidades.TabIndex = 1;
            this.lUnidades.Text = "Unidades";
            // 
            // lPrecioKM
            // 
            this.lPrecioKM.AutoSize = true;
            this.lPrecioKM.Location = new System.Drawing.Point(28, 61);
            this.lPrecioKM.Name = "lPrecioKM";
            this.lPrecioKM.Size = new System.Drawing.Size(63, 13);
            this.lPrecioKM.TabIndex = 3;
            this.lPrecioKM.Text = "Precio * KM";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lbViaje);
            this.gbControl.Controls.Add(this.btnFinalizarDia);
            this.gbControl.Controls.Add(this.btnComision);
            this.gbControl.Controls.Add(this.btnAgregarViaje);
            this.gbControl.Enabled = false;
            this.gbControl.Location = new System.Drawing.Point(12, 131);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(220, 122);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(12, 19);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(96, 43);
            this.btnAgregarViaje.TabIndex = 0;
            this.btnAgregarViaje.Text = "Agregar Viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // btnComision
            // 
            this.btnComision.Enabled = false;
            this.btnComision.Location = new System.Drawing.Point(12, 68);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(96, 43);
            this.btnComision.TabIndex = 1;
            this.btnComision.Text = "Comisión";
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // btnFinalizarDia
            // 
            this.btnFinalizarDia.Location = new System.Drawing.Point(114, 68);
            this.btnFinalizarDia.Name = "btnFinalizarDia";
            this.btnFinalizarDia.Size = new System.Drawing.Size(96, 43);
            this.btnFinalizarDia.TabIndex = 2;
            this.btnFinalizarDia.Text = "Finalizar Dia";
            this.btnFinalizarDia.UseVisualStyleBackColor = true;
            this.btnFinalizarDia.Click += new System.EventHandler(this.btnFinalizarDia_Click);
            // 
            // lbComision
            // 
            this.lbComision.FormattingEnabled = true;
            this.lbComision.Location = new System.Drawing.Point(6, 18);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(175, 212);
            this.lbComision.TabIndex = 2;
            // 
            // gbComision
            // 
            this.gbComision.Controls.Add(this.lbComision);
            this.gbComision.Enabled = false;
            this.gbComision.Location = new System.Drawing.Point(238, 12);
            this.gbComision.Name = "gbComision";
            this.gbComision.Size = new System.Drawing.Size(187, 241);
            this.gbComision.TabIndex = 3;
            this.gbComision.TabStop = false;
            this.gbComision.Text = "Comisión";
            // 
            // lbViaje
            // 
            this.lbViaje.FormattingEnabled = true;
            this.lbViaje.Location = new System.Drawing.Point(114, 19);
            this.lbViaje.Name = "lbViaje";
            this.lbViaje.Size = new System.Drawing.Size(96, 43);
            this.lbViaje.TabIndex = 3;
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.lbOrden);
            this.gbOrden.Enabled = false;
            this.gbOrden.Location = new System.Drawing.Point(431, 12);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(157, 241);
            this.gbOrden.TabIndex = 4;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden (Mayor a Menor)";
            // 
            // lbOrden
            // 
            this.lbOrden.FormattingEnabled = true;
            this.lbOrden.Location = new System.Drawing.Point(6, 18);
            this.lbOrden.Name = "lbOrden";
            this.lbOrden.Size = new System.Drawing.Size(145, 212);
            this.lbOrden.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbComision);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.GBinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBinicio.ResumeLayout(false);
            this.GBinicio.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbComision.ResumeLayout(false);
            this.gbOrden.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBinicio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbPrecioKM;
        private System.Windows.Forms.TextBox tbUnidades;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lPrecioKM;
        private System.Windows.Forms.Label lUnidades;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.Button btnComision;
        private System.Windows.Forms.Button btnFinalizarDia;
        private System.Windows.Forms.ListBox lbComision;
        private System.Windows.Forms.GroupBox gbComision;
        private System.Windows.Forms.ListBox lbViaje;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.ListBox lbOrden;
    }
}

