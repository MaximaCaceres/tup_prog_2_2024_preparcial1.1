using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacial_1._1.Models
{
    public class Fijo:Costo
    {
        public Fijo(string concepto,double valorFinal):base(concepto)
        {
            base.ValorFinal = ValorFinal;
        }
        public override string VerDetalle()
        {
            string date = $"{Concepto} {ValorFinal}\r\n";
            return date;
        }
    }
}
