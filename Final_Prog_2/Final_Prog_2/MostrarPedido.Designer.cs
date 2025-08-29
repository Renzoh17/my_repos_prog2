namespace Final_Prog_2
{
    partial class MostrarPedido
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbResumenPed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCerrar.Location = new System.Drawing.Point(156, 230);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tbResumenPed
            // 
            this.tbResumenPed.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResumenPed.Location = new System.Drawing.Point(12, 12);
            this.tbResumenPed.Multiline = true;
            this.tbResumenPed.Name = "tbResumenPed";
            this.tbResumenPed.ReadOnly = true;
            this.tbResumenPed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResumenPed.Size = new System.Drawing.Size(370, 212);
            this.tbResumenPed.TabIndex = 2;
            // 
            // MostrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 260);
            this.Controls.Add(this.tbResumenPed);
            this.Controls.Add(this.btnCerrar);
            this.Name = "MostrarPedido";
            this.Text = "Resumen Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox tbResumenPed;
    }
}