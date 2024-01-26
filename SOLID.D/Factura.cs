namespace SOLID.D
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
           _sigla = "FC";
        }

        public override double Total()
        {
           return Importe * 1.21;
        }
    }
}
