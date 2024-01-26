using SOLID.D.Refactor.Interface;

namespace SOLID.D.Refactor
{
    public abstract class DocumentoContable : IImprimible
    {
        protected string _sigla;

        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public double Importe { get; set; }
        public abstract double Total();
        public abstract void Imprimir();
    }
}
