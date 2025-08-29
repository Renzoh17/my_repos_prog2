using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal class Estancia
    {
        public string Nombre {  get; set; }
        public int CantidadCampos {
            get
            {
                return campos.Count;
            } 
        }

        private ArrayList campos = new ArrayList();
        public Casco Casco { get; set; }

        Puesto[] puestos = new Puesto[100];
        public int CantidadPuestos { get; private set; } = 0;
        List<Actividad> actividades = new List<Actividad>();

        public Estancia(string nombreEstancia, string idCampo1, double supCampo1)
        {
            Nombre = nombreEstancia;
            campos.Add(new Campo(idCampo1, supCampo1));
            Casco c = new Casco();
            c.Administrador = "No designado";
            AgregarPuesto("No designado");
        }

        public bool AltaActividad(Actividad a)
        {
            actividades.Add(a);
            return true;
        }

        public Campo AgregarCampo(string identificador, double superficie)
        {
            Campo c = new Campo(identificador, superficie);
            campos.Add(c);
            return c;
        }

        public Campo VerCampo(int idx)
        {
            return idx >= 0 && idx < CantidadCampos ? (Campo)campos[idx] : null;
        }

        public void AgregarPuesto(string encargado)
        {
            Puesto puesto = new Puesto();
            puesto.Encargado = encargado;
            puestos[CantidadPuestos] = puesto;
            CantidadPuestos++;
        }

        public Puesto VerPuesto(int idx)
        {
            return idx >= 0 && idx < CantidadPuestos ? puestos[idx] : null;
        }
    }
}
