using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacial_1._1.Models
{
    public class Envio
    {
        ArrayList costos = new ArrayList();

        public double ValorTotal
        {
            get
            {
                double total = 0;
                foreach (Costo cos in costos)//cos tomará el valor del siguiente elemento de la lista costos.
                {
                    total += cos.ValorFinal;//accedemos a la propiedad con "cos" y la acumulamos en "total"
                }
                return total;
            }
        }
        public string VerDetalle()
        {
            string date = $"";
            foreach(Costo cos in costos)//cos se va mover y me da los datos en cada posicion de "costos"
            {
                date += cos.VerDetalle();//voy a guardar en el string el detalle de cada costo.
            }
            return date;
        }
        public void AgregarCosto(Costo cos)//agrego un nuevo elemento a el ArrayList "costos".
        {
            costos.Add(cos);
        }
    }
}
