using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito : Documento
    {
        public Remito(int numero, DateTime fecha, int bultos) : base(numero, fecha)
        {
            CantBultos = bultos;
        }

        public int CantBultos { get; set; }

        //En este caso se esta violando el principio liskov porque se esta cambiando el comportamiento de la clase padre.
        //las clases derivas no deberian cambiar el comportamiento de la clase padre.
        public override string Descripcion()
        {
            return $"Remito Nro: {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
    }
}
