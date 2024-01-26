using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Refactor
{
    public class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numeroDocumento) : base(numeroDocumento)
        {
        }

        public override string Descripcion()
        {
            return $"Nota de Débito Nro: {NumeroDocumento}";
        }
    }
}
