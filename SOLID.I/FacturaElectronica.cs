using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class FacturaElectronica : Documento
    {
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha)
        {
        }

        //CAE Codigo de Autorizacion Electronica
        public string CAE { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo por mail la factura electronica {Numero} de dia {Fecha.ToShortDateString()} con CAE {CAE}");
        }

        public override void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por mail la factura electrónica {Numero} de dia {Fecha.ToShortDateString()} con CAE {CAE}");
        }
    }
}
