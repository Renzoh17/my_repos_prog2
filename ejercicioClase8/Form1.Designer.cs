
namespace ejercicioClase8
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
            this.bGenerar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bLeer = new System.Windows.Forms.Button();
            this.lBitemFactura = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBservicio = new System.Windows.Forms.GroupBox();
            this.bAgregarSer = new System.Windows.Forms.Button();
            this.bNuevoServ = new System.Windows.Forms.Button();
            this.cBservicio = new System.Windows.Forms.ComboBox();
            this.gBproducto = new System.Windows.Forms.GroupBox();
            this.nUcantidad = new System.Windows.Forms.NumericUpDown();
            this.bAgregarPro = new System.Windows.Forms.Button();
            this.bNuevoPro = new System.Windows.Forms.Button();
            this.cBproducto = new System.Windows.Forms.ComboBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBservicio.SuspendLayout();
            this.gBproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(402, 119);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(75, 23);
            this.bGenerar.TabIndex = 0;
            this.bGenerar.Text = "Generar";
            this.bGenerar.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(402, 181);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 1;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            // 
            // bLeer
            // 
            this.bLeer.Location = new System.Drawing.Point(402, 220);
            this.bLeer.Name = "bLeer";
            this.bLeer.Size = new System.Drawing.Size(75, 23);
            this.bLeer.TabIndex = 2;
            this.bLeer.Text = "Leer";
            this.bLeer.UseVisualStyleBackColor = true;
            this.bLeer.Click += new System.EventHandler(this.bLeer_Click);
            // 
            // lBitemFactura
            // 
            this.lBitemFactura.FormattingEnabled = true;
            this.lBitemFactura.Location = new System.Drawing.Point(18, 181);
            this.lBitemFactura.Name = "lBitemFactura";
            this.lBitemFactura.Size = new System.Drawing.Size(372, 134);
            this.lBitemFactura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumibles:";
            // 
            // gBservicio
            // 
            this.gBservicio.BackColor = System.Drawing.SystemColors.Highlight;
            this.gBservicio.Controls.Add(this.bAgregarSer);
            this.gBservicio.Controls.Add(this.bNuevoServ);
            this.gBservicio.Controls.Add(this.cBservicio);
            this.gBservicio.Location = new System.Drawing.Point(12, 19);
            this.gBservicio.Name = "gBservicio";
            this.gBservicio.Size = new System.Drawing.Size(199, 79);
            this.gBservicio.TabIndex = 5;
            this.gBservicio.TabStop = false;
            this.gBservicio.Text = "Servicios:";
            // 
            // bAgregarSer
            // 
            this.bAgregarSer.Location = new System.Drawing.Point(113, 46);
            this.bAgregarSer.Name = "bAgregarSer";
            this.bAgregarSer.Size = new System.Drawing.Size(75, 23);
            this.bAgregarSer.TabIndex = 2;
            this.bAgregarSer.Text = "Agregar";
            this.bAgregarSer.UseVisualStyleBackColor = true;
            // 
            // bNuevoServ
            // 
            this.bNuevoServ.Location = new System.Drawing.Point(6, 46);
            this.bNuevoServ.Name = "bNuevoServ";
            this.bNuevoServ.Size = new System.Drawing.Size(75, 23);
            this.bNuevoServ.TabIndex = 1;
            this.bNuevoServ.Text = "Nuevo";
            this.bNuevoServ.UseVisualStyleBackColor = true;
            // 
            // cBservicio
            // 
            this.cBservicio.FormattingEnabled = true;
            this.cBservicio.Location = new System.Drawing.Point(6, 19);
            this.cBservicio.Name = "cBservicio";
            this.cBservicio.Size = new System.Drawing.Size(182, 21);
            this.cBservicio.TabIndex = 0;
            // 
            // gBproducto
            // 
            this.gBproducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.gBproducto.Controls.Add(this.nUcantidad);
            this.gBproducto.Controls.Add(this.bAgregarPro);
            this.gBproducto.Controls.Add(this.bNuevoPro);
            this.gBproducto.Controls.Add(this.cBproducto);
            this.gBproducto.Location = new System.Drawing.Point(226, 19);
            this.gBproducto.Name = "gBproducto";
            this.gBproducto.Size = new System.Drawing.Size(251, 79);
            this.gBproducto.TabIndex = 6;
            this.gBproducto.TabStop = false;
            this.gBproducto.Text = "Productos:";
            // 
            // nUcantidad
            // 
            this.nUcantidad.Location = new System.Drawing.Point(194, 19);
            this.nUcantidad.Name = "nUcantidad";
            this.nUcantidad.Size = new System.Drawing.Size(42, 20);
            this.nUcantidad.TabIndex = 7;
            // 
            // bAgregarPro
            // 
            this.bAgregarPro.Location = new System.Drawing.Point(161, 46);
            this.bAgregarPro.Name = "bAgregarPro";
            this.bAgregarPro.Size = new System.Drawing.Size(75, 23);
            this.bAgregarPro.TabIndex = 2;
            this.bAgregarPro.Text = "Agregar";
            this.bAgregarPro.UseVisualStyleBackColor = true;
            // 
            // bNuevoPro
            // 
            this.bNuevoPro.Location = new System.Drawing.Point(6, 46);
            this.bNuevoPro.Name = "bNuevoPro";
            this.bNuevoPro.Size = new System.Drawing.Size(75, 23);
            this.bNuevoPro.TabIndex = 1;
            this.bNuevoPro.Text = "Nuevo";
            this.bNuevoPro.UseVisualStyleBackColor = true;
            // 
            // cBproducto
            // 
            this.cBproducto.FormattingEnabled = true;
            this.cBproducto.Location = new System.Drawing.Point(6, 19);
            this.cBproducto.Name = "cBproducto";
            this.cBproducto.Size = new System.Drawing.Size(182, 21);
            this.cBproducto.TabIndex = 0;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(94, 121);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(289, 20);
            this.tBnombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razón Social:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(489, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.gBproducto);
            this.Controls.Add(this.gBservicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBitemFactura);
            this.Controls.Add(this.bLeer);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBservicio.ResumeLayout(false);
            this.gBproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bLeer;
        private System.Windows.Forms.ListBox lBitemFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBservicio;
        private System.Windows.Forms.Button bAgregarSer;
        private System.Windows.Forms.Button bNuevoServ;
        private System.Windows.Forms.ComboBox cBservicio;
        private System.Windows.Forms.GroupBox gBproducto;
        private System.Windows.Forms.NumericUpDown nUcantidad;
        private System.Windows.Forms.Button bAgregarPro;
        private System.Windows.Forms.Button bNuevoPro;
        private System.Windows.Forms.ComboBox cBproducto;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Label label2;
    }
}

