namespace piedrapapeltijera
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
            this.btnPcvsPc = new System.Windows.Forms.Button();
            this.btnPcvsHumano = new System.Windows.Forms.Button();
            this.lbxResumen = new System.Windows.Forms.ListBox();
            this.lbxJugadas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el modo de juego:";
            // 
            // btnPcvsPc
            // 
            this.btnPcvsPc.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPcvsPc.Location = new System.Drawing.Point(403, 245);
            this.btnPcvsPc.Name = "btnPcvsPc";
            this.btnPcvsPc.Size = new System.Drawing.Size(110, 80);
            this.btnPcvsPc.TabIndex = 1;
            this.btnPcvsPc.Text = "Pc vs Pc";
            this.btnPcvsPc.UseVisualStyleBackColor = false;
            this.btnPcvsPc.Click += new System.EventHandler(this.btnPcvsPc_Click);
            // 
            // btnPcvsHumano
            // 
            this.btnPcvsHumano.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPcvsHumano.Location = new System.Drawing.Point(403, 110);
            this.btnPcvsHumano.Name = "btnPcvsHumano";
            this.btnPcvsHumano.Size = new System.Drawing.Size(110, 80);
            this.btnPcvsHumano.TabIndex = 2;
            this.btnPcvsHumano.Text = "Pc vs Humano";
            this.btnPcvsHumano.UseVisualStyleBackColor = false;
            this.btnPcvsHumano.Click += new System.EventHandler(this.btnPcvsHumano_Click);
            // 
            // lbxResumen
            // 
            this.lbxResumen.FormattingEnabled = true;
            this.lbxResumen.Location = new System.Drawing.Point(12, 88);
            this.lbxResumen.Name = "lbxResumen";
            this.lbxResumen.Size = new System.Drawing.Size(169, 251);
            this.lbxResumen.TabIndex = 3;
            // 
            // lbxJugadas
            // 
            this.lbxJugadas.FormattingEnabled = true;
            this.lbxJugadas.Location = new System.Drawing.Point(208, 88);
            this.lbxJugadas.Name = "lbxJugadas";
            this.lbxJugadas.Size = new System.Drawing.Size(169, 251);
            this.lbxJugadas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(84, 28);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(361, 20);
            this.tbxNombre.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 360);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxJugadas);
            this.Controls.Add(this.lbxResumen);
            this.Controls.Add(this.btnPcvsHumano);
            this.Controls.Add(this.btnPcvsPc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPcvsPc;
        private System.Windows.Forms.Button btnPcvsHumano;
        private System.Windows.Forms.ListBox lbxResumen;
        private System.Windows.Forms.ListBox lbxJugadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNombre;
    }
}

