using BE.dto;
using BE;
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
            cmbNac.DisplayMember = "Nombre";
            cmbProf.DataSource = new BLL.Profesion().ListarPersonas();
            cmbProf.DisplayMember = "Nombre";
            LimpiarFiltros();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                FiltrosDTO filtro = new FiltrosDTO();

                filtro.Nombre = txbNombre.Text != null ? txbNombre.Text : null;
                filtro.Apellido = txbApellido.Text;
                filtro.EdadMinima = (int)nupEdMin.Value;
                filtro.EdadMaxima = (int)nupEdMax.Value;
                switch (cmbSexo.Text)
                {
                    case "Femenino":
                        filtro.Sexo = false;
                        break;
                    case "Masculino":
                        filtro.Sexo = true;
                        break;
                    default:
                        filtro.Sexo = null;
                        break;
                }
                filtro.Nacionalidad = cmbNac.SelectedIndex != -1 ? ((BE.Nacionalidad)cmbNac.SelectedItem).IdNacionalidad : -1;
                filtro.Profesion = cmbProf.SelectedIndex != -1 ? ((BE.Profesion)cmbProf.SelectedItem).IdProfesion : -1;

                dgvDatos.DataSource = new BLL.Personas().ObtenerPersonasPorFiltros(filtro);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
        private void LimpiarFiltros()
        {
            foreach (TextBox tx in Controls.OfType<TextBox>()) tx.Text = "";
            foreach (ComboBox cm in Controls.OfType<ComboBox>()) cm.SelectedIndex = -1;
            nupEdMin.Value = 0;
            nupEdMax.Value = 100;
            dgvDatos.DataSource = new BLL.Personas().ObtenerPersonasPorFiltros(new FiltrosDTO());
        }
    }
}
