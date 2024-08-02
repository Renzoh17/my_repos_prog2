using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Empresa
    {
        //VARIABLES
        private double[] vehiculos;
        private double precioKM;
        private int cantidadViajes = 0;
        private bool ordenado = false;
        public int CantidadViajesTotales
        {
            get { return cantidadViajes; }
        }
        public double ComisionTotal { get; set; }
        private int cantidadUnidades;
        public int CantidadUnidades
        {
            get { return cantidadUnidades; }
            set { if (value < 1) cantidadUnidades = 5; else cantidadUnidades = value; }
        }

        //METODOS
        public Empresa(int unidades, double precioKM)
        {
            this.CantidadUnidades = unidades;
            this.precioKM = precioKM;
            vehiculos = new double[CantidadUnidades];
            for (int i = 0; i < vehiculos.Length; i++) vehiculos[i] = 0;
        }
        public double CargarViaje(int unidad, double distancia)
        {
            vehiculos[unidad - 1] += distancia;
            cantidadViajes++;
            return distancia * precioKM;
        }
        public double VerComisionUnidad(int unidad)
        {
            return vehiculos[unidad];
        }
        public double Comision(int unidad)
        {
            double precio;
            precio = vehiculos[unidad] * precioKM;
            return precio * 12 / 100;
        }
        private void Ordenar()
        {
            double aux;
            for (int i = 0; i < vehiculos.Length - 1; i++)
            {
                for (int j = i + 1; j < vehiculos.Length; j++)
                {
                    if (vehiculos[i] < vehiculos[j])
                    {
                        aux = vehiculos[i];
                        vehiculos[i] = vehiculos[j];
                        vehiculos[j] = aux;
                    }
                }
            }
            ordenado = true;
        }
        public double VerDistanciaRecorridas(int orden)
        {
            if(!ordenado) Ordenar();
            return vehiculos[orden];
        }
        public double Promedio()
        {
            double acum = 0;
            foreach (double distancia in vehiculos) acum += distancia;
            return acum / (double)CantidadUnidades;
        }
    }
}
