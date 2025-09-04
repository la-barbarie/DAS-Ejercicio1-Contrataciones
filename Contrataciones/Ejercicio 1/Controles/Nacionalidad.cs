using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1.Controles
{
    public partial class Nacionalidad : UserControl
    {
        public Nacionalidad(bool editar)
        {
            InitializeComponent();

            if (editar)
            {
                gbxGrupo.Text = "Panel - Modificar";

                cmbIDNacionalidad.Enabled = true;
                cmbIDNacionalidad.Visible = true;

                nupIDNacionalidad.Enabled = false;
                nupIDNacionalidad.Visible = false;

                btnAceptar.Text = "Modificar";
            }
            else
            {
                gbxGrupo.Text = "Panel - Agregar";

                cmbIDNacionalidad.Enabled = false;
                cmbIDNacionalidad.Visible = false;

                nupIDNacionalidad.Enabled = true;
                nupIDNacionalidad.Visible = true;

                btnAceptar.Text = "Agregar";
            }
        }
    }
}
