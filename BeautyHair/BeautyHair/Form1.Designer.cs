namespace BeautyHair
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
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbCrear = new System.Windows.Forms.GroupBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.rbProfesional = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearGab = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNroGabinete = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.gbEliminarOModificar = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbElimModPersona = new System.Windows.Forms.TextBox();
            this.gbMostrarCP = new System.Windows.Forms.GroupBox();
            this.cbProfesionales = new System.Windows.Forms.CheckBox();
            this.cbClientes = new System.Windows.Forms.CheckBox();
            this.btnMostrarCP = new System.Windows.Forms.Button();
            this.lbMostrarCP = new System.Windows.Forms.ListBox();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.cbGabineteNro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDNITurno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDiaDuracion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.gbMostrarDisp = new System.Windows.Forms.GroupBox();
            this.btnMostrarDisp = new System.Windows.Forms.Button();
            this.lbMostrarDisp = new System.Windows.Forms.ListBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gbCrear.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbEliminarOModificar.SuspendLayout();
            this.gbMostrarCP.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.gbMostrarDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(67, 13);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(194, 20);
            this.tbDireccion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(67, 39);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(194, 20);
            this.tbTelefono.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(186, 66);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // gbCrear
            // 
            this.gbCrear.Controls.Add(this.label1);
            this.gbCrear.Controls.Add(this.btnCrear);
            this.gbCrear.Controls.Add(this.tbDireccion);
            this.gbCrear.Controls.Add(this.label2);
            this.gbCrear.Controls.Add(this.tbTelefono);
            this.gbCrear.Location = new System.Drawing.Point(12, 12);
            this.gbCrear.Name = "gbCrear";
            this.gbCrear.Size = new System.Drawing.Size(270, 97);
            this.gbCrear.TabIndex = 6;
            this.gbCrear.TabStop = false;
            this.gbCrear.Text = "Crear BeautyHair";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.rbProfesional);
            this.gbControl.Controls.Add(this.rbCliente);
            this.gbControl.Controls.Add(this.btnAgregar);
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.btnCrearGab);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.tbNombre);
            this.gbControl.Controls.Add(this.label4);
            this.gbControl.Controls.Add(this.tbApellido);
            this.gbControl.Controls.Add(this.tbNroGabinete);
            this.gbControl.Controls.Add(this.tbDNI);
            this.gbControl.Enabled = false;
            this.gbControl.Location = new System.Drawing.Point(12, 115);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(270, 135);
            this.gbControl.TabIndex = 7;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // rbProfesional
            // 
            this.rbProfesional.AutoSize = true;
            this.rbProfesional.Location = new System.Drawing.Point(170, 76);
            this.rbProfesional.Name = "rbProfesional";
            this.rbProfesional.Size = new System.Drawing.Size(77, 17);
            this.rbProfesional.TabIndex = 12;
            this.rbProfesional.TabStop = true;
            this.rbProfesional.Text = "Profesional";
            this.rbProfesional.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(170, 54);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 11;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(170, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 24);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI:";
            // 
            // btnCrearGab
            // 
            this.btnCrearGab.Location = new System.Drawing.Point(170, 19);
            this.btnCrearGab.Name = "btnCrearGab";
            this.btnCrearGab.Size = new System.Drawing.Size(89, 23);
            this.btnCrearGab.TabIndex = 0;
            this.btnCrearGab.Text = "Crear Gabinete";
            this.btnCrearGab.UseVisualStyleBackColor = true;
            this.btnCrearGab.Click += new System.EventHandler(this.btnCrearGab_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro Gabinete:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(62, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(96, 20);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre: ";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(62, 77);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(96, 20);
            this.tbApellido.TabIndex = 5;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbNroGabinete
            // 
            this.tbNroGabinete.Location = new System.Drawing.Point(114, 21);
            this.tbNroGabinete.Name = "tbNroGabinete";
            this.tbNroGabinete.Size = new System.Drawing.Size(44, 20);
            this.tbNroGabinete.TabIndex = 2;
            this.tbNroGabinete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroGabinete_KeyPress);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(62, 103);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(96, 20);
            this.tbDNI.TabIndex = 6;
            // 
            // gbEliminarOModificar
            // 
            this.gbEliminarOModificar.Controls.Add(this.btnModificar);
            this.gbEliminarOModificar.Controls.Add(this.btnEliminarPersona);
            this.gbEliminarOModificar.Controls.Add(this.label7);
            this.gbEliminarOModificar.Controls.Add(this.tbElimModPersona);
            this.gbEliminarOModificar.Enabled = false;
            this.gbEliminarOModificar.Location = new System.Drawing.Point(12, 256);
            this.gbEliminarOModificar.Name = "gbEliminarOModificar";
            this.gbEliminarOModificar.Size = new System.Drawing.Size(270, 95);
            this.gbEliminarOModificar.TabIndex = 8;
            this.gbEliminarOModificar.TabStop = false;
            this.gbEliminarOModificar.Text = "Eliminar o Modificar Persona";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(9, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(250, 34);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(170, 20);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(89, 24);
            this.btnEliminarPersona.TabIndex = 13;
            this.btnEliminarPersona.Text = "Eliminar";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            this.btnEliminarPersona.Click += new System.EventHandler(this.btnEliminarPersona_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "DNI:";
            // 
            // tbElimModPersona
            // 
            this.tbElimModPersona.Location = new System.Drawing.Point(62, 23);
            this.tbElimModPersona.Name = "tbElimModPersona";
            this.tbElimModPersona.Size = new System.Drawing.Size(96, 20);
            this.tbElimModPersona.TabIndex = 13;
            // 
            // gbMostrarCP
            // 
            this.gbMostrarCP.Controls.Add(this.cbProfesionales);
            this.gbMostrarCP.Controls.Add(this.cbClientes);
            this.gbMostrarCP.Controls.Add(this.btnMostrarCP);
            this.gbMostrarCP.Controls.Add(this.lbMostrarCP);
            this.gbMostrarCP.Enabled = false;
            this.gbMostrarCP.Location = new System.Drawing.Point(288, 12);
            this.gbMostrarCP.Name = "gbMostrarCP";
            this.gbMostrarCP.Size = new System.Drawing.Size(231, 339);
            this.gbMostrarCP.TabIndex = 9;
            this.gbMostrarCP.TabStop = false;
            this.gbMostrarCP.Text = "Mostrar Clientes/Profesionales";
            // 
            // cbProfesionales
            // 
            this.cbProfesionales.AutoSize = true;
            this.cbProfesionales.Location = new System.Drawing.Point(75, 29);
            this.cbProfesionales.Name = "cbProfesionales";
            this.cbProfesionales.Size = new System.Drawing.Size(89, 17);
            this.cbProfesionales.TabIndex = 3;
            this.cbProfesionales.Text = "Profesionales";
            this.cbProfesionales.UseVisualStyleBackColor = true;
            // 
            // cbClientes
            // 
            this.cbClientes.AutoSize = true;
            this.cbClientes.Location = new System.Drawing.Point(6, 29);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(63, 17);
            this.cbClientes.TabIndex = 2;
            this.cbClientes.Text = "Clientes";
            this.cbClientes.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCP
            // 
            this.btnMostrarCP.Location = new System.Drawing.Point(6, 296);
            this.btnMostrarCP.Name = "btnMostrarCP";
            this.btnMostrarCP.Size = new System.Drawing.Size(219, 33);
            this.btnMostrarCP.TabIndex = 1;
            this.btnMostrarCP.Text = "Mostrar";
            this.btnMostrarCP.UseVisualStyleBackColor = true;
            this.btnMostrarCP.Click += new System.EventHandler(this.btnMostrarCP_Click);
            // 
            // lbMostrarCP
            // 
            this.lbMostrarCP.FormattingEnabled = true;
            this.lbMostrarCP.Location = new System.Drawing.Point(6, 52);
            this.lbMostrarCP.Name = "lbMostrarCP";
            this.lbMostrarCP.Size = new System.Drawing.Size(219, 238);
            this.lbMostrarCP.TabIndex = 0;
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.cbTratamiento);
            this.gbTurno.Controls.Add(this.cbGabineteNro);
            this.gbTurno.Controls.Add(this.label11);
            this.gbTurno.Controls.Add(this.tbDNITurno);
            this.gbTurno.Controls.Add(this.label9);
            this.gbTurno.Controls.Add(this.btnCrearTurno);
            this.gbTurno.Controls.Add(this.label10);
            this.gbTurno.Controls.Add(this.dtpDiaDuracion);
            this.gbTurno.Controls.Add(this.label8);
            this.gbTurno.Location = new System.Drawing.Point(762, 12);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(317, 222);
            this.gbTurno.TabIndex = 10;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Turnos";
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Items.AddRange(new object[] {
            "Masaje",
            "Depilacion",
            "Peluqueria",
            "Maquillaje"});
            this.cbTratamiento.Location = new System.Drawing.Point(108, 30);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(128, 21);
            this.cbTratamiento.TabIndex = 23;
            // 
            // cbGabineteNro
            // 
            this.cbGabineteNro.FormattingEnabled = true;
            this.cbGabineteNro.Location = new System.Drawing.Point(108, 144);
            this.cbGabineteNro.Name = "cbGabineteNro";
            this.cbGabineteNro.Size = new System.Drawing.Size(128, 21);
            this.cbGabineteNro.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Gabinete N°:";
            // 
            // tbDNITurno
            // 
            this.tbDNITurno.Location = new System.Drawing.Point(108, 109);
            this.tbDNITurno.Name = "tbDNITurno";
            this.tbDNITurno.Size = new System.Drawing.Size(128, 20);
            this.tbDNITurno.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "DNI Cliente:";
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Location = new System.Drawing.Point(6, 172);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(300, 35);
            this.btnCrearTurno.TabIndex = 18;
            this.btnCrearTurno.Text = "Crear Turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tratamiento:";
            // 
            // dtpDiaDuracion
            // 
            this.dtpDiaDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaDuracion.Location = new System.Drawing.Point(108, 77);
            this.dtpDiaDuracion.Name = "dtpDiaDuracion";
            this.dtpDiaDuracion.Size = new System.Drawing.Size(128, 20);
            this.dtpDiaDuracion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dia y Duracion:";
            // 
            // gbMostrarDisp
            // 
            this.gbMostrarDisp.Controls.Add(this.btnMostrarDisp);
            this.gbMostrarDisp.Controls.Add(this.lbMostrarDisp);
            this.gbMostrarDisp.Enabled = false;
            this.gbMostrarDisp.Location = new System.Drawing.Point(525, 12);
            this.gbMostrarDisp.Name = "gbMostrarDisp";
            this.gbMostrarDisp.Size = new System.Drawing.Size(231, 339);
            this.gbMostrarDisp.TabIndex = 10;
            this.gbMostrarDisp.TabStop = false;
            this.gbMostrarDisp.Text = "Mostrar Profesionales Disponibles";
            // 
            // btnMostrarDisp
            // 
            this.btnMostrarDisp.Location = new System.Drawing.Point(6, 296);
            this.btnMostrarDisp.Name = "btnMostrarDisp";
            this.btnMostrarDisp.Size = new System.Drawing.Size(219, 33);
            this.btnMostrarDisp.TabIndex = 1;
            this.btnMostrarDisp.Text = "Mostrar";
            this.btnMostrarDisp.UseVisualStyleBackColor = true;
            this.btnMostrarDisp.Click += new System.EventHandler(this.btnMostrarDisp_Click);
            // 
            // lbMostrarDisp
            // 
            this.lbMostrarDisp.FormattingEnabled = true;
            this.lbMostrarDisp.Location = new System.Drawing.Point(6, 26);
            this.lbMostrarDisp.Name = "lbMostrarDisp";
            this.lbMostrarDisp.Size = new System.Drawing.Size(219, 264);
            this.lbMostrarDisp.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(762, 240);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(154, 33);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(925, 240);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(154, 33);
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "OpenFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 359);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gbMostrarDisp);
            this.Controls.Add(this.gbTurno);
            this.Controls.Add(this.gbMostrarCP);
            this.Controls.Add(this.gbEliminarOModificar);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCrear.ResumeLayout(false);
            this.gbCrear.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbEliminarOModificar.ResumeLayout(false);
            this.gbEliminarOModificar.PerformLayout();
            this.gbMostrarCP.ResumeLayout(false);
            this.gbMostrarCP.PerformLayout();
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.gbMostrarDisp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbCrear;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnCrearGab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNroGabinete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbProfesional;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.GroupBox gbEliminarOModificar;
        private System.Windows.Forms.TextBox tbElimModPersona;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMostrarCP;
        private System.Windows.Forms.ListBox lbMostrarCP;
        private System.Windows.Forms.CheckBox cbProfesionales;
        private System.Windows.Forms.CheckBox cbClientes;
        private System.Windows.Forms.Button btnMostrarCP;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDiaDuracion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDNITurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCrearTurno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGabineteNro;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.GroupBox gbMostrarDisp;
        private System.Windows.Forms.Button btnMostrarDisp;
        private System.Windows.Forms.ListBox lbMostrarDisp;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

