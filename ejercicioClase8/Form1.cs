using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioClase8
{
    public partial class Form1 : Form
    {
        FileStream archivo;
        StreamReader sr;
        StreamWriter sw;
        List<ItemFactura> facturaList = new List<ItemFactura>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.InitialDirectory = Application.StartupPath;
            abrir.Filter = "Archivos CSV (*.CSV) | *.CSV | Todos los archivos | *.*";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                archivo = new FileStream(abrir.FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);
                string[] campos;
                ItemFactura consumible;
                while(!sr.EndOfStream)
                {
                    campos = sr.ReadLine().Split(';');
                    if (campos[0].ToLower() == "s")
                    {
                        consumible = new Servicio(campos[2], Convert.ToInt32(campos[3]));
                        consumible.Precio = Convert.ToDouble(campos[4]);
                        consumible.Codigo = Convert.ToInt32(campos[1]);
                        facturaList.Add(consumible);
                        cBservicio.Items.Add(consumible);
                    }
                    else if (campos[0].ToLower() == "p")
                    {
                        consumible = new Producto(campos[1]);
                        ((Producto)consumible).Stock = Convert.ToInt32(campos[2]);
                        consumible.Precio = Convert.ToDouble(campos[3]);
                        consumible.Codigo = Convert.ToInt32(campos[1]);
                        facturaList.Add(consumible);
                        cBproducto.Items.Add(consumible);
                    }
                }
            }
        }
    }
}
