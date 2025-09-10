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
    public partial class Profesion : UserControl
    {
        bool btnEditar;
        public Profesion(bool editar)
        {
            btnEditar = editar;
            InitializeComponent();
            ActualizarControles();

            gbxGrupo.Text = editar ? "Modificar - Profesión" : "Agregar - Profesión";

            cmbIDProfesion.Enabled = cmbIDProfesion.Visible = editar;
            txbIDProfesion.Enabled = txbIDProfesion.Visible = !editar;

            btnAceptar.Text = editar ? "Modificar" : "Agregar";
            btnAceptar.Enabled = editar ? false : true;
            btnAceptar.Visible = true;

            btnEliminar.Enabled = false;
            btnEliminar.Visible = editar;

            if (editar) camposActivos(false);
        }

        private void camposActivos(bool activo)
        {
            txbNombre.Enabled = activo;
        }

        private void ActualizarControles()
        {
            cmbIDProfesion.DataSource = new BLL.Profesion().ListarProfesiones();
            cmbIDProfesion.DisplayMember = "Nombre";
            cmbIDProfesion.ValueMember = "IdProfesion";
            cmbIDProfesion.SelectedIndex = -1;

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
                    fa = new BLL.Profesion().InsertarProfesion(nombre);
                    ActualizarControles();
                }
                else
                {
                    if (cmbIDProfesion.SelectedValue == null) throw new Exception("La ID es inválida o no ha sido seleccionada");
                    int id = (int)cmbIDProfesion.SelectedValue;
                    fa = new BLL.Profesion().EditarProfesion(id, nombre);
                    ActualizarControles();
                    cmbIDProfesion.SelectedItem = cmbIDProfesion.Items.Cast<BE.Profesion>().FirstOrDefault(p => p.IdProfesion == id);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Profesion p = (BE.Profesion)cmbIDProfesion.SelectedItem;
                int fa = 0;
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar a {p.Nombre}? Esta acción no se puede deshacer", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK) fa = new BLL.Profesion().RemoverProfesion(p.IdProfesion);
                else MessageBox.Show("Operación cancelada");

                if (fa != 0) MessageBox.Show($"Se ha eliminado a {p.Nombre}.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            ActualizarControles();
            camposActivos(false);
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void cmbIDProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDProfesion.SelectedValue == null) return;

            BE.Profesion p = (BE.Profesion)cmbIDProfesion.SelectedItem;
            txbNombre.Text = p.Nombre;

            camposActivos(true);
            btnAceptar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
