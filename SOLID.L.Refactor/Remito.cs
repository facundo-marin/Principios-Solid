namespace SOLID.L.Refactor
{
    //Sacamos la herencia con Documento
    public class Remito
    {
        public Remito(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }
        public string Descripcion()
        {
            return $"Remito Nro: {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
    }
}
