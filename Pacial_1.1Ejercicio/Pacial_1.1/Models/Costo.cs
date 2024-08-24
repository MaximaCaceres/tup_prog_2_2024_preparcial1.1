using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacial_1._1.Models
{
    public abstract class Costo
    {
        public string Concepto { get; private set; }
        public virtual double ValorFinal { get; protected set; }//solo puede ser accedido desde la clase y sus clases hijas.

        public Costo(string concepto)
        {
            Concepto = concepto;
        }
        public abstract string VerDetalle();
    }
}
