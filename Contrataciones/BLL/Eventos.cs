using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Eventos
    {
        public delegate void delActualizarDatos();
        public event delActualizarDatos ActualizarDatos;
        public void InvocarActualizarDatos() => ActualizarDatos?.Invoke();
    }
}
