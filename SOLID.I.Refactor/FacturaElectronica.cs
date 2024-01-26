using SOLID.I.Refactor.Interface;

namespace SOLID.I.Refactor
{
    public class FacturaElectronica : Documento, IImaileable
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

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por mail la factura electronica {Numero} de dia {Fecha.ToShortDateString()} con CAE {CAE}");
        }
    }
}
