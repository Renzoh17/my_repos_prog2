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

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        Comercio comercio1;
        FileStream archivo;
        StreamReader sr;
        StreamWriter sw;
        string path = Path.Combine(Application.StartupPath, "Datos.bin");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (cbNroCtaCte.Checked && txtCtacte.Text != "" && tbDNI.Text != "")
            {
                int nro = Convert.ToInt32(txtCtacte.Text);
                Cliente c = null;
                try
                {
                    c = new Cliente(tbDNI.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CuentaCorriente cc = comercio1.BuscarCuenta(nro);
                if (cc != null)
                {
                    Pago p = new Pago(cc);
                    comercio1.AgregarTicket(p);
                    lbxTurnos.Items.Add(p);
                }
                else
                {
                    MessageBox.Show("No se encontro la Cta Cte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Cliente c = null;
                try
                {
                    c = new Cliente(tbDNI.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comercio1.AgregarTicket(c);
                lbxTurnos.Items.Add(c);
            }
        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            Ticket t = null;
            if (rbCompras.Checked)
            {
                t = comercio1.AtenderTicket(tipoTicket.Cliente);
            }
            else if(rbPagos.Checked)
            {
                t = comercio1.AtenderTicket(tipoTicket.Pago);
            }
            if (t != null)
            {
                lbxTurnos.Items.Remove(t);
            }
            else
            {
                MessageBox.Show("Lista Vacia!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
            {
                archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                comercio1 = bf.Deserialize(archivo) as Comercio;
                archivo.Close();
            }
            else
            {
                MessageBox.Show("No se encontro el archivo de persistencia 'Datos.bin'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comercio1 = new Comercio();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            archivo = new FileStream(path, FileMode.Create, FileAccess.Write);
            bf.Serialize(archivo, comercio1);
            archivo.Close();
        }

        private void btnImportarCtasCtes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Archivo CSV (*.CSV) |*.CSV|Todos los Archivos |*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string p = ofd.FileName;
                archivo = new FileStream(p, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);
                string[] campos;
                while (!sr.EndOfStream)
                {
                    campos = sr.ReadLine().Split(';');
                    int nro = Convert.ToInt32(campos[0]);
                    Cliente c = new Cliente(campos[1]);
                    double saldo = Convert.ToDouble(campos[2]);
                    CuentaCorriente cc = new CuentaCorriente(nro, c);
                    cc.RegistrarPago(saldo);
                    comercio1.AgregarCuenta(cc);
                }
                sr.Close();
                archivo.Close();
            }
        }

        private void btnExportarTickets_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Archivo CSV (*.CSV) |*.CSV";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                archivo = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(archivo);
                comercio1.ExportarCSV(sw);
                sw.Close();
                archivo.Close();
            }
        }
    }
}
