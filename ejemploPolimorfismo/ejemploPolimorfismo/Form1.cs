using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ejemploPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Animal> listaAnimales = new List<Animal>();
        List<Auto> listaAutos = new List<Auto>();
        List<IGuardable> listaG = new List<IGuardable>();
        FileStream archivo;
        StreamReader sr;
        StreamWriter sw;

        private void button1_Click(object sender, EventArgs e)
        {
            //listaAnimales.Add(new Perro("Toby", new DateTime(2010, 09, 04), "medio"));
            //listaAnimales.Add(new Perro("Sultan", new DateTime(2015, 12, 22), "fuerte"));
            //listaAnimales.Add(new Gato("Manchitas", new DateTime(2018, 05, 23), "bajo"));
            //listaAutos.Add(new Auto("Zafira", 2009));
            //listaAutos.Add(new Auto("F600", 1971));
            //listaAutos.Add(new Auto("FordK", 2025));
            foreach (Animal a in listaAnimales)
            {
                a.Edad(DateTime.Now);
                listaG.Add(a);
            }
            foreach (Auto a in listaAutos) listaG.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal.OrdenarPor(1);
            listaAnimales.Sort();
            listBox1.Items.Clear();
            foreach (Animal a in listaAnimales)
            {
                {
                    listBox1.Items.Add(a.Datos());
                    listBox1.Items.Add("Edad: " + a.Edad(DateTime.Today));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Animal buscar = new Gato(textBox1.Text, DateTime.Now, "");
                Animal.OrdenarPor(0);
                listaAnimales.Sort();
                int idx = listaAnimales.BinarySearch(buscar);
                listBox1.Items.Clear();
                if (idx >= 0)
                {
                    listBox1.Items.Add(listaAnimales[idx].Datos());
                    listBox1.Items.Add("Edad: " + listaAnimales[idx].edadDelAnimal);
                }
                else listBox1.Items.Add("No encontrado");
            }
            else
            {
                MessageBox.Show("Ingrese un nombre a buscar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV (*.CSV) | *.CSV |Archivo Binario (*.BIN) | *.bin |Todos los archivos | *.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                archivo = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                if (checkBox1.Checked)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(archivo, listaG);
                }
                else
                {
                    sw = new StreamWriter(archivo);
                    foreach (IGuardable g in listaG) sw.WriteLine(g.LineaCSV());
                    sw.Close();
                }
                archivo.Close();
            }
            else
            {
                MessageBox.Show("Se cancelo el guardado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sfd.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo CSV (*.CSV) | *.CSV |Archivo Binario (*.BIN) | *.bin |Todos los archivos | *.*";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                string[] datos;
                datos = ofd.FileName.Split('.');
                if (datos[1].ToUpper() == "CSV")
                {
                    sr = new StreamReader(archivo);
                    string g;
                    while (!sr.EndOfStream)
                    {
                        datos = sr.ReadLine().Split(';');
                        if (datos[0] == "Gato")
                        {
                            g = datos[3].Split(' ')[1];
                            listaAnimales.Add(new Gato(datos[1], Convert.ToDateTime(datos[2]), g));
                        }
                        else if (datos[0] == "Perro")
                        {
                            g = datos[3].Split(' ')[1];
                            listaAnimales.Add(new Perro(datos[1], Convert.ToDateTime(datos[2]), g));
                        }
                        else if (datos[0] == "Auto")
                        {
                            listaAutos.Add(new Auto(datos[1], Convert.ToInt32(datos[2])));
                        }
                    }
                    sr.Close();
                }
                else if (datos[1] == "bin")
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    listaG = (List<IGuardable>)bf.Deserialize(archivo);
                    foreach(IGuardable gu in listaG)
                    {
                        if (gu is Animal) listaAnimales.Add((Animal)gu);
                        else if(gu is Auto) listaAutos.Add((Auto)gu);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de Archivo incorrecto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                archivo.Close();
            }
            else
            {
                MessageBox.Show("El archivo no se pudo abrir", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ofd.Dispose();
        }
    }
}
