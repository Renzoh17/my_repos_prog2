using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace BeautyHair
{
    enum Tratamiento { Masaje, Depilacion, Peluqueria, Maquillaje}
    public partial class Form1 : Form
    {
        BeautyHair salon;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            salon = new BeautyHair(tbDireccion.Text, Convert.ToInt64(tbTelefono.Text));
            gbCrear.Enabled = false;
            gbControl.Enabled = true;
        }

        private void btnCrearGab_Click(object sender, EventArgs e)
        {
            try
            {
                salon.AgregarGabinete(Convert.ToInt32(tbNroGabinete.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "ERROR");
            }
            cbGabineteNro.Items.Clear();
            foreach(int nro in salon.NroGabinetes) cbGabineteNro.Items.Add(nro);
            tbNroGabinete.Clear();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = null;
            if (rbCliente.Checked)
            {
                try
                {
                    persona = new Cliente(tbNombre.Text, tbApellido.Text, tbDNI.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
            if (rbProfesional.Checked)
            {
                try
                {
                    persona = new Profesional(tbNombre.Text, tbApellido.Text, tbDNI.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
            salon.AgregarPersona(persona);
            tbNombre.Clear();
            tbApellido.Clear();
            tbDNI.Clear();
            if (!gbEliminarOModificar.Enabled && !gbMostrarCP.Enabled && !gbMostrarDisp.Enabled) 
            {
                gbMostrarDisp.Enabled = true;
                gbEliminarOModificar.Enabled = true;
                gbMostrarCP.Enabled = true;
            }
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            bool el = false;
            Persona p = null;
            try
            {
                p = salon[tbElimModPersona.Text];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            if (p != null)
            {
                FEliminar vtnElim = new FEliminar();
                vtnElim.lbEliminar.Items.Clear();
                vtnElim.lbEliminar.Items.AddRange(p.Mostrar());
                if (vtnElim.ShowDialog() == DialogResult.Yes)
                {
                    el = salon.EliminarPersona(p);
                }
                tbElimModPersona.Clear();
                string m = el ? "Se elimino correctamente" : "No se elimino el elemento seleccionado";
                MessageBox.Show(m);
                vtnElim.Dispose();
            }
            
        }

        private void btnMostrarCP_Click(object sender, EventArgs e)
        {
            lbMostrarCP.Items.Clear();
            List<Persona> p = salon.Personas;
            string m;
            if (cbClientes.Checked)
            {
                if (p.Count != 0) m = "Clientes:";
                else m = "La lista de clientes esta vacia";
                lbMostrarCP.Items.Add(m);
                foreach (Persona c in p)
                {
                    if (c is Cliente)
                    {
                        lbMostrarCP.Items.Add(c);
                    } 
                }
            }
            if (cbProfesionales.Checked)
            {
                if (p.Count != 0) m = "Profesionales:";
                else m = "La lista de profesionales esta vacia";
                lbMostrarCP.Items.Add(m);
                foreach (Persona pr in p)
                {
                    if (pr is Profesional)
                    {
                        lbMostrarCP.Items.Add(pr);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool el = false;
            Persona p = null;
            try
            {
                p = salon[tbElimModPersona.Text];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            el = salon.ModificarPersona(p);
            FModificar vtnMod = new FModificar();
            vtnMod.lbNom.Text += p.Nombre;
            vtnMod.lbApel.Text += p.Apellido;
            vtnMod.lbDNI.Text += p.Dni.ToString();
            if (vtnMod.ShowDialog() == DialogResult.OK)
            {
                Persona pm = new Cliente(vtnMod.tbNombre.Text, vtnMod.tbApellido.Text, "00000000");
                el = salon.ModificarPersona(pm);
            }
            tbElimModPersona.Clear();
            string m = el ? "Se modifico correctamente" : "No se modifico el elemento seleccionado";
            MessageBox.Show(m);
        }

        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
            salon.AsignarTurno(new Turno(dtpDiaDuracion.Value, (Tratamiento)cbTratamiento.SelectedItem, (Cliente)lbMostrarCP.SelectedItem, (Profesional)lbMostrarDisp.SelectedItem, new Gabinete(3)));
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNroGabinete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnMostrarDisp_Click(object sender, EventArgs e)
        {
            List<Persona> profesionales = salon.Personas;
            foreach (Persona p in profesionales)
            {
                if(p is Profesional) lbMostrarDisp.Items.Add(p);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "DatosSerializados.dat");
            if (File.Exists(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                salon = (BeautyHair)bf.Deserialize(archivo);
                gbMostrarCP.Enabled = true;
                gbMostrarDisp.Enabled = true;
                archivo.Close();
            } 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "DatosSerializados.dat");
            if (File.Exists(path)) File.Delete(path);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream archivo = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            bf.Serialize(archivo, salon);
            archivo.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ofd.Title = "Importación de cuentas";
            ofd.Filter = "fichero csv|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileStream flow = null;
                StreamReader lee = null;
                try
                {
                    flow = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                    lee = new StreamReader(flow);

                    string linea = lee.ReadLine();
                    string[] datosep;
                    Persona recibe;

                    while (!lee.EndOfStream)
                    {
                        linea = lee.ReadLine();
                        datosep = linea.Split(';');
                        if (datosep[0] == "c")
                        {
                            recibe = new Cliente(datosep[2], "", datosep[1]);
                            salon.AgregarPersona(recibe);
                            recibe.Direccion = datosep[3];
                            recibe.telefono = Convert.ToInt32(datosep[4]);
                        }
                        else if (datosep[0] == "p")
                        {
                            recibe = new Profesional(datosep[2], "", datosep[1]);
                            salon.AgregarPersona(recibe);
                            recibe.Direccion = datosep[3];
                            recibe.telefono = Convert.ToInt32(datosep[4]);
                        }

                    }
                    lee.Close();
                    flow.Close();
                    flow = new FileStream(path, FileMode.Open, FileAccess.Read);
                    lee = new StreamReader(flow);
                    List<Profesional> profesionalesTemp = new List<Profesional>();
                    List<Cliente> clientesTemp = new List<Cliente>();
                    List<Turno> turnosTemp = new List<Turno>();
                    while (!lee.EndOfStream)
                    {

                        string[] fields = lee.ReadLine().Split(';');

                        if (fields.Length > 0 && fields[0] == "t")
                        {
                            // Extraer datos del turno
                            int dniP = Convert.ToInt32(fields[1]);
                            int dniC = Convert.ToInt32(fields[2]);
                            string tratamiento = fields[3];
                            DateTime fechaHora = DateTime.Parse(fields[4]);
                            int gabineteId = int.Parse(fields[5]);

                            // Buscar el profesional y cliente por DNI
                            Profesional profesional = profesionalesTemp.FirstOrDefault(p => p.Dni == dniP);
                            Cliente cliente = clientesTemp.FirstOrDefault(c => c.Dni == dniC);

                            if (profesional != null && cliente != null)
                            {
                                // Crear y agregar el turno
                                Turno turno = new Turno(fechaHora, tratamiento, cliente, profesional, new Gabinete(gabineteId));
                                salon.AsignarTurno(turno);
                            }
                            else
                            {
                                MessageBox.Show($"No se encontró el profesional o cliente para el turno con DNI: Profesional({dniP}), Cliente({dniC})", "Error de importación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    lee.Close();
                    flow.Close();
                }
            }
        }
    }
}
