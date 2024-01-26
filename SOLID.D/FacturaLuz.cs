namespace SOLID.D
{
    public class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get; set; }
    }
}
