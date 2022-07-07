using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Cedula.Modelos
{
    internal class Ciudadano
    {
        public string NombreUsuario { get; set; }
        public string Cedula { get; set; }

        public string LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Sangre { get; set; }
        public string EstadoCivil { get; set; }

        public string Ocupacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string PersonaImagenTexto { get; set; }
        public string FirmaImagenTexto { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime? FechaDeModificacion { get; set; }

    }
}
