using ComercioLB;
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

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        Comercio c;
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        string path = "Datos.bin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
            {
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    c = bf.Deserialize(fs) as Comercio;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                { fs.Close(); }
            }
            else
            {
                c = new Comercio();
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (cbNroCuenta.Checked && txtCtaCte.Text != "" && cbDNI.Text != "")
            {
                int nro = Convert.ToInt32(txtCtaCte.Text);
                CuentaCorriente cc = c.BuscarCuenta(nro);
                if (c != null)
                {
                    Pago p = new Pago(cc);
                    c.AgregarTicket(p);
                    lbxTurnos.Items.Add(p);
                }
                else
                {
                    MessageBox.Show("No se encontro la Cta Cte", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Cliente cli = null;
                try
                {
                    cli = new Cliente(cbDNI.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR! " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (cli != null)
                {
                    c.AgregarTicket(cli);
                    lbxTurnos.Items.Add(cli);
                }
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Ticket t = null;
            if (rbCompras.Checked)
            {
                t = c.AtenderTicket(0);
            }
            else if (rbPagos.Checked)
            {
                t =  c.AtenderTicket(1);
            }
            if (t != null) lbxTurnos.Items.Remove(t);
            else MessageBox.Show("No se pudo extraer el elemento");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    c.ExportarCSV(sw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { fs.Close(); }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string[] campos;
                    while (!sr.EndOfStream)
                    {
                        campos = sr.ReadLine().Split(';');
                        int nro = Convert.ToInt32(campos[0]);
                        string dni = campos[1];
                        double saldo = Convert.ToDouble(campos[2]);
                        Cliente cli = new Cliente(dni);
                        CuentaCorriente cc = new CuentaCorriente(nro, cli);
                        c.AgregarCuenta(cc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    sr.Close();
                    fs.Close(); 
                }
            }
        }
    }
}
