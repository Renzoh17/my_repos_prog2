namespace PartidoBasquet2024
{
    partial class Puntuacion
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
            this.gbPuntos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroCamiseta = new System.Windows.Forms.TextBox();
            this.tbPtsCanasta = new System.Windows.Forms.TextBox();
            this.lbPtsLocal = new System.Windows.Forms.Label();
            this.lbVisitante = new System.Windows.Forms.Label();
            this.btnCargarPts = new System.Windows.Forms.Button();
            this.btnFinalizarPart = new System.Windows.Forms.Button();
            this.gbPuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPuntos
            // 
            this.gbPuntos.Controls.Add(this.btnFinalizarPart);
            this.gbPuntos.Controls.Add(this.btnCargarPts);
            this.gbPuntos.Controls.Add(this.lbVisitante);
            this.gbPuntos.Controls.Add(this.lbPtsLocal);
            this.gbPuntos.Controls.Add(this.tbPtsCanasta);
            this.gbPuntos.Controls.Add(this.tbNroCamiseta);
            this.gbPuntos.Controls.Add(this.label2);
            this.gbPuntos.Controls.Add(this.label1);
            this.gbPuntos.Location = new System.Drawing.Point(12, 12);
            this.gbPuntos.Name = "gbPuntos";
            this.gbPuntos.Size = new System.Drawing.Size(361, 216);
            this.gbPuntos.TabIndex = 0;
            this.gbPuntos.TabStop = false;
            this.gbPuntos.Text = "Puntuaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Camiseta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puntos Canasta:";
            // 
            // tbNroCamiseta
            // 
            this.tbNroCamiseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNroCamiseta.Location = new System.Drawing.Point(201, 20);
            this.tbNroCamiseta.Name = "tbNroCamiseta";
            this.tbNroCamiseta.Size = new System.Drawing.Size(154, 31);
            this.tbNroCamiseta.TabIndex = 2;
            // 
            // tbPtsCanasta
            // 
            this.tbPtsCanasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPtsCanasta.Location = new System.Drawing.Point(201, 58);
            this.tbPtsCanasta.Name = "tbPtsCanasta";
            this.tbPtsCanasta.Size = new System.Drawing.Size(154, 31);
            this.tbPtsCanasta.TabIndex = 3;
            // 
            // lbPtsLocal
            // 
            this.lbPtsLocal.AutoSize = true;
            this.lbPtsLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPtsLocal.Location = new System.Drawing.Point(6, 138);
            this.lbPtsLocal.Name = "lbPtsLocal";
            this.lbPtsLocal.Size = new System.Drawing.Size(112, 37);
            this.lbPtsLocal.TabIndex = 4;
            this.lbPtsLocal.Text = "Local: ";
            // 
            // lbVisitante
            // 
            this.lbVisitante.AutoSize = true;
            this.lbVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitante.Location = new System.Drawing.Point(165, 138);
            this.lbVisitante.Name = "lbVisitante";
            this.lbVisitante.Size = new System.Drawing.Size(158, 37);
            this.lbVisitante.TabIndex = 5;
            this.lbVisitante.Text = "Visitante: ";
            // 
            // btnCargarPts
            // 
            this.btnCargarPts.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCargarPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPts.Location = new System.Drawing.Point(6, 95);
            this.btnCargarPts.Name = "btnCargarPts";
            this.btnCargarPts.Size = new System.Drawing.Size(349, 40);
            this.btnCargarPts.TabIndex = 6;
            this.btnCargarPts.Text = "Cargar Puntos";
            this.btnCargarPts.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarPart
            // 
            this.btnFinalizarPart.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnFinalizarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPart.Location = new System.Drawing.Point(6, 178);
            this.btnFinalizarPart.Name = "btnFinalizarPart";
            this.btnFinalizarPart.Size = new System.Drawing.Size(349, 32);
            this.btnFinalizarPart.TabIndex = 7;
            this.btnFinalizarPart.Text = "Finalizar Partido";
            this.btnFinalizarPart.UseVisualStyleBackColor = true;
            // 
            // Puntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 239);
            this.Controls.Add(this.gbPuntos);
            this.Name = "Puntuacion";
            this.Text = "Puntuacion";
            this.gbPuntos.ResumeLayout(false);
            this.gbPuntos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVisitante;
        private System.Windows.Forms.Label lbPtsLocal;
        private System.Windows.Forms.TextBox tbPtsCanasta;
        private System.Windows.Forms.TextBox tbNroCamiseta;
        private System.Windows.Forms.Button btnFinalizarPart;
        private System.Windows.Forms.Button btnCargarPts;
    }
}