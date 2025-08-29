namespace BeautyHair
{
    partial class FModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNom = new System.Windows.Forms.Label();
            this.lbApel = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(6, 16);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(50, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nombre: ";
            // 
            // lbApel
            // 
            this.lbApel.AutoSize = true;
            this.lbApel.Location = new System.Drawing.Point(6, 42);
            this.lbApel.Name = "lbApel";
            this.lbApel.Size = new System.Drawing.Size(50, 13);
            this.lbApel.TabIndex = 1;
            this.lbApel.Text = "Apellido: ";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(6, 69);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(32, 13);
            this.lbDNI.TabIndex = 2;
            this.lbDNI.Text = "DNI: ";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lbNom);
            this.gbDatos.Controls.Add(this.lbDNI);
            this.gbDatos.Controls.Add(this.lbApel);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(316, 93);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Reales";
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.tbApellido);
            this.gbModificar.Controls.Add(this.tbNombre);
            this.gbModificar.Controls.Add(this.btnCancelar);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Controls.Add(this.label4);
            this.gbModificar.Controls.Add(this.label6);
            this.gbModificar.Location = new System.Drawing.Point(12, 111);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(316, 114);
            this.gbModificar.TabIndex = 4;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Datos a Modificar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido: ";
            // 
            // btnModificar
            // 
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.Location = new System.Drawing.Point(6, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(235, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(126, 13);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(184, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(126, 42);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(184, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // FModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 233);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbDatos);
            this.Name = "FModificar";
            this.Text = "Modificar";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Label lbNom;
        public System.Windows.Forms.Label lbApel;
        public System.Windows.Forms.Label lbDNI;
        public System.Windows.Forms.TextBox tbApellido;
        public System.Windows.Forms.TextBox tbNombre;
    }
}