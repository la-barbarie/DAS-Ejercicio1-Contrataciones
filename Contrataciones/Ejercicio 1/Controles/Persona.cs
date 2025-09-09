using BLL;
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
    public partial class Persona : UserControl
    {
        bool btnEditar;
        public Persona(bool editar)
        {
            btnEditar = editar;
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

            ActualizarControles();
        }

        private void ActualizarControles()
        {
            cmbNroPersona.DataSource = new BLL.Personas().ListarPersonas();
            cmbNroPersona.DisplayMember = "Nombre";
            cmbNroPersona.SelectedIndex = -1;

            cmbSexo.SelectedIndex = -1;

            cmbNacionalidad.DataSource = new BLL.Nacionalidad().ListarPersonas();
            cmbNacionalidad.DisplayMember = "Nombre";
            cmbNacionalidad.SelectedIndex = -1;

            cmbProfesion.DataSource = new BLL.Profesion().ListarPersonas();
            cmbProfesion.DisplayMember = "Nombre";
            cmbProfesion.SelectedIndex = -1;

            txbNombre.Text = "";
            txbApellido.Text = "";
            nupEdad.Value = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextInfo ti = new CultureInfo("es-ES", false).TextInfo;
            string nombre = ti.ToTitleCase(txbNombre.Text);
            string apellido = ti.ToTitleCase(txbApellido.Text);
            int edad = (int)nupEdad.Value;
            bool sexo = cmbSexo.SelectedIndex == 1;
            BE.Nacionalidad nacionalidad = (BE.Nacionalidad)cmbNacionalidad.SelectedItem;
            BE.Profesion profesion = (BE.Profesion)cmbProfesion.SelectedItem;
            int fa;

            try
            {
                if (nombre.Length < 0) throw new Exception("El nombre está vacío");
                if (apellido.Length < 0) throw new Exception("El apellido está vacío");
                if (edad < 0) throw new Exception("La edad es inválida");
                if (cmbSexo.SelectedIndex < 0 || cmbSexo.SelectedIndex > 1) throw new Exception("El sexo está vacío o no ha sido seleccionado");
                if (cmbNacionalidad.SelectedValue == null) throw new Exception("La nacionalidad es inválida o no ha sido seleccionada");
                if (cmbProfesion.SelectedValue == null) throw new Exception("La profesion es inválida o no ha sido seleccionada");

                if (!btnEditar) fa = new BLL.Personas().InsertarPersona(nombre, apellido, edad, sexo, nacionalidad, profesion);
                else
                {
                    if (cmbNroPersona.SelectedValue == null) throw new Exception("La Persona seleccionada es inválida o no ha sido seleccionada");
                    int id = (int)cmbNroPersona.SelectedValue;
                    fa = new BLL.Personas().EditarPersona(id, nombre, apellido, edad, sexo, nacionalidad, profesion);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            ActualizarControles();
        }
    }
}
