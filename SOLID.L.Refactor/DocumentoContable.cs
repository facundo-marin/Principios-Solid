namespace SOLID.L.Refactor
{
    public abstract class DocumentoContable
    {
        protected string _sigla;

        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} Nro: {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
