using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;  

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tickets> reservas = new List<Tickets>();
        Transporte unTransporte;
        double precioOriginal;
        List<Transporte> transporteList = new List<Transporte>();

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = ((Transporte)cBtransporte.SelectedItem).Precio(cbxVuelta.Checked).ToString();
        }

        private void bGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Tickets unTickets = new Tickets(txtNombre.Text, txtCuil.Text, Convert.ToInt64(txtTel.Text));
                unTransporte = (Transporte)cBtransporte.SelectedItem;
                unTickets.AgregarTransporte(unTransporte);
                unTickets.PrecioF = unTransporte.Precio(cbxVuelta.Checked);
                reservas.Add(unTickets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (checkBox1.Checked)
                txtPrecio.Text = Convert.ToString(precioOriginal * 2);
            else
                txtPrecio.Text = Convert.ToString(precioOriginal);
             */ 
        }

        private void bResumen_Click(object sender, EventArgs e)
        {
            lBresumen.Items.Clear();
            reservas.Sort();
            foreach (Tickets pasaje in reservas)
            {
                lBresumen.Items.AddRange(pasaje.Datos());    
            }
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            Transporte t;
            t = new Bus(10000, "Rosario", 100, 2);
            transporteList.Add(t);
            t = new Bus(20000, "Paraná", 50, 3);
            transporteList.Add(t);
            t = new Avion(30000, "Bs As", "B-115");
            transporteList.Add(t);
            t = new Avion(35000, "Cordoba", "A-120");
            transporteList.Add(t);
            cBtransporte.Items.Clear();
            foreach (Transporte tr in transporteList)
            {
                cBtransporte.Items.Add(tr);
                cBdestino.Items.Add(tr.Destino);
            }
        }
    }
}