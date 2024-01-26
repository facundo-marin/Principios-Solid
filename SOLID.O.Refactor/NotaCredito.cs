using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Refactor
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numeroDocumento) : base(numeroDocumento)
        {
        }

        public override string Descripcion()
        {
            return $"Nota de Crédito Nro: {NumeroDocumento}";
        }
    }
}
