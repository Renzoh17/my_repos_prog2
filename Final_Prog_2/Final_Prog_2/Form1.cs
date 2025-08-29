using Final_Prog_2.Models;
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

namespace Final_Prog_2
{
    public partial class Form1 : Form
    {
        GestionVentas gv;
        string path = "Persistencia.dat";
        List<Producto> listaux = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearEmp_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCuitEmp.Text);
            string rs = tbRSEmp.Text;
            gv = new GestionVentas(cuit, rs);
            gv.AgregarCliente(new ClienteCuenta("Martin", 20301001004, 15000));
            gv.AgregarCliente(new ClienteCuenta("Marta", 27031001031, 30000));
            gv.AgregarCliente(new ClienteCuenta("Juana", 27031002001, 70000));
            List<Producto> listaux = new List<Producto>();
            listaux.Add(new Clasico(1000, "Max Clasico"));
            listaux.Add(new Premium("Max Premium", 2000, 1000));
            listaux.Add(new Clasico(1500, "Cat Clasico"));
            listaux.Add(new Premium("Cat Premium", 3000, 1500));
            cbProductos.Items.Add(listaux[0]);
            cbProductos.Items.Add(listaux[1]);
            cbProductos.Items.Add(listaux[2]);
            cbProductos.Items.Add(listaux[3]);
            gv.lista.Add(listaux[0]);
            gv.lista.Add(listaux[1]);
            gv.lista.Add(listaux[2]);
            gv.lista.Add(listaux[3]);
            gbDatosEmp.Enabled = false;
            gbGestionV.Enabled = true;
            lbProductos.Items.Add($"{"Producto"}{"Peso",10}{"PrecioU",10}{"Precio",10}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                gv = bf.Deserialize(fs) as GestionVentas;
                fs.Close();
                gbGestionV.Enabled = true;
                foreach(Producto p in gv.lista) cbProductos.Items.Add(p);
                lbProductos.Items.Add($"{"Producto"}{"Peso",20}{"PrecioU",10}{"Precio",10}");
            }
            else MessageBox.Show("No se encontro el archivo de persistencia", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, gv);
            fs.Close();
        }

        private void btnCrearCli_Click(object sender, EventArgs e)
        {
            string nom = tbNombreCli.Text;
            long cuit = Convert.ToInt64(tbCuitCli.Text);
            double tope = Convert.ToDouble(tbTopeCli.Text);
            ClienteCuenta cc = new ClienteCuenta(nom, cuit, tope);
            gv.AgregarCliente(cc);
            tbCuitCli.Clear();
            tbTopeCli.Clear();
            tbNombreCli.Clear();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCuitPago.Text);
            double monto = Convert.ToDouble(tbMontoPago.Text);
            bool b = gv.AgregarPago(cuit, monto);
            if (b) MessageBox.Show("El pago se realizo con Exito.", "Pago efectuado", MessageBoxButtons.OK);
            else MessageBox.Show("No se pudo realizar el pago.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbCuitPago.Clear();
            tbMontoPago.Clear();
        }

        private void btnCargarProd_Click(object sender, EventArgs e)
        {
            Producto p = (Producto)cbProductos.SelectedItem;
            if (p != null)
            {
                if (p is Clasico pc)
                {
                    Clasico c = pc.Clone() as Clasico;
                    c.CantidadKilos = Convert.ToDouble(tbKilos.Text);
                    lbProductos.Items.Add(c.Descripcion());
                    listaux.Add(c);
                }
                else if (p is Premium pp)
                {
                    Premium ppp = pp.Clone() as Premium;
                    ppp.CantidadKilos = Convert.ToDouble(tbKilos.Text);
                    lbProductos.Items.Add(ppp.Descripcion());
                    listaux.Add(ppp);
                }
            }
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbCuitCompra.Text);
            Pedido p = gv.GenerarPedido(listaux);
            ClienteCuenta cc = new ClienteCuenta("", cuit, 0);
            bool b = gv.SumarPedido(cc, p);
            if (b)
            {
                try
                {
                    gv.AgregarCompra(cuit, p.Valor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MostrarPedido vtnMP = new MostrarPedido();
                p.Detalle += $@"{"Producto"}{"Peso",20}{"PrecioU",10}{"Precio",10}
";
                foreach (Producto prod in listaux)
                {
                    p.Detalle += $@"{prod.Descripcion()}
";
                }
                p.Detalle += $@"
{"Total:"}{p.Valor,30:f2}";
                listaux.Clear();
                vtnMP.tbResumenPed.Text = p.Detalle;
                vtnMP.ShowDialog();
                lbProductos.Items.Clear();
                lbProductos.Items.Add($"{"Producto"}{"Peso",20}{"PrecioU",10}{"Precio",10}");
            }
            else
            {
                MessageBox.Show("No se pudo generar el pedido solicitado.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportarCueCli_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("nombre;cuit;saldo");
                sw.WriteLine("numero;fecha;detalle;valor");
                foreach (ClienteCuenta c in gv.listaClientes)
                {
                    sw.WriteLine(c.Escribir());
                    foreach (Pedido p in c.listaPedidos)
                    {
                        sw.WriteLine(p.Escribir());
                    }
                }
                sw.Close();
                fs.Close();
            }
        }

        private void btnImportarProd_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                string[] datos;
                string tipo;
                Producto p = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        linea = sr.ReadLine();
                        datos = linea.Split(';');
                        tipo = datos[3];
                        if (tipo == "C")
                        {
                            p = new Clasico();
                            ((Clasico)p).Leer(linea);
                        }
                        else if (tipo == "P")
                        {
                            p = new Premium();
                            ((Premium)p).Leer(linea);
                        }
                        if (p != null)
                        {
                            gv.lista.Add(p);
                            cbProductos.Items.Add(p);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(sr != null) sr.Close();
                    if(fs != null) fs.Close();
                }
            }
        }
    }
}
