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
    public partial class Persona : UserControl
    {
        public Persona(bool editar)
        {
            InitializeComponent();

            if (editar)
            {
                gbxGrupo.Text = "Panel - Modificar";

                cmbNroPersona.Enabled = true;
                cmbNroPersona.Visible = true;

                txbNroPersona.Enabled = false;
                txbNroPersona.Visible = false;

                btnAceptar.Text = "Modificar";
            }
            else
            {
                gbxGrupo.Text = "Panel - Agregar";

                cmbNroPersona.Enabled = false;
                cmbNroPersona.Visible = false;

                txbNroPersona.Enabled = true;
                txbNroPersona.Visible = true;

                btnAceptar.Text = "Agregar";
            }
        }
    }
}
