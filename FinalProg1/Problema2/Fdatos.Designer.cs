namespace Problema2
{
    partial class Fdatos
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
            this.tbNroMovil = new System.Windows.Forms.TextBox();
            this.lDistanciaKM = new System.Windows.Forms.Label();
            this.lNroMovil = new System.Windows.Forms.Label();
            this.tbDistanciaKM = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNroMovil
            // 
            this.tbNroMovil.Location = new System.Drawing.Point(177, 28);
            this.tbNroMovil.Name = "tbNroMovil";
            this.tbNroMovil.Size = new System.Drawing.Size(100, 20);
            this.tbNroMovil.TabIndex = 0;
            // 
            // lDistanciaKM
            // 
            this.lDistanciaKM.AutoSize = true;
            this.lDistanciaKM.Location = new System.Drawing.Point(31, 78);
            this.lDistanciaKM.Name = "lDistanciaKM";
            this.lDistanciaKM.Size = new System.Drawing.Size(85, 13);
            this.lDistanciaKM.TabIndex = 2;
            this.lDistanciaKM.Text = "Distancia en KM";
            // 
            // lNroMovil
            // 
            this.lNroMovil.AutoSize = true;
            this.lNroMovil.Location = new System.Drawing.Point(31, 28);
            this.lNroMovil.Name = "lNroMovil";
            this.lNroMovil.Size = new System.Drawing.Size(67, 13);
            this.lNroMovil.TabIndex = 2;
            this.lNroMovil.Text = "Nro de Movil";
            // 
            // tbDistanciaKM
            // 
            this.tbDistanciaKM.Location = new System.Drawing.Point(177, 75);
            this.tbDistanciaKM.Name = "tbDistanciaKM";
            this.tbDistanciaKM.Size = new System.Drawing.Size(100, 20);
            this.tbDistanciaKM.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(177, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(41, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Fdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 146);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbDistanciaKM);
            this.Controls.Add(this.lNroMovil);
            this.Controls.Add(this.lDistanciaKM);
            this.Controls.Add(this.tbNroMovil);
            this.Name = "Fdatos";
            this.Text = "Fdatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDistanciaKM;
        private System.Windows.Forms.Label lNroMovil;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbNroMovil;
        public System.Windows.Forms.TextBox tbDistanciaKM;
    }
}