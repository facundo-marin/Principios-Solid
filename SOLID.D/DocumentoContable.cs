namespace SOLID.D
{
    public abstract class DocumentoContable
    {
        protected string _sigla;

        protected DocumentoContable(int numero, DateTime fecha, double importe)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public double Importe { get; set; }
        public abstract double Total();
    }
}
