namespace SOLID.L.Refactor
{
    public class Impresora
    {
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.Imprimir());
        }

        
        public void Imprimir(DocumentoContable documento)
        {
            Console.WriteLine(documento.Imprimir());
        }
    }
}
