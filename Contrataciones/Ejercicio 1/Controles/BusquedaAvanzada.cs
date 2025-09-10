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
    public partial class BusquedaAvanzada : Form
    {
        public BusquedaAvanzada()
        {
            InitializeComponent();

            cmbNac.DataSource = new BLL.Nacionalidad().ListarPersonas();
            cmbProf.DataSource = new BLL.Profesion().ListarPersonas();

            foreach (ComboBox cm in Controls.OfType<ComboBox>()) cm.SelectedIndex = -1;
        }

        private void ActualizarInfo(object sender, EventArgs e)
        {

        }
    }
}
