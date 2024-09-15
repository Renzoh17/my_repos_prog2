namespace Ejercicio_3
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
            this.tbPrueba = new System.Windows.Forms.TextBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrueba
            // 
            this.tbPrueba.Location = new System.Drawing.Point(12, 12);
            this.tbPrueba.Multiline = true;
            this.tbPrueba.Name = "tbPrueba";
            this.tbPrueba.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPrueba.Size = new System.Drawing.Size(469, 304);
            this.tbPrueba.TabIndex = 0;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(487, 12);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(133, 41);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 327);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.tbPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrueba;
        private System.Windows.Forms.Button btnPrueba;
    }
}

