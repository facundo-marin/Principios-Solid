using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Refactor
{
    public class Factura : DocumentoContable
    {
        public Factura(int numeroDocumento) : base(numeroDocumento) { }

        public override string Descripcion()
        {
            return $"Factura Nro: {NumeroDocumento}";
        }
    }
}
