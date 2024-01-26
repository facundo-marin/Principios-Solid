namespace SOLID.O.Refactor
{
    //En este caso nunca podriamos instanciar un documento contable sin saber de que tipo es.
    public abstract class DocumentoContable
    {
        protected DocumentoContable(int numeroDocumento)
        {
            NumeroDocumento = numeroDocumento;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int NumeroDocumento { get; set; }

        //hacemos abstracta la descripcion para que cada tipo de documento la implemente.
        public abstract string Descripcion();

    }
}
