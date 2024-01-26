using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Impresora
    {
        public void Imprimir(Factura factura)
        {
            Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.Fecha} por un importe de {factura.Importe}");
        }

        public void Imprimir(NotaCredito notaCredito)
        {
            Console.WriteLine($"Imprimiendo nota de credito {notaCredito.Numero} del {notaCredito.Fecha} por un importe de {notaCredito.Importe}");
        }

        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine($"Imprimiendo factura de luz con código de paga nro {facturaLuz.CodigoPago} por un importe de {facturaLuz.Importe}");
        }

        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida {municipal.Partida} por un importe de {municipal.Importe}");
        }

        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {reciboSueldo.Legajo} por un total de {reciboSueldo.Total}");
        }

        public void Imprimir(Impuesto impuesto)
        {
            Console.WriteLine($"Imprimiendo impuesto por un importe de {impuesto.Importe}");
        }
        
        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"Imprimiendo remito {remito.Numero} del {remito.Fecha} por {remito.CantBultos} bultos");
        }
    }
}
