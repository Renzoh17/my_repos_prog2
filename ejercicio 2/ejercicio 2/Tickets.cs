using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class Tickets:IComparable 
    {
        DateTime fecha;
        Persona pasajero;
        Transporte pasaje;
        public double PrecioF {  get; set; }
        public Tickets(string nombre, string cuit, long telefono)
        {
            fecha = DateTime.Now;
            try
            {
                int cuitN = Convert.ToInt32(cuit);
                pasajero = new Persona(nombre, cuitN);
                pasajero.Telefono = telefono;
            } 
            catch (FormatException fe)
            {
                throw new InvalidoException("Error de tipo", fe);
            }
            
        }
        public void AgregarTransporte(Transporte unTransporte)
        {
            pasaje = unTransporte;
        }
        public string[] Datos()
        {
            string[] datos = new string[5];
            datos[0] = $"Fecha: {fecha.ToString("d")}";
            datos[1] = $"Destino: {pasaje.Destino}";
            datos[2] = $"Precio: {PrecioF.ToString("$0.00")}";
            datos[3] = $"Tipo de Transporte: {pasaje}";
            datos[4] = $"{pasajero.VerDatos()}";
            return datos;
        }

       
       public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Tickets otro = (Tickets)obj;
            return pasaje.Destino.CompareTo(otro.pasaje.Destino);
        }

    }
}
