using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedrapapeltijera
{
    public partial class Form1 : Form
    {
        private int opcion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnPcvsHumano_Click(object sender, EventArgs e)
        {
            Humano venH = new Humano();
            Jugador j1 = new Jugador(tbxNombre.Text);
            Jugador j2 = new Jugador();
            while (venH.ShowDialog() == DialogResult.OK)
            {
                if (venH.rbPiedra.Checked)
                {
                    opcion = 0;
                }
                else if (venH.rbPapel.Checked)
                {
                    opcion = 1;
                }
                else if(venH.rbTijera.Checked)
                {
                    opcion = 2;
                }
                j1.Jugar(opcion);
                int pts = Jugada(j2.Jugar());
                if (pts == 0)
                {
                    j1.Puntos = 1;
                    j2.Puntos = 1;
                }
                else if (pts == 1) j1.Puntos = 2;
                else j2.Puntos = 2;
            }
            lbxResumen.Items.Clear();
            lbxResumen.Items.Add("Puntos Jugador");
            lbxResumen.Items.Add(j1.Puntos);
            lbxResumen.Items.Add(j1.Resumen());

        }

        private void btnPcvsPc_Click(object sender, EventArgs e)
        {

        }

        private int Jugada(int res)
        {
            int resta = opcion - res;
            string op, opc;
            if (opcion == 0) op = "Piedra";
            else if (opcion == 1) op = "Papel";
            else op = "Tijera";
            if (res == 0) opc = "Piedra";
            else if (res == 1) opc = "Papel";
            else opc = "Tijera";

            if (resta == 0)
            {
                MessageBox.Show($"{tbxNombre.Text}: {op}\nPC: {opc}\n EMPATE!");
                return 0;
            }
            else if (Math.Abs(resta) == 2)
            {
                resta *= -1;
                if (resta > 0)
                {
                    MessageBox.Show($"{tbxNombre.Text}: {op}\nPC: {opc}\n GANASTE! ");
                    return 1;
                }
                else
                {
                    MessageBox.Show($"{tbxNombre.Text}: {op}\nPC: {opc}\n PERDISTE!");
                    return 2;
                }
            }
            return 0;

        }
    }
}
