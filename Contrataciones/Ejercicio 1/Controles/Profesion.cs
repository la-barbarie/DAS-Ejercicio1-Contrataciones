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
    public partial class Profesion : UserControl
    {
        public Profesion(bool editar)
        {
            InitializeComponent();

            if (editar)
            {
                gbxGrupo.Text = "Panel - Modificar";

                cmbIDProfesion.Enabled = true;
                cmbIDProfesion.Visible = true;

                nupIDProfesion.Enabled = false;
                nupIDProfesion.Visible = false;

                btnAceptar.Text = "Modificar";
            }
            else
            {
                gbxGrupo.Text = "Panel - Agregar";

                cmbIDProfesion.Enabled = false;
                cmbIDProfesion.Visible = false;

                nupIDProfesion.Enabled = true;
                nupIDProfesion.Visible = true;

                btnAceptar.Text = "Agregar";
            }
        }
    }
}
