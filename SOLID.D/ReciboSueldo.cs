using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    //clase concreta
    public class ReciboSueldo
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

        public int Legajo { get; set; }
        public double Total { get; set; }
    }
}
