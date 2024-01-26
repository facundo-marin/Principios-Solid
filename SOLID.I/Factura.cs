using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class Factura : Documento
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha) { }

        //CAI Codigo de Autorizacion de Impresion
        public string CAI { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} de dia {Fecha.ToShortDateString()} con CAI {CAI}");
           
        }

        public override void EnviarPorEmail()
        {
            //esta operacion no es valida para una factura
        }
    }
}
