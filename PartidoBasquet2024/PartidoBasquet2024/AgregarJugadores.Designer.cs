namespace PartidoBasquet2024
{
    partial class AgregarJugadores
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
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxNroCamiseta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbJugadores = new System.Windows.Forms.GroupBox();
            this.gbJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(112, 19);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(242, 20);
            this.tbxNombre.TabIndex = 0;
            // 
            // tbxNroCamiseta
            // 
            this.tbxNroCamiseta.Location = new System.Drawing.Point(112, 58);
            this.tbxNroCamiseta.Name = "tbxNroCamiseta";
            this.tbxNroCamiseta.Size = new System.Drawing.Size(242, 20);
            this.tbxNroCamiseta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de jugador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de camiseta:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(186, 93);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(168, 51);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(6, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 51);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbJugadores
            // 
            this.gbJugadores.Controls.Add(this.label1);
            this.gbJugadores.Controls.Add(this.btnCancelar);
            this.gbJugadores.Controls.Add(this.btnAceptar);
            this.gbJugadores.Controls.Add(this.tbxNombre);
            this.gbJugadores.Controls.Add(this.tbxNroCamiseta);
            this.gbJugadores.Controls.Add(this.label2);
            this.gbJugadores.Location = new System.Drawing.Point(12, 12);
            this.gbJugadores.Name = "gbJugadores";
            this.gbJugadores.Size = new System.Drawing.Size(360, 153);
            this.gbJugadores.TabIndex = 6;
            this.gbJugadores.TabStop = false;
            this.gbJugadores.Text = "Jugador";
            // 
            // AgregarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 175);
            this.Controls.Add(this.gbJugadores);
            this.Name = "AgregarJugadores";
            this.Text = "AgregarJugadores";
            this.gbJugadores.ResumeLayout(false);
            this.gbJugadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxNroCamiseta;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbJugadores;
    }
}