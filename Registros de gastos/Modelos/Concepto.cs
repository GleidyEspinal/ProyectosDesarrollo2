using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros_de_gastos.Modelos
{
    public class Concepto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Visibilidad { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime? FechaDeModificacion { get; set; }

    }
}
