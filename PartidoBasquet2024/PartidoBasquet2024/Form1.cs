using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartidoBasquet2024
{
    public partial class Form1 : Form
    {
        private Partido partido;
        private Equipo e1, e2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            AgregarJugadores vtnAgregar = new AgregarJugadores();
            e1 = new Equipo();
            for (int i = 0; i < Convert.ToInt32(tbxCantLocal.Text); i++)
            {
                while(vtnAgregar.ShowDialog() == DialogResult.OK)
                {
                    e1.AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text,Convert.ToInt32(vtnAgregar.tbxCamiseta.Text)));
                }
            }
            btnLocal.Enabled = false;
            tbxCantLocal.Enabled = false;
            vtnAgregar.Dispose();
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            AgregarJugadores vtnAgregar = new AgregarJugadores();
            e2 = new Equipo();
            for (int i = 0; i < Convert.ToInt32(tbxCantLocal.Text); i++)
            {
                while (vtnAgregar.ShowDialog() == DialogResult.OK)
                {
                    e2.AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text, Convert.ToInt32(vtnAgregar.tbxCamiseta.Text)));
                }
            }
            btnVisitante.Enabled = false;
            tbxCantVisitante.Enabled = false;
            vtnAgregar.Dispose();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            partido = new Partido(new Cancha("25 de mayo", "9 de Julio", 300));
            partido.AgregarEquipo(e1,e2);            
        }
    }
}
