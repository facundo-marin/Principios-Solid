namespace SOLID.D.Refactor
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida {Partida} por un importe de {Importe}");

        }
    }
}
