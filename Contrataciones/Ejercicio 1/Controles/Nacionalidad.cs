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
            ActualizarControles();

            gbxGrupo.Text = editar ? "Modificar - Nacionalidad" : "Agregar - Nacionalidad";

            cmbIDNacionalidad.Enabled = cmbIDNacionalidad.Visible = editar;
            txbIDNacionalidad.Enabled = txbIDNacionalidad.Visible = !editar;

            btnAceptar.Text = editar ? "Modificar" : "Agregar";
            btnAceptar.Enabled = editar ? false : true;
            btnAceptar.Visible = true;

            btnEliminar.Enabled = false;
            btnEliminar.Visible = editar;

            if (editar) camposActivos(false);
        }

        private void ActualizarControles()
        {
            cmbIDNacionalidad.DataSource = new BLL.Nacionalidad().ListarNacionalidades();
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

                if (!btnEditar)
                {
                    fa = new BLL.Nacionalidad().InsertarNacionalidad(nombre);
                    ActualizarControles();
                }
                else
                {
                    if (cmbIDNacionalidad.SelectedValue == null) throw new Exception("La ID es inválida o no ha sido seleccionada");
                    int id = (int)cmbIDNacionalidad.SelectedValue;
                    fa = new BLL.Nacionalidad().EditarNacionalidad(id, nombre);
                    ActualizarControles();
                    cmbIDNacionalidad.SelectedItem = cmbIDNacionalidad.Items.Cast<BE.Nacionalidad>().FirstOrDefault(p => p.IdNacionalidad == id);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Nacionalidad p = (BE.Nacionalidad)cmbIDNacionalidad.SelectedItem;
                int fa = 0;
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar a {p.Nombre}? Esta acción no se puede deshacer", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK) fa = new BLL.Nacionalidad().RemoverNacionalidad(p.IdNacionalidad);
                else MessageBox.Show("Operación cancelada");

                if (fa != 0) MessageBox.Show($"Se ha eliminado a {p.Nombre}.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            ActualizarControles();
            camposActivos(false);
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void camposActivos(bool actuvo)
        {
            txbNombre.Enabled = actuvo;
        }

        private void cmbIDNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDNacionalidad.SelectedValue == null) return;

            BE.Nacionalidad p = (BE.Nacionalidad)cmbIDNacionalidad.SelectedItem;
            txbNombre.Text = p.Nombre;

            camposActivos(true);
            btnAceptar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
