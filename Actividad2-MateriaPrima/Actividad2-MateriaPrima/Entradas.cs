using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad2_MateriaPrima
{
    public class Entradas
    {
        public string Nombre { get; set; }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set 
            {
                cantidad = value;                 
            }
        }
        private decimal precioUnitario;

        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set 
            {
                precioUnitario = value; 
            }
        }
        //public string ProyectoDestino { get; set; }

        public Entradas(string nombre, int cantidad, decimal precioU)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precioU;
        }

        public Entradas()
        { }
    }
}
