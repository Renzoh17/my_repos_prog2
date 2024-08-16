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
        private Equipo[] equipos = new Equipo[2];
        public Form1()
        {
            for (int i = 0; i < 2; i++) equipos[i] = new Equipo();
            InitializeComponent();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            int cantJug = Convert.ToInt32(tbxCantJug.Text);
            int i = 0;
            if (cantJug >= 7 && cantJug <= 15)
            {
                AgregarJugadores vtnAgregar = new AgregarJugadores();
                while (i < cantJug)
                {
                    if(vtnAgregar.ShowDialog() == DialogResult.OK)
                    {
                        if (rbLocal.Checked) equipos[0].AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text.ToString(), Convert.ToInt32(vtnAgregar.tbxNroCamiseta.Text)));
                        else equipos[1].AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text, Convert.ToInt32(vtnAgregar.tbxNroCamiseta.Text)));                    
                        vtnAgregar.tbxNombre.Clear();
                        vtnAgregar.tbxNroCamiseta.Clear();
                    }
                    else
                    {
                        i = 20; //Sale del rango para cancelar la carga
                    }
                    i++;
                }
                tbxCantJug.Clear();
                vtnAgregar.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR! Ingrese la cantidad de jugadores correctamente.");
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Puntuacion vtnpts = new Puntuacion();
            partido = new Partido(new Cancha(tbNombre.Text, tbUbicacion.Text, Convert.ToInt32(tbCantidad.Text)));
            tbNombre.Clear();
            tbUbicacion.Clear();
            tbCantidad.Clear();
            partido.AgregarEquipo(equipos);
            while (vtnpts.ShowDialog() == DialogResult.Yes)
            {
                
            }
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            lListaLocal.Items.Clear();
            lListaVisitante.Items.Clear();
            for (int i = 0; i < equipos[0].Cantidad; i++)
            {
                lListaLocal.Items.Add(equipos[0].VerJugadores(i).Nombre + "Nro: " + equipos[0].VerJugadores(i).Camiseta);
            }
            for (int i = 0; i < equipos[1].Cantidad; i++)
            {
                lListaVisitante.Items.Add(equipos[1].VerJugadores(i).Nombre + "Nro: " + equipos[1].VerJugadores(i).Camiseta);
            }
        }
    }
}
