namespace piedrapapeltijera
{
    partial class Humano
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
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPiedra = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.rbTijera = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerminar
            // 
            this.btnTerminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTerminar.Location = new System.Drawing.Point(155, 219);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 4;
            this.btnTerminar.Text = "Terminar Partida";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTijera);
            this.groupBox1.Controls.Add(this.rbPapel);
            this.groupBox1.Controls.Add(this.rbPiedra);
            this.groupBox1.Location = new System.Drawing.Point(43, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegi la opcion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbPiedra
            // 
            this.rbPiedra.AutoSize = true;
            this.rbPiedra.Location = new System.Drawing.Point(21, 41);
            this.rbPiedra.Name = "rbPiedra";
            this.rbPiedra.Size = new System.Drawing.Size(55, 17);
            this.rbPiedra.TabIndex = 0;
            this.rbPiedra.TabStop = true;
            this.rbPiedra.Text = "Piedra";
            this.rbPiedra.UseVisualStyleBackColor = true;
            // 
            // rbPapel
            // 
            this.rbPapel.AutoSize = true;
            this.rbPapel.Location = new System.Drawing.Point(21, 64);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(52, 17);
            this.rbPapel.TabIndex = 1;
            this.rbPapel.TabStop = true;
            this.rbPapel.Text = "Papel";
            this.rbPapel.UseVisualStyleBackColor = true;
            // 
            // rbTijera
            // 
            this.rbTijera.AutoSize = true;
            this.rbTijera.Location = new System.Drawing.Point(22, 87);
            this.rbTijera.Name = "rbTijera";
            this.rbTijera.Size = new System.Drawing.Size(51, 17);
            this.rbTijera.TabIndex = 2;
            this.rbTijera.TabStop = true;
            this.rbTijera.Text = "Tijera";
            this.rbTijera.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnJugar.Location = new System.Drawing.Point(332, 79);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(76, 45);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // Humano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 303);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTerminar);
            this.Name = "Humano";
            this.Text = "Humano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnTerminar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbTijera;
        public System.Windows.Forms.RadioButton rbPapel;
        public System.Windows.Forms.RadioButton rbPiedra;
        public System.Windows.Forms.Button btnJugar;
    }
}