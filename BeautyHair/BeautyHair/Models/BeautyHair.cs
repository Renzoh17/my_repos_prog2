using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyHair
{
    [Serializable]
    internal class BeautyHair
    {
        private List<Gabinete> gabinetes = new List<Gabinete>(4);
        private List<Persona> personas = new List<Persona>(4);
        private List<Cliente> clientes = new List<Cliente>(4);
        private List<Profesional> profesionales = new List<Profesional>(4);
        private List<Turno> turnos = new List<Turno>(10);
        public List<Persona> Personas { 
            get 
            {
                List<Persona> p = new List<Persona>();
                foreach (Persona persona in personas) p.Add(persona);
                return p;
            } 
        }
        public List<int> NroGabinetes { 
            get 
            {
                List<int> nrosG = new List<int>();
                foreach(Gabinete g in gabinetes) nrosG.Add(g.NroGabinete);
                return nrosG;
            } 
        }
        public Persona this[string dni]
        {
            get
            {
                int DNI;
                bool b = ComprobarDNI(dni, out DNI);
                return b ? Buscar(DNI) : null;
            }
        }

        private string direccion;
        private long telefono;

        public BeautyHair(string dir, long tel)
        {
            direccion = dir;
            telefono = tel;
        }

        public void AgregarGabinete(int num)
        {
            Gabinete g = new Gabinete(num);
            gabinetes.Sort();
            int idx = gabinetes.BinarySearch(g);
            if (idx >= 0)
            {
                throw new MyException("El gabinete ya existe");
            }
            else
            {
                gabinetes.Add(new Gabinete(num));
            }
            
        }
        public void AgregarPersona(Persona persona)
        {
            if(persona is Cliente)
            {
                clientes.Add((Cliente)persona);
            }
            else if (persona is Profesional)
            {
                profesionales.Add((Profesional)persona);
            }
        }
        public bool EliminarPersona(Persona persona)
        {
            bool e = false;
            if(persona != null) e = personas.Remove(persona);
            return e;
        }

        public bool ModificarPersona(Persona persona)
        {
            bool mod = false;
            if (persona != null) 
            {
                persona.Modificar(persona.Nombre, persona.Apellido);
                mod = true;
            }            
            return mod;
        }
        public void AsignarTurno(Turno turno)
        {
            Turno t = turno;
            
        }
        
        Persona Buscar(int dni)
        {
            Persona p = new Cliente("", "", dni.ToString()); 
            personas.Sort();
            int idx = personas.BinarySearch(p);
            p = idx >= 0 ? personas[idx] : null;
            return p;
        }

        bool ComprobarDNI(string dni, out int DNI)
        {
            bool e = false;
            string pattern = @"\d{8}";
            Match m = Regex.Match(dni, pattern);
            if (m.Success)
            {
                DNI = Convert.ToInt32(m.Groups[0].Value);
                e = true;
            }
            else
            {
                DNI = 0;
                throw new MyException("Dni con tamaño o formato incorrecto");
            }
            return e;
        }
        //bool SeSolapan(Turno turnoExistente, Turno nuevoTurno)
        //{
        //    DateTime inicioExistente = turnoExistente.FechaHoraInicio;
        //    DateTime finExistente = turnoExistente.FechaHoraInicio.Add(turnoExistente.Duracion);

        //    DateTime inicioNuevo = nuevoTurno.FechaHoraInicio;
        //    DateTime finNuevo = nuevoTurno.FechaHoraInicio.Add(nuevoTurno.Duracion);

        //    // Retorna true si hay solapamiento
        //    return inicioExistente < finNuevo && inicioNuevo < finExistente;
        //}

        //public bool VerificarDisponibilidad(Turno nuevoTurno)
        //{
        //    foreach (var turnoExistente in turnos)
        //    {
        //        if (SeSolapan(turnoExistente, nuevoTurno))
        //        {
        //            return false; // Hay conflicto de tiempo
        //        }
        //    }
        //    return true; // No hay conflicto
        //}

        //public bool ValidarTurno(Turno nuevoTurno)
        //{
        //    List<Profesional> ps = new List<Profesional>();
        //    foreach(Persona p in personas)
        //    {
        //        if (p is Profesional) ps.Add((Profesional)p);
        //    }
        //    foreach (Profesional pr in ps)
        //    {
        //        if (!nuevoTurno.Profesional.Agenda.VerificarDisponibilidad(nuevoTurno))
        //        {
        //            return false; // El profesional ya tiene un turno en ese horario
        //        }
        //    }
        //    // Verificar la disponibilidad del profesional
            

        //    // Verificar la disponibilidad del gabinete
        //    if (!nuevoTurno.Gabinete.Agenda.VerificarDisponibilidad(nuevoTurno))
        //    {
        //        return false; // El gabinete ya tiene un turno en ese horario
        //    }

        //    // Verificar que el cliente no tenga otro turno a la misma hora
        //    foreach (var turno in nuevoTurno.Cliente.Agenda.Turnos)
        //    {
        //        if (SeSolapan(turno, nuevoTurno))
        //        {
        //            return false; // El cliente ya tiene un tratamiento en ese horario
        //        }
        //    }

        //    // Si todas las validaciones pasaron, el turno es válido
        //    return true;
        //}
    }
}
