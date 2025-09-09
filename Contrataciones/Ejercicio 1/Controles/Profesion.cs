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

            if (editar)
            {
                gbxGrupo.Text = "Panel - Modificar";

                cmbIDProfesion.Enabled = true;
                cmbIDProfesion.Visible = true;

                txbIDProfesion.Enabled = false;
                txbIDProfesion.Visible = false;

                btnAceptar.Text = "Modificar";
            }
            else
            {
                gbxGrupo.Text = "Panel - Agregar";

                cmbIDProfesion.Enabled = false;
                cmbIDProfesion.Visible = false;

                txbIDProfesion.Enabled = true;
                txbIDProfesion.Visible = true;

                btnAceptar.Text = "Agregar";
            }

            ActualizarControles();
        }

        private void ActualizarControles()
        {
            cmbIDProfesion.DataSource = new BLL.Profesion().ListarPersonas();
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

                if (!btnEditar) fa = new BLL.Profesion().InsertarProfesion(nombre);
                else
                {
                    if (cmbIDProfesion.SelectedValue == null) throw new Exception("La ID es inválida o no ha sido seleccionada");
                    int id = (int)cmbIDProfesion.SelectedValue;
                    fa = new BLL.Profesion().EditarPersona(id, nombre);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            ActualizarControles();
        }
    }
}
