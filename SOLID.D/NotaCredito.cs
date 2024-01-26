namespace SOLID.D
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "NC";
        }

        public override double Total()
        {
            return Importe * 1.21 * -1; // Ejemplo para direnciar y que de negativo.
        }
    }
}
