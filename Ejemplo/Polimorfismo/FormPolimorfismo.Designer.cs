namespace Polimorfismo
{
    partial class FormPolimorfismo
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
            this.bVer = new System.Windows.Forms.Button();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCrear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBestudiante = new System.Windows.Forms.RadioButton();
            this.rBpersona = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(124, 45);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(59, 23);
            this.bVer.TabIndex = 12;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(81, 19);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(102, 20);
            this.tBnombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(48, 45);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(59, 23);
            this.bCrear.TabIndex = 9;
            this.bCrear.Text = "Agregar";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 160);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rBestudiante);
            this.groupBox1.Controls.Add(this.rBpersona);
            this.groupBox1.Location = new System.Drawing.Point(189, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // rBestudiante
            // 
            this.rBestudiante.AutoSize = true;
            this.rBestudiante.Location = new System.Drawing.Point(37, 39);
            this.rBestudiante.Name = "rBestudiante";
            this.rBestudiante.Size = new System.Drawing.Size(75, 17);
            this.rBestudiante.TabIndex = 1;
            this.rBestudiante.TabStop = true;
            this.rBestudiante.Text = "Estudiante";
            this.rBestudiante.UseVisualStyleBackColor = true;
            // 
            // rBpersona
            // 
            this.rBpersona.AutoSize = true;
            this.rBpersona.Location = new System.Drawing.Point(37, 19);
            this.rBpersona.Name = "rBpersona";
            this.rBpersona.Size = new System.Drawing.Size(64, 17);
            this.rBpersona.TabIndex = 0;
            this.rBpersona.TabStop = true;
            this.rBpersona.Text = "Profesor";
            this.rBpersona.UseVisualStyleBackColor = true;
            // 
            // FormPolimorfismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.listBox1);
            this.Name = "FormPolimorfismo";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBestudiante;
        private System.Windows.Forms.RadioButton rBpersona;
    }
}

