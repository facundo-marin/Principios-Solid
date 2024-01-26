using SOLID.D.Refactor.Interface;

namespace SOLID.D.Refactor
{
    //clase concreta
    public class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

        public int Legajo { get; set; }
        public double Total { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {Legajo} por un total de {Total}");
        }
    }
}
