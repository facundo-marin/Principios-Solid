using SOLID.D.Refactor.Interface;

namespace SOLID.D.Refactor
{
    public class Impresora
    {
        public void Imprimir(IImprimible imprimible)
        {
            imprimible.Imprimir();
        }
    }
}
