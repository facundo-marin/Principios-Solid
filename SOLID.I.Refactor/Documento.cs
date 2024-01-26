using SOLID.I.Refactor.Interface;

namespace SOLID.I.Refactor
{
    public abstract class Documento : IImprimble
    {
        public Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public abstract void Imprimir();
    }
}
