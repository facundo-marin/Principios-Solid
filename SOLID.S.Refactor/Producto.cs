﻿namespace SOLID.S.Refactor
{
    public class Producto
    {
        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
