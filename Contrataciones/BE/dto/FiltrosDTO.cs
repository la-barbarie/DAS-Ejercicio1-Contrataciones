using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.dto
{
    public class FiltrosDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public bool Sexo { get; set; }
        public int Nacionalidad { get; set; }
        public int Profesion { get; set; }
    }
}
