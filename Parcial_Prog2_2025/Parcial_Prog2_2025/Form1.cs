using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Prog2_2025
{
    public partial class Form1 : Form
    {
        Presupuesto presupuesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicioP_Click(object sender, EventArgs e)
        {
            if (presupuesto != null)
            {
                MessageBox.Show("Termine el presupuesto para iniciar otro", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string n = txtNombre.Text;
                string d = txtDireccion.Text;
                if (n == "" || d == "")
                {
                    MessageBox.Show("Cargue correctamente los datos para iniciar un presupuesto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    presupuesto = new Presupuesto(n, d);
                    txtNombre.Clear();
                    txtDireccion.Clear();
                }
            }    
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presupuesto != null)
            {
                Producto p = cbProductos.SelectedItem as Producto;
                bool r = presupuesto.AgregarProducto(p);

                if (r) MessageBox.Show("Se Agrego el Producto con exito", "Success", MessageBoxButtons.OK);
                else MessageBox.Show("No se Agrego el Producto", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Inicie un presupuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Producto[] ps = new Producto[]
            {
                new Mesa(18, 160, 70)
                {
                    Codigo = 116070
                },
                new Mesa(18, 180, 80)
                {
                    Codigo = 118080
                },
                new Banco(20, 140)
                {
                    Codigo = 30140
                }
            };
            cbProductos.Items.AddRange(ps);
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            if (presupuesto != null)
            {
                char c;
                char.TryParse("-", out c);
                string linea = "-".PadRight(100, c);
                string[] s = presupuesto.Resumen();
                string[] ss = new string[]
                    {
                    linea,
                    "Ticket",
                    linea,
                    "Solicitante: " + s[0],
                    linea,
                    "Productos: ",
                    s[2] != null ? s[2] : "",
                    s[3] != null ? s[3]: "",
                    s[4] != null ? s[4] : "",
                    linea,
                    "Precio Final:" + s[1],
                    linea
                };

                FormCerrarPresupuesto vtnCP = new FormCerrarPresupuesto();
                vtnCP.lbCerrarP.Items.AddRange(ss);
                vtnCP.ShowDialog();
                presupuesto = null;
            }
            else
            {
                MessageBox.Show("Inicie un presupuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
