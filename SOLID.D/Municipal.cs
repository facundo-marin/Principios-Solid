namespace SOLID.D
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }
    }
}
