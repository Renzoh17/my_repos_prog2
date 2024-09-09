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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.tbxCantJug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAgregarE = new System.Windows.Forms.GroupBox();
            this.rbVisitante = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.gbListaLocal = new System.Windows.Forms.GroupBox();
            this.btnListas = new System.Windows.Forms.Button();
            this.lListaVisitante = new System.Windows.Forms.ListBox();
            this.lListaLocal = new System.Windows.Forms.ListBox();
            this.gbComenzar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbAgregarE.SuspendLayout();
            this.gbListaLocal.SuspendLayout();
            this.gbComenzar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(9, 96);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(256, 60);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar Partido";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(184, 56);
            this.btnAgregarEquipo.TabIndex = 1;
            this.btnAgregarEquipo.Text = "Agregar Equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // tbxCantJug
            // 
            this.tbxCantJug.Location = new System.Drawing.Point(212, 87);
            this.tbxCantJug.Name = "tbxCantJug";
            this.tbxCantJug.Size = new System.Drawing.Size(50, 20);
            this.tbxCantJug.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad jugadores del Equipo (7 - 15):";
            // 
            // gbAgregarE
            // 
            this.gbAgregarE.Controls.Add(this.rbVisitante);
            this.gbAgregarE.Controls.Add(this.rbLocal);
            this.gbAgregarE.Controls.Add(this.btnAgregarEquipo);
            this.gbAgregarE.Controls.Add(this.label1);
            this.gbAgregarE.Controls.Add(this.tbxCantJug);
            this.gbAgregarE.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarE.Name = "gbAgregarE";
            this.gbAgregarE.Size = new System.Drawing.Size(271, 118);
            this.gbAgregarE.TabIndex = 6;
            this.gbAgregarE.TabStop = false;
            this.gbAgregarE.Text = "Agregar Equipos";
            // 
            // rbVisitante
            // 
            this.rbVisitante.AutoSize = true;
            this.rbVisitante.Location = new System.Drawing.Point(197, 51);
            this.rbVisitante.Name = "rbVisitante";
            this.rbVisitante.Size = new System.Drawing.Size(65, 17);
            this.rbVisitante.TabIndex = 7;
            this.rbVisitante.TabStop = true;
            this.rbVisitante.Text = "Visitante";
            this.rbVisitante.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(197, 28);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 6;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // gbListaLocal
            // 
            this.gbListaLocal.Controls.Add(this.btnListas);
            this.gbListaLocal.Controls.Add(this.lListaVisitante);
            this.gbListaLocal.Controls.Add(this.lListaLocal);
            this.gbListaLocal.Location = new System.Drawing.Point(289, 12);
            this.gbListaLocal.Name = "gbListaLocal";
            this.gbListaLocal.Size = new System.Drawing.Size(441, 286);
            this.gbListaLocal.TabIndex = 7;
            this.gbListaLocal.TabStop = false;
            this.gbListaLocal.Text = "Listado Jugadores";
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(6, 237);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(429, 43);
            this.btnListas.TabIndex = 2;
            this.btnListas.Text = "Obtener Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // lListaVisitante
            // 
            this.lListaVisitante.FormattingEnabled = true;
            this.lListaVisitante.Location = new System.Drawing.Point(225, 19);
            this.lListaVisitante.Name = "lListaVisitante";
            this.lListaVisitante.Size = new System.Drawing.Size(210, 212);
            this.lListaVisitante.TabIndex = 1;
            // 
            // lListaLocal
            // 
            this.lListaLocal.FormattingEnabled = true;
            this.lListaLocal.Location = new System.Drawing.Point(6, 19);
            this.lListaLocal.Name = "lListaLocal";
            this.lListaLocal.Size = new System.Drawing.Size(210, 212);
            this.lListaLocal.TabIndex = 0;
            // 
            // gbComenzar
            // 
            this.gbComenzar.Controls.Add(this.label4);
            this.gbComenzar.Controls.Add(this.label3);
            this.gbComenzar.Controls.Add(this.tbCantidad);
            this.gbComenzar.Controls.Add(this.label2);
            this.gbComenzar.Controls.Add(this.tbUbicacion);
            this.gbComenzar.Controls.Add(this.tbNombre);
            this.gbComenzar.Controls.Add(this.btnJugar);
            this.gbComenzar.Location = new System.Drawing.Point(12, 136);
            this.gbComenzar.Name = "gbComenzar";
            this.gbComenzar.Size = new System.Drawing.Size(271, 162);
            this.gbComenzar.TabIndex = 8;
            this.gbComenzar.TabStop = false;
            this.gbComenzar.Text = "Comenzar Partido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Espacio de la Cancha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ubicacion de la Cancha:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(136, 71);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(126, 20);
            this.tbCantidad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la Cancha: ";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(136, 45);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(126, 20);
            this.tbUbicacion.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(136, 19);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(126, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 307);
            this.Controls.Add(this.gbComenzar);
            this.Controls.Add(this.gbListaLocal);
            this.Controls.Add(this.gbAgregarE);
            this.Name = "Form1";
            this.Text = "Partido Basket";
            this.gbAgregarE.ResumeLayout(false);
            this.gbAgregarE.PerformLayout();
            this.gbListaLocal.ResumeLayout(false);
            this.gbComenzar.ResumeLayout(false);
            this.gbComenzar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.TextBox tbxCantJug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAgregarE;
        private System.Windows.Forms.RadioButton rbVisitante;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.GroupBox gbListaLocal;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.ListBox lListaVisitante;
        private System.Windows.Forms.ListBox lListaLocal;
        private System.Windows.Forms.GroupBox gbComenzar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUbicacion;
    }
}

