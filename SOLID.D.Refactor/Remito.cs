using SOLID.D.Refactor.Interface;

namespace SOLID.D.Refactor
{
    public class Remito : IImprimible
    {
        public Remito(int numero, DateTime fecha, int cantBultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantBultos = cantBultos;
        }
        public int Numero { get; set;}
        public DateTime Fecha { get; set;}
        public int CantBultos { get; set;}
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito {Numero} del {Fecha} por {CantBultos} bultos");

        }
    }
}
