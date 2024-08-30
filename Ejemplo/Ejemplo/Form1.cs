using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        private Numeros misValores;
        private int[] nValores;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            lista.Items.Clear();   
            if (tBcantidad.Text != "")
            {
                int c = Convert.ToInt32(tBcantidad.Text);
                misValores = new Numeros(c);
            }
            else misValores = new Numeros();
            nValores = misValores.Valores();
            for (int n = 0; n < nValores.Length; n++)
                lista.Items.Add("Posición: " + n.ToString("00") + " Valor: " + nValores[n].ToString());
            //Con foreach
            foreach (int a in nValores)
            {
                lista.Items.Add($"Valor: {a.ToString()}");
            }

            this.Text = misValores.CANTIDAD.ToString();
            //misValores.CANTIDAD = 4;
        }



        private void tBcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                if (e.KeyChar == 13) button1.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
