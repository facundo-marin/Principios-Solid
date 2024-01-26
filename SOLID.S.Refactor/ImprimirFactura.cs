using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S.Refactor
{
    public class ImprimirFactura
    {
        public void Imprimir(Factura factura)
        {
            Console.WriteLine($"Factura #{factura.Numero}");
            Console.WriteLine($"Cliente: {factura.Cliente.Nombre} {factura.Cliente.Apellido}");
            Console.WriteLine("Items:");
            foreach (var item in factura.Items)
            {
                Console.WriteLine($"{item.Producto.Descripcion} - Cantidad: {item.Cantidad} - Precio: {item.Producto.Precio:C}");
            }
            Console.WriteLine($"Total: {factura.Total():C}");
        }
    }
}
