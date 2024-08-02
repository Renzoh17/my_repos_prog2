using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema2
{
    public partial class Form1 : Form
    {
        Empresa e1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            e1 = new Empresa(Convert.ToInt32(tbUnidades.Text), Convert.ToDouble(tbPrecioKM.Text));
            GBinicio.Enabled = false;
            gbControl.Enabled = true;
            
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            Fdatos ven = new Fdatos();
            if (ven.ShowDialog() == DialogResult.OK)
            {
                lbViaje.Items.Clear();
                lbViaje.Items.Add("Total a pagar");
                lbViaje.Items.Add(e1.CargarViaje(Convert.ToInt32(ven.tbNroMovil.Text), Convert.ToDouble(ven.tbDistanciaKM.Text)).ToString("$0.00"));                
            }
            ven.Dispose();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            int i;
            lbComision.Items.Clear();
            lbComision.Items.Add("Viajes Realizados: " + e1.CantidadViajesTotales);
            for (i = 0; i < e1.CantidadUnidades; i++) lbComision.Items.Add("Comisión Unidad " + (i + 1) + ":" + e1.Comision(i).ToString(" $0.00"));
            lbComision.Items.Add("Promedio: " + e1.Promedio().ToString("0.00"));
            lbOrden.Items.Clear();
            lbOrden.Items.Add("Distancias recorridas");
            for (i = 0; i < e1.CantidadUnidades; i++) lbOrden.Items.Add("Distancia Unidad " + (i + 1) + ": " + e1.VerDistanciaRecorridas(i));

        }

        private void btnFinalizarDia_Click(object sender, EventArgs e)
        {
            gbComision.Enabled = true;
            gbOrden.Enabled = true;
            btnComision.Enabled = true;
            btnAgregarViaje.Enabled = false;
            btnFinalizarDia.Enabled = false;
            lbViaje.Enabled = false;
        }
    }
}
