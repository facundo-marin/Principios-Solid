using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    //tiene una lista de items con eso conseguimos la relacion muchos a muchos.
    //Factura tiene datos del cliente
    //Factura es la responsable de calcular el total
    //para mejorar se podria hacer que cada item sepa su subtotal.
    public class Factura
    {
        public Factura(int numero, string apellido, string nombre)
        {
            Numero = numero;
            Apellido = apellido;
            Nombre = nombre;
            Items = new List<Item>();
        }

        public int Numero { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public List<Item> Items { get; set; }

        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Cantidad * item.Producto.Precio;
            }

            return total;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Factura #{Numero}");
            Console.WriteLine($"Cliente: {Nombre} {Apellido}");
            Console.WriteLine("Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Producto.Descripcion} - Cantidad: {item.Cantidad} - Precio: {item.Producto.Precio:C}");
            }
            Console.WriteLine($"Total: {Total():C}");
        }
    }
}
