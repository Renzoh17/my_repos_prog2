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

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        FileStream archivo;
        StreamReader sr;
        StreamWriter wr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            dir += "\\" + tbCrear.Text;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {
                string[] archivos = Directory.GetFiles(dir);
                if (archivos.Length == 0) Directory.Delete(dir);
                else
                {
                    foreach (string d in archivos) File.Delete(d);
                    Directory.Delete(dir);
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.InitialDirectory = Application.StartupPath;
            abrirArchivo.Filter = "Archivos de texto (*.TXT/*.DOC) | *.txt;*.do* | Todos los archivos | *.*";
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                archivo = new FileStream(abrirArchivo.FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);
                int linea = 0;
                while (!sr.EndOfStream) listBox1.Items.Add(linea++.ToString("000") + " - " +sr.ReadLine());
                sr.Close();
                archivo.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.InitialDirectory = Application.StartupPath;
            guardarArchivo.Filter = "Archivo de Texto (*.TXT) | *.txt";
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                archivo = new FileStream(guardarArchivo.FileName, FileMode.Create, FileAccess.Write);
                wr = new StreamWriter(archivo);
                foreach(string s in listBox1.Items) wr.WriteLine(s);
                wr.Close();
                archivo.Close();
            }
            
        }
    }
}
