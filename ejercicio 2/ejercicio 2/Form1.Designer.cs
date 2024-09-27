namespace ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBdestino = new System.Windows.Forms.ComboBox();
            this.cBtransporte = new System.Windows.Forms.ComboBox();
            this.cbxVuelta = new System.Windows.Forms.CheckBox();
            this.bResumen = new System.Windows.Forms.Button();
            this.bGenerar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gBdatos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lBresumen = new System.Windows.Forms.ListBox();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.gBdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transporte:";
            // 
            // cBdestino
            // 
            this.cBdestino.FormattingEnabled = true;
            this.cBdestino.Location = new System.Drawing.Point(79, 5);
            this.cBdestino.Name = "cBdestino";
            this.cBdestino.Size = new System.Drawing.Size(121, 21);
            this.cBdestino.TabIndex = 4;
            // 
            // cBtransporte
            // 
            this.cBtransporte.FormattingEnabled = true;
            this.cBtransporte.Location = new System.Drawing.Point(79, 64);
            this.cBtransporte.Name = "cBtransporte";
            this.cBtransporte.Size = new System.Drawing.Size(121, 21);
            this.cBtransporte.TabIndex = 5;
            this.cBtransporte.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbxVuelta
            // 
            this.cbxVuelta.AutoSize = true;
            this.cbxVuelta.Location = new System.Drawing.Point(180, 39);
            this.cbxVuelta.Name = "cbxVuelta";
            this.cbxVuelta.Size = new System.Drawing.Size(56, 17);
            this.cbxVuelta.TabIndex = 6;
            this.cbxVuelta.Text = "Vuelta";
            this.cbxVuelta.UseVisualStyleBackColor = true;
            this.cbxVuelta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bResumen
            // 
            this.bResumen.Location = new System.Drawing.Point(218, 62);
            this.bResumen.Name = "bResumen";
            this.bResumen.Size = new System.Drawing.Size(75, 23);
            this.bResumen.TabIndex = 7;
            this.bResumen.Text = "Resumen";
            this.bResumen.UseVisualStyleBackColor = true;
            this.bResumen.Click += new System.EventHandler(this.bResumen_Click);
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(218, 5);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(75, 23);
            this.bGenerar.TabIndex = 8;
            this.bGenerar.Text = "Generar";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(79, 37);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(79, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // gBdatos
            // 
            this.gBdatos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gBdatos.Controls.Add(this.label7);
            this.gBdatos.Controls.Add(this.label6);
            this.gBdatos.Controls.Add(this.label5);
            this.gBdatos.Controls.Add(this.label4);
            this.gBdatos.Controls.Add(this.txtTel);
            this.gBdatos.Controls.Add(this.txtNro);
            this.gBdatos.Controls.Add(this.txtNombre);
            this.gBdatos.Controls.Add(this.txtCuil);
            this.gBdatos.Location = new System.Drawing.Point(12, 110);
            this.gBdatos.Name = "gBdatos";
            this.gBdatos.Size = new System.Drawing.Size(281, 140);
            this.gBdatos.TabIndex = 11;
            this.gBdatos.TabStop = false;
            this.gBdatos.Text = "Datos pasajero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nro Tarjeta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cuil /Cuit";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(73, 77);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(84, 104);
            this.txtNro.MaxLength = 16;
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(169, 20);
            this.txtNro.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(71, 24);
            this.txtCuil.MaxLength = 11;
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 0;
            // 
            // lBresumen
            // 
            this.lBresumen.FormattingEnabled = true;
            this.lBresumen.Location = new System.Drawing.Point(343, 13);
            this.lBresumen.Name = "lBresumen";
            this.lBresumen.Size = new System.Drawing.Size(196, 212);
            this.lBresumen.TabIndex = 12;
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Location = new System.Drawing.Point(343, 231);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(75, 23);
            this.btnEjemplo.TabIndex = 13;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 262);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.lBresumen);
            this.Controls.Add(this.gBdatos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.bGenerar);
            this.Controls.Add(this.bResumen);
            this.Controls.Add(this.cbxVuelta);
            this.Controls.Add(this.cBtransporte);
            this.Controls.Add(this.cBdestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBdatos.ResumeLayout(false);
            this.gBdatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBdestino;
        private System.Windows.Forms.ComboBox cBtransporte;
        private System.Windows.Forms.CheckBox cbxVuelta;
        private System.Windows.Forms.Button bResumen;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gBdatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.ListBox lBresumen;
        private System.Windows.Forms.Button btnEjemplo;
    }
}

