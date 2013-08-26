using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad2_MateriaPrima
{
    public class Salida
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
        public string ProyectoDestino { get; set; }

        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }


        public Salida(string nombre, int cantidad, decimal precioU, string proyecto, decimal total)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precioU;
            ProyectoDestino = proyecto;
            Total = total;
        }

        public Salida()
        { }
    }
}
