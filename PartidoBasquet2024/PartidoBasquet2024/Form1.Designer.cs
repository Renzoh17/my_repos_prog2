namespace PartidoBasquet2024
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnVisitante = new System.Windows.Forms.Button();
            this.tbxCantLocal = new System.Windows.Forms.TextBox();
            this.tbxCantVisitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(106, 273);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(190, 85);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Jugar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(39, 28);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(135, 56);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.Text = "Agregar Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnVisitante
            // 
            this.btnVisitante.Location = new System.Drawing.Point(39, 101);
            this.btnVisitante.Name = "btnVisitante";
            this.btnVisitante.Size = new System.Drawing.Size(135, 56);
            this.btnVisitante.TabIndex = 2;
            this.btnVisitante.Text = "Agregar Visitante";
            this.btnVisitante.UseVisualStyleBackColor = true;
            this.btnVisitante.Click += new System.EventHandler(this.btnVisitante_Click);
            // 
            // tbxCantLocal
            // 
            this.tbxCantLocal.Location = new System.Drawing.Point(199, 64);
            this.tbxCantLocal.Name = "tbxCantLocal";
            this.tbxCantLocal.Size = new System.Drawing.Size(175, 20);
            this.tbxCantLocal.TabIndex = 3;
            // 
            // tbxCantVisitante
            // 
            this.tbxCantVisitante.Location = new System.Drawing.Point(199, 137);
            this.tbxCantVisitante.Name = "tbxCantVisitante";
            this.tbxCantVisitante.Size = new System.Drawing.Size(175, 20);
            this.tbxCantVisitante.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "cantidad jugadores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "cantidad jugadores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCantVisitante);
            this.Controls.Add(this.tbxCantLocal);
            this.Controls.Add(this.btnVisitante);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnVisitante;
        private System.Windows.Forms.TextBox tbxCantLocal;
        private System.Windows.Forms.TextBox tbxCantVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

