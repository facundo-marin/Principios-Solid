using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class Impuesto
    {
        public Impuesto(double importe)
        {
            Importe = importe;
        }

        public double Importe { get; set; }
    }
}
