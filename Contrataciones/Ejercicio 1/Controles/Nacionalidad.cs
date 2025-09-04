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

                txbIDNacionalidad.Enabled = false;
                txbIDNacionalidad.Visible = false;

                btnAceptar.Text = "Modificar";
            }
            else
            {
                gbxGrupo.Text = "Panel - Agregar";

                cmbIDNacionalidad.Enabled = false;
                cmbIDNacionalidad.Visible = false;

                txbIDNacionalidad.Enabled = true;
                txbIDNacionalidad.Visible = true;

                btnAceptar.Text = "Agregar";
            }
        }
    }
}
