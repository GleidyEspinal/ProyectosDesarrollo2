using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros_de_gastos.Modelos
{
    internal class Transaccion
    {
       public DateTime FechaDeRealizacion { get; set; }
       public string Categoria { get; set; }
       public string Concepto { get; set; }
       public int Monto { get; set; }
       public DateTime? FechaModificacion { get; set; }
       public int ID { get; set; }



    }
}
