using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        List<string> listaPatentes = new List<string>() { "OXY333", "OYZ 013", "AAA 123", "BCD 456", "AB 123 CD", "YZ5432FF", "QW 3456 AB" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patente;
            if(rbRegex.Checked)
            {
                RegexPatentesProcesable rpp = new RegexPatentesProcesable();
                foreach(string p in listaPatentes) 
                {
                    rpp.Clasificar(p, out patente);
                    tbPatentes.Text += patente + "\n\r";
                }
                    
            }
            else if(rbString.Checked)
            {

            }
        }
    }
}
