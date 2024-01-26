namespace SOLID.L.Refactor
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
           _sigla = "FC";
        }
    }
}
