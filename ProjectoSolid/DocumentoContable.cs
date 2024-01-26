using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    public class DocumentoContable
    {
        public DocumentoContable(TipoDocumentoContable tipo, int numeroDocumento)
        {
            Tipo = tipo;
            NumeroDocumento = numeroDocumento;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int NumeroDocumento { get; set; }
        public TipoDocumentoContable Tipo { get; set; }

        public string Descripcion()
        {
            return Tipo switch
            {
                TipoDocumentoContable.Factura => $"Factura Nro: {NumeroDocumento}",
                TipoDocumentoContable.NotaCredito => $"Nota de Crédito Nro: {NumeroDocumento}",
                TipoDocumentoContable.NotaDebito => $"Nota de Débito Nro: {NumeroDocumento}",
                _ => "N/D",
            };
        }
    }
}
