using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.dto
{
    public class PersonaFiltrada
    {
        public int NumeroPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public string Profesion { get; set; }
    }
}
