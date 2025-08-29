namespace Act_3._3
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
            this.gbAltaCampos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAltaCampos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupAltaCampos = new System.Windows.Forms.TextBox();
            this.btnAltaCampos = new System.Windows.Forms.Button();
            this.gbAltaEstancia = new System.Windows.Forms.GroupBox();
            this.btnAltaEstancia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupAltaEstancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAltaEstancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreAltaEstancia = new System.Windows.Forms.TextBox();
            this.gbAltaParcelas = new System.Windows.Forms.GroupBox();
            this.cbCampos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupAltaParcela = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdAltaParcela = new System.Windows.Forms.TextBox();
            this.btnActListCampos = new System.Windows.Forms.Button();
            this.btnAltaParcela = new System.Windows.Forms.Button();
            this.gbAltaActividad = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbActividades = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnAltaActividad = new System.Windows.Forms.Button();
            this.gbAltaParcelaAct = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAsigParcela = new System.Windows.Forms.Button();
            this.btnActCamposDisp = new System.Windows.Forms.Button();
            this.gbAltaCampos.SuspendLayout();
            this.gbAltaEstancia.SuspendLayout();
            this.gbAltaParcelas.SuspendLayout();
            this.gbAltaActividad.SuspendLayout();
            this.gbAltaParcelaAct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAltaCampos
            // 
            this.gbAltaCampos.Controls.Add(this.btnAltaCampos);
            this.gbAltaCampos.Controls.Add(this.label2);
            this.gbAltaCampos.Controls.Add(this.txtSupAltaCampos);
            this.gbAltaCampos.Controls.Add(this.label1);
            this.gbAltaCampos.Controls.Add(this.txtIdAltaCampos);
            this.gbAltaCampos.Location = new System.Drawing.Point(6, 112);
            this.gbAltaCampos.Name = "gbAltaCampos";
            this.gbAltaCampos.Size = new System.Drawing.Size(325, 80);
            this.gbAltaCampos.TabIndex = 0;
            this.gbAltaCampos.TabStop = false;
            this.gbAltaCampos.Text = "Alta de campos (2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador";
            // 
            // txtIdAltaCampos
            // 
            this.txtIdAltaCampos.Location = new System.Drawing.Point(86, 19);
            this.txtIdAltaCampos.Name = "txtIdAltaCampos";
            this.txtIdAltaCampos.Size = new System.Drawing.Size(85, 20);
            this.txtIdAltaCampos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superficie";
            // 
            // txtSupAltaCampos
            // 
            this.txtSupAltaCampos.Location = new System.Drawing.Point(86, 45);
            this.txtSupAltaCampos.Name = "txtSupAltaCampos";
            this.txtSupAltaCampos.Size = new System.Drawing.Size(85, 20);
            this.txtSupAltaCampos.TabIndex = 4;
            // 
            // btnAltaCampos
            // 
            this.btnAltaCampos.Location = new System.Drawing.Point(211, 19);
            this.btnAltaCampos.Name = "btnAltaCampos";
            this.btnAltaCampos.Size = new System.Drawing.Size(108, 46);
            this.btnAltaCampos.TabIndex = 1;
            this.btnAltaCampos.Text = "Alta de Campo";
            this.btnAltaCampos.UseVisualStyleBackColor = true;
            this.btnAltaCampos.Click += new System.EventHandler(this.btnAltaCampos_Click);
            // 
            // gbAltaEstancia
            // 
            this.gbAltaEstancia.Controls.Add(this.label5);
            this.gbAltaEstancia.Controls.Add(this.txtNombreAltaEstancia);
            this.gbAltaEstancia.Controls.Add(this.btnAltaEstancia);
            this.gbAltaEstancia.Controls.Add(this.label3);
            this.gbAltaEstancia.Controls.Add(this.txtSupAltaEstancia);
            this.gbAltaEstancia.Controls.Add(this.label4);
            this.gbAltaEstancia.Controls.Add(this.txtIdAltaEstancia);
            this.gbAltaEstancia.Location = new System.Drawing.Point(6, 6);
            this.gbAltaEstancia.Name = "gbAltaEstancia";
            this.gbAltaEstancia.Size = new System.Drawing.Size(325, 100);
            this.gbAltaEstancia.TabIndex = 5;
            this.gbAltaEstancia.TabStop = false;
            this.gbAltaEstancia.Text = "Alta de la Estancia (1)";
            // 
            // btnAltaEstancia
            // 
            this.btnAltaEstancia.Location = new System.Drawing.Point(211, 31);
            this.btnAltaEstancia.Name = "btnAltaEstancia";
            this.btnAltaEstancia.Size = new System.Drawing.Size(108, 46);
            this.btnAltaEstancia.TabIndex = 1;
            this.btnAltaEstancia.Text = "Alta de la Estancia";
            this.btnAltaEstancia.UseVisualStyleBackColor = true;
            this.btnAltaEstancia.Click += new System.EventHandler(this.btnAltaEstancia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Superficie";
            // 
            // txtSupAltaEstancia
            // 
            this.txtSupAltaEstancia.Location = new System.Drawing.Point(86, 71);
            this.txtSupAltaEstancia.Name = "txtSupAltaEstancia";
            this.txtSupAltaEstancia.Size = new System.Drawing.Size(85, 20);
            this.txtSupAltaEstancia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identificador";
            // 
            // txtIdAltaEstancia
            // 
            this.txtIdAltaEstancia.Location = new System.Drawing.Point(86, 45);
            this.txtIdAltaEstancia.Name = "txtIdAltaEstancia";
            this.txtIdAltaEstancia.Size = new System.Drawing.Size(85, 20);
            this.txtIdAltaEstancia.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre";
            // 
            // txtNombreAltaEstancia
            // 
            this.txtNombreAltaEstancia.Location = new System.Drawing.Point(86, 19);
            this.txtNombreAltaEstancia.Name = "txtNombreAltaEstancia";
            this.txtNombreAltaEstancia.Size = new System.Drawing.Size(85, 20);
            this.txtNombreAltaEstancia.TabIndex = 6;
            // 
            // gbAltaParcelas
            // 
            this.gbAltaParcelas.Controls.Add(this.btnAltaParcela);
            this.gbAltaParcelas.Controls.Add(this.btnActListCampos);
            this.gbAltaParcelas.Controls.Add(this.label7);
            this.gbAltaParcelas.Controls.Add(this.label6);
            this.gbAltaParcelas.Controls.Add(this.txtSupAltaParcela);
            this.gbAltaParcelas.Controls.Add(this.cbCampos);
            this.gbAltaParcelas.Controls.Add(this.label8);
            this.gbAltaParcelas.Controls.Add(this.txtIdAltaParcela);
            this.gbAltaParcelas.Location = new System.Drawing.Point(6, 198);
            this.gbAltaParcelas.Name = "gbAltaParcelas";
            this.gbAltaParcelas.Size = new System.Drawing.Size(325, 109);
            this.gbAltaParcelas.TabIndex = 6;
            this.gbAltaParcelas.TabStop = false;
            this.gbAltaParcelas.Text = "Alta de parcelas (3)";
            // 
            // cbCampos
            // 
            this.cbCampos.FormattingEnabled = true;
            this.cbCampos.Location = new System.Drawing.Point(86, 19);
            this.cbCampos.Name = "cbCampos";
            this.cbCampos.Size = new System.Drawing.Size(138, 21);
            this.cbCampos.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Elegir Campo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Superficie parcela";
            // 
            // txtSupAltaParcela
            // 
            this.txtSupAltaParcela.Location = new System.Drawing.Point(139, 72);
            this.txtSupAltaParcela.Name = "txtSupAltaParcela";
            this.txtSupAltaParcela.Size = new System.Drawing.Size(85, 20);
            this.txtSupAltaParcela.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Identificador de parcela";
            // 
            // txtIdAltaParcela
            // 
            this.txtIdAltaParcela.Location = new System.Drawing.Point(139, 46);
            this.txtIdAltaParcela.Name = "txtIdAltaParcela";
            this.txtIdAltaParcela.Size = new System.Drawing.Size(85, 20);
            this.txtIdAltaParcela.TabIndex = 6;
            // 
            // btnActListCampos
            // 
            this.btnActListCampos.Location = new System.Drawing.Point(230, 12);
            this.btnActListCampos.Name = "btnActListCampos";
            this.btnActListCampos.Size = new System.Drawing.Size(89, 50);
            this.btnActListCampos.TabIndex = 5;
            this.btnActListCampos.Text = "Actualizar listado campos (a)";
            this.btnActListCampos.UseVisualStyleBackColor = true;
            this.btnActListCampos.Click += new System.EventHandler(this.btnActListCampos_Click);
            // 
            // btnAltaParcela
            // 
            this.btnAltaParcela.Location = new System.Drawing.Point(230, 63);
            this.btnAltaParcela.Name = "btnAltaParcela";
            this.btnAltaParcela.Size = new System.Drawing.Size(89, 37);
            this.btnAltaParcela.TabIndex = 9;
            this.btnAltaParcela.Text = "Alta de Parcela (c)";
            this.btnAltaParcela.UseVisualStyleBackColor = true;
            this.btnAltaParcela.Click += new System.EventHandler(this.btnAltaParcela_Click);
            // 
            // gbAltaActividad
            // 
            this.gbAltaActividad.Controls.Add(this.btnAltaActividad);
            this.gbAltaActividad.Controls.Add(this.label9);
            this.gbAltaActividad.Controls.Add(this.cbActividades);
            this.gbAltaActividad.Controls.Add(this.label10);
            this.gbAltaActividad.Controls.Add(this.txtPeriodo);
            this.gbAltaActividad.Controls.Add(this.txtDescripcion);
            this.gbAltaActividad.Controls.Add(this.label11);
            this.gbAltaActividad.Location = new System.Drawing.Point(337, 6);
            this.gbAltaActividad.Name = "gbAltaActividad";
            this.gbAltaActividad.Size = new System.Drawing.Size(332, 100);
            this.gbAltaActividad.TabIndex = 7;
            this.gbAltaActividad.TabStop = false;
            this.gbAltaActividad.Text = "Alta de Actividad (4)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Elegir tipo de Actividad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(132, 71);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(85, 20);
            this.txtDescripcion.TabIndex = 15;
            // 
            // cbActividades
            // 
            this.cbActividades.FormattingEnabled = true;
            this.cbActividades.Location = new System.Drawing.Point(129, 18);
            this.cbActividades.Name = "cbActividades";
            this.cbActividades.Size = new System.Drawing.Size(88, 21);
            this.cbActividades.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(132, 45);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(85, 20);
            this.txtPeriodo.TabIndex = 12;
            // 
            // btnAltaActividad
            // 
            this.btnAltaActividad.Location = new System.Drawing.Point(237, 18);
            this.btnAltaActividad.Name = "btnAltaActividad";
            this.btnAltaActividad.Size = new System.Drawing.Size(89, 73);
            this.btnAltaActividad.TabIndex = 10;
            this.btnAltaActividad.Text = "Alta de Actividad";
            this.btnAltaActividad.UseVisualStyleBackColor = true;
            this.btnAltaActividad.Click += new System.EventHandler(this.btnAltaActividad_Click);
            // 
            // gbAltaParcelaAct
            // 
            this.gbAltaParcelaAct.Controls.Add(this.btnActCamposDisp);
            this.gbAltaParcelaAct.Controls.Add(this.btnAsigParcela);
            this.gbAltaParcelaAct.Controls.Add(this.comboBox2);
            this.gbAltaParcelaAct.Controls.Add(this.label13);
            this.gbAltaParcelaAct.Controls.Add(this.comboBox1);
            this.gbAltaParcelaAct.Controls.Add(this.label12);
            this.gbAltaParcelaAct.Location = new System.Drawing.Point(337, 112);
            this.gbAltaParcelaAct.Name = "gbAltaParcelaAct";
            this.gbAltaParcelaAct.Size = new System.Drawing.Size(332, 136);
            this.gbAltaParcelaAct.TabIndex = 8;
            this.gbAltaParcelaAct.TabStop = false;
            this.gbAltaParcelaAct.Text = "Alta de parcela en Actividad(5)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Elegir Campo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Elegir las parcelas disponibles";
            // 
            // btnAsigParcela
            // 
            this.btnAsigParcela.Location = new System.Drawing.Point(237, 83);
            this.btnAsigParcela.Name = "btnAsigParcela";
            this.btnAsigParcela.Size = new System.Drawing.Size(89, 47);
            this.btnAsigParcela.TabIndex = 16;
            this.btnAsigParcela.Text = "Asignar Parcela";
            this.btnAsigParcela.UseVisualStyleBackColor = true;
            // 
            // btnActCamposDisp
            // 
            this.btnActCamposDisp.Location = new System.Drawing.Point(142, 83);
            this.btnActCamposDisp.Name = "btnActCamposDisp";
            this.btnActCamposDisp.Size = new System.Drawing.Size(89, 47);
            this.btnActCamposDisp.TabIndex = 19;
            this.btnActCamposDisp.Text = "Actualizar campos disponibles";
            this.btnActCamposDisp.UseVisualStyleBackColor = true;
            this.btnActCamposDisp.Click += new System.EventHandler(this.btnActCamposDisp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.gbAltaParcelaAct);
            this.Controls.Add(this.gbAltaActividad);
            this.Controls.Add(this.gbAltaParcelas);
            this.Controls.Add(this.gbAltaEstancia);
            this.Controls.Add(this.gbAltaCampos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAltaCampos.ResumeLayout(false);
            this.gbAltaCampos.PerformLayout();
            this.gbAltaEstancia.ResumeLayout(false);
            this.gbAltaEstancia.PerformLayout();
            this.gbAltaParcelas.ResumeLayout(false);
            this.gbAltaParcelas.PerformLayout();
            this.gbAltaActividad.ResumeLayout(false);
            this.gbAltaActividad.PerformLayout();
            this.gbAltaParcelaAct.ResumeLayout(false);
            this.gbAltaParcelaAct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAltaCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupAltaCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAltaCampos;
        private System.Windows.Forms.Button btnAltaCampos;
        private System.Windows.Forms.GroupBox gbAltaEstancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreAltaEstancia;
        private System.Windows.Forms.Button btnAltaEstancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupAltaEstancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAltaEstancia;
        private System.Windows.Forms.GroupBox gbAltaParcelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCampos;
        private System.Windows.Forms.Button btnAltaParcela;
        private System.Windows.Forms.Button btnActListCampos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSupAltaParcela;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdAltaParcela;
        private System.Windows.Forms.GroupBox gbAltaActividad;
        private System.Windows.Forms.Button btnAltaActividad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbActividades;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbAltaParcelaAct;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnActCamposDisp;
        private System.Windows.Forms.Button btnAsigParcela;
    }
}

