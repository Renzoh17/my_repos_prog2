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
            int cantJug = 0;
            int i = 0;
            if (tbxCantJug.Text != "") cantJug = Convert.ToInt32(tbxCantJug.Text);
            if (cantJug >= 7 && cantJug <= 15)
            {
                AgregarJugadores vtnAgregar = new AgregarJugadores();
                while (i < cantJug)
                {
                    if(vtnAgregar.ShowDialog() == DialogResult.OK)
                    {
                        if (rbLocal.Checked) equipos[0].AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text.ToString(), Convert.ToInt32(vtnAgregar.tbxNroCamiseta.Text)));
                        else if (rbVisitante.Checked) equipos[1].AgregarJugador(new Jugador(vtnAgregar.tbxNombre.Text, Convert.ToInt32(vtnAgregar.tbxNroCamiseta.Text)));
                        else MessageBox.Show("ERROR! Seleccione un equipo");
                        vtnAgregar.tbxNombre.Clear();
                        vtnAgregar.tbxNroCamiseta.Clear();
                        i++;
                    }
                    else
                    {
                        i = 20; //Sale del rango para cancelar la carga
                    }
                }
                tbxCantJug.Clear();
                vtnAgregar.Dispose();
            }
            else MessageBox.Show("ERROR! Ingrese la cantidad de jugadores correctamente.");
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Puntuacion vtnpts = new Puntuacion();
            partido = new Partido(new Cancha(tbNombre.Text, tbUbicacion.Text, Convert.ToInt32(tbCantidad.Text)));
            tbNombre.Clear();
            tbUbicacion.Clear();
            tbCantidad.Clear();
            partido.AgregarEquipo(equipos);
            vtnpts.lbPtsLocal.Text = $"Local: {equipos[0].Puntos}";
            vtnpts.lbPtsVisitante.Text = $"Visitante: {equipos[1].Puntos}";
            while (vtnpts.ShowDialog() == DialogResult.Yes)
            {
                if (vtnpts.rbPtsLocal.Checked) equipos[0].AgregarPuntos(Convert.ToInt32(vtnpts.tbNroCamiseta.Text), Convert.ToInt32(vtnpts.tbPtsCanasta.Text));
                else if (vtnpts.rbPtsVisitante.Checked) equipos[1].AgregarPuntos(Convert.ToInt32(vtnpts.tbNroCamiseta.Text), Convert.ToInt32(vtnpts.tbPtsCanasta.Text));
                else MessageBox.Show("ERROR! Seleccione un Equipo");
                vtnpts.tbNroCamiseta.Clear();
                vtnpts.tbPtsCanasta.Clear();
                vtnpts.lbPtsLocal.Text = $"Local: {equipos[0].Puntos}";
                vtnpts.lbPtsVisitante.Text = $"Visitante: {equipos[1].Puntos}";
            }
            if(equipos[0].Puntos == equipos[1].Puntos) MessageBox.Show("Los equipos empataron");
            else if (equipos[0].Puntos > equipos[1].Puntos) MessageBox.Show("El Equipo Local Gano");
            else MessageBox.Show("El Equipo Visitante Gano");
            vtnpts.Dispose();
            lListaLocal.Items.Clear();
            lListaVisitante.Items.Clear();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            lListaLocal.Items.Clear();
            lListaVisitante.Items.Clear();
            for (int i = 0; i < equipos[0].Cantidad; i++)
            {
                lListaLocal.Items.Add(equipos[0].VerJugadores(i).Nombre + " Nro Camiseta: " + equipos[0].VerJugadores(i).Camiseta);
            }
            for (int i = 0; i < equipos[1].Cantidad; i++)
            {
                lListaVisitante.Items.Add(equipos[1].VerJugadores(i).Nombre + " Nro Camiseta: " + equipos[1].VerJugadores(i).Camiseta);
            }
        }
    }
}
