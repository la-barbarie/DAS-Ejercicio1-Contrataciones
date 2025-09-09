using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1.Controles
{
    public partial class Nacionalidad : UserControl
    {
        bool btnEditar;
        public Nacionalidad(bool editar)
        {
            btnEditar = editar;
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

            ActualizarControles();
        }

        private void ActualizarControles()
        {
            cmbIDNacionalidad.DataSource = new BLL.Nacionalidad().ListarPersonas();
            cmbIDNacionalidad.DisplayMember = "Nombre";
            cmbIDNacionalidad.ValueMember = "IdNacionalidad";
            cmbIDNacionalidad.SelectedIndex = -1;

            txbNombre.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextInfo ti = new CultureInfo("es-ES", false).TextInfo;
            string nombre = ti.ToTitleCase(txbNombre.Text);
            int fa;

            try
            {
                if (nombre.Length < 0) throw new Exception("El nombre está vacío");

                if (!btnEditar) fa = new BLL.Nacionalidad().InsertarNacionalidad(nombre);
                else
                {
                    if (cmbIDNacionalidad.SelectedValue == null) throw new Exception("La ID es inválida o no ha sido seleccionada");
                    int id = (int)cmbIDNacionalidad.SelectedValue;
                    fa = new BLL.Nacionalidad().EditarPersona(id, nombre);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            ActualizarControles();
        }
    }
}
