namespace SOLID.I.Refactor
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
    }
}
