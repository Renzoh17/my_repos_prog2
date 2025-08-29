using Act_3._3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_3._3
{
    public partial class Form1 : Form
    {
        Estancia estancia;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltaEstancia_Click(object sender, EventArgs e)
        {
            string nom = txtNombreAltaEstancia.Text;
            string id = txtIdAltaEstancia.Text;
            double sup = Convert.ToDouble(txtSupAltaEstancia.Text);
           
            estancia = new Estancia(nom, id, sup);

            cbActividades.Items.AddRange(new string[]{"Agricola", "Ivernada", "Cria", "ReCria"});
        }

        private void btnAltaCampos_Click(object sender, EventArgs e)
        {
            string id = txtIdAltaCampos.Text;
            double sup = Convert.ToDouble(txtSupAltaCampos.Text);

            Campo campo = estancia.AgregarCampo(id, sup);
            cbCampos.Items.Add(campo);
        }

        private void btnActListCampos_Click(object sender, EventArgs e)
        {
            cbCampos.Items.Clear();
            for (int i = 0; i < estancia.CantidadCampos; i++)
                cbCampos.Items.Add(estancia.VerCampo(i));
        }

        private void btnAltaParcela_Click(object sender, EventArgs e)
        {
            Campo campo = cbCampos.SelectedItem as Campo;
            if (campo != null)
            {
                string id = txtIdAltaParcela.Text;
                double sup = Convert.ToDouble(txtSupAltaParcela.Text);
                bool r = campo.CrearParcela(id, sup);
                if (r) MessageBox.Show("La parcela fue creada correctamente", "Success", MessageBoxButtons.OK);
                else MessageBox.Show("No se pudo crear la parcela", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltaActividad_Click(object sender, EventArgs e)
        {
            string act = cbActividades.SelectedItem as string;
            int periodo = Convert.ToInt32(txtPeriodo.Text);
            string descrip = txtDescripcion.Text;
            if (act != null)
            {
                Actividad a = null;
                switch (act)
                {
                    case "Agricola":
                        a = new Agricola(periodo, descrip);
                        break;
                    case "Ivernada":
                        a = new Ivernada(periodo, descrip); 
                        break;
                    case "Cria":
                        a = new Cria(periodo, descrip);
                        break;
                    case "ReCria":
                        a = new ReCria(periodo, descrip);
                        break;
                }
                if (a != null) estancia.AltaActividad(a);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una Actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActCamposDisp_Click(object sender, EventArgs e)
        {
            btnActListCampos_Click(sender, e);
        }
    }
}
