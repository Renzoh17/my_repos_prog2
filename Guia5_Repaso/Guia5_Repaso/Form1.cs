using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia5_Repaso
{
    public partial class Form1 : Form
    {
        Presupuesto presupuesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            presupuesto = new Presupuesto(tbNombreCliente.Text, tbDireccionCliente.Text);
            tbNombreCliente.Enabled = false;
            tbDireccionCliente.Enabled = false;
            btnIniciarPresupuesto.Enabled = false;
            btnCerrarPresupuesto.Enabled = true;
            gbCargarProductos.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p;
            if (tbAncho.Text == "" && tbGrosor.Text == "")
            {
                p = new Banco(Convert.ToDouble(tbPrecioB.Text), Convert.ToDouble(tbLargo.Text));
            }
            else
            {
                p = new Mesa(Convert.ToDouble(tbPrecioB.Text), Convert.ToDouble(tbLargo.Text), Convert.ToDouble(tbAncho.Text), Convert.ToDouble(tbGrosor.Text));
            }
            p.Codigo = Convert.ToInt32(tbCodigo.Text);
            presupuesto.AgregarProducto(p);
            cbBorrarProducto.Items.Add(p.Codigo);
            lblistaProductos.Items.Add(p.ToString());
            if (!btnBorrarProducto.Enabled) btnBorrarProducto.Enabled = true; 
            tbPrecioB.Clear();
            tbLargo.Clear();
            tbAncho.Clear();
            tbGrosor.Clear();
            tbCodigo.Clear();
        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {
            FMostrarPresupuesto vtnMP = new FMostrarPresupuesto();
            string[] r = presupuesto.Resumen();
            vtnMP.lbResumen.Items.Add($"Nombre: {tbNombreCliente.Text}, Direccion: {tbDireccionCliente.Text}");
            vtnMP.lbResumen.Items.Add("------------------------------------------------------------------------------");            
            for (int i = 0; i < r.Length; i++) vtnMP.lbResumen.Items.Add(r[i]);
            vtnMP.lbResumen.Items.Add("------------------------------------------------------------------------------");
            vtnMP.lbResumen.Items.Add($"Precio Final: {presupuesto.Precio.ToString("$0.00")}");
            if (vtnMP.ShowDialog() == DialogResult.OK)
            {
                vtnMP.Dispose();
            }
            cbBorrarProducto.Items.Clear();
            lblistaProductos.Items.Clear();
            tbNombreCliente.Enabled = true;
            tbDireccionCliente.Enabled = true;
            btnIniciarPresupuesto.Enabled = true;
            tbNombreCliente.Clear();
            tbDireccionCliente.Clear();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            bool el = presupuesto.QuitarProducto(Convert.ToInt32(cbBorrarProducto.SelectedItem));
            if (el)
            {
                lblistaProductos.Items.Add($"Producto Eliminado, Codigo: {cbBorrarProducto.SelectedItem}");
                cbBorrarProducto.Items.Remove(cbBorrarProducto.SelectedItem);
                cbBorrarProducto.Text = "";
            }
            else MessageBox.Show("El elemento a Eliminar no existe");
        }
    }
}
