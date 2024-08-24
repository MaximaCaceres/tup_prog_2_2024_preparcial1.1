using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacial_1._1.Models
{
    public class Variable:Costo
    {
        public double PrecioPorUnidad { get; set; }
        public double Unidades { get; set; }
        public override double ValorFinal
        {
            get { return PrecioPorUnidad * Unidades; } 
        }
        public Variable(string concepto, double unid, double PxU):base(concepto)
        {
            Unidades = unid;
            PrecioPorUnidad = PxU;
        }
        public override string VerDetalle()
        {
            string date = $"{Concepto} {PrecioPorUnidad} {Unidades}\r\n";
            return date;
        }
    }
}
