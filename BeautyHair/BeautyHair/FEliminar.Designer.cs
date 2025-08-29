namespace BeautyHair
{
    partial class FEliminar
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEliminar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSi.Location = new System.Drawing.Point(12, 169);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(218, 169);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desea Eliminar los siguientes datos:";
            // 
            // lbEliminar
            // 
            this.lbEliminar.FormattingEnabled = true;
            this.lbEliminar.Location = new System.Drawing.Point(12, 25);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(281, 134);
            this.lbEliminar.TabIndex = 3;
            // 
            // FEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 199);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Name = "FEliminar";
            this.Text = "Confirmar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbEliminar;
    }
}