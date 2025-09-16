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
    public partial class FormPersona : Form
    {
        bool btnEditar;
        BLL.Eventos eventos;
        public FormPersona(bool editar, Eventos eventosMDI)
        {
            btnEditar = editar;
            eventos = eventosMDI;
            InitializeComponent();
            ActualizarControles();

            gbxGrupo.Text = editar ? "Modificar - Profesión" : "Agregar - Profesión";

            cmbNroPersona.Enabled = cmbNroPersona.Visible = editar;
            txbNroPersona.Enabled = txbNroPersona.Visible = !editar;

            btnAceptar.Text = editar ? "Modificar" : "Agregar";
            btnAceptar.Enabled = editar ? false : true;
            btnAceptar.Visible = true;

            btnEliminar.Enabled = false;
            btnEliminar.Visible = editar;

            if (editar) camposActivos(false);
            eventos.ActualizarDatos += ActualizarControles;
        }

        private void ActualizarControles()
        {
            cmbNroPersona.DataSource = new BLL.Personas().ListarPersonas();
            cmbNroPersona.DisplayMember = "Nombre";
            cmbNroPersona.SelectedIndex = -1;

            cmbSexo.SelectedIndex = -1;

            cmbNacionalidad.DataSource = new BLL.Nacionalidad().ListarNacionalidades();
            cmbNacionalidad.DisplayMember = "Nombre";
            cmbNacionalidad.SelectedIndex = -1;

            cmbProfesion.DataSource = new BLL.Profesion().ListarProfesiones();
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

                if (!btnEditar)
                {
                    fa = new BLL.Personas().InsertarPersona(nombre, apellido, edad, sexo, nacionalidad, profesion);
                    eventos.InvocarActualizarDatos();
                }
                else
                {
                    if (cmbNroPersona.SelectedValue == null) throw new Exception("La Persona seleccionada es inválida o no ha sido seleccionada");
                    int id = ((BE.Persona)cmbNroPersona.SelectedValue).NumeroPersona;
                    fa = new BLL.Personas().EditarPersona(id, nombre, apellido, edad, sexo, nacionalidad, profesion);
                    eventos.InvocarActualizarDatos();
                    cmbNroPersona.SelectedItem = cmbNroPersona.Items.Cast<BE.Persona>().FirstOrDefault(p => p.NumeroPersona == id);
                }

                if (fa != 0) MessageBox.Show("Se ha cargado la información satisfactoriamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void cmbNroPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNroPersona.SelectedValue == null) return;

            BE.Persona p = (BE.Persona)cmbNroPersona.SelectedValue;
            txbNombre.Text = p.Nombre;
            txbApellido.Text = p.Apellido;
            nupEdad.Value = p.Edad;
            if (p.Sexo == false) cmbSexo.SelectedIndex = 0;
            else cmbSexo.SelectedIndex = 1;
            cmbNacionalidad.SelectedItem = cmbNacionalidad.Items.Cast<BE.Nacionalidad>().FirstOrDefault(n => n.IdNacionalidad == p.Nacionalidad);
            cmbProfesion.SelectedItem = cmbProfesion.Items.Cast<BE.Profesion>().FirstOrDefault(prof => prof.IdProfesion == p.Profesion);

            camposActivos(true);
            btnAceptar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void camposActivos(bool activo)
        {
            txbNombre.Enabled = activo;
            txbApellido.Enabled = activo;
            nupEdad.Enabled = activo;
            cmbSexo.Enabled = activo;
            cmbNacionalidad.Enabled = activo;
            cmbProfesion.Enabled = activo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Persona p = (BE.Persona)cmbNroPersona.SelectedItem;
                int fa = 0;
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar a {p.Nombre}? Esta acción no se puede deshacer", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK) fa = new BLL.Personas().RemoverPersona(p.NumeroPersona);
                else MessageBox.Show("Operación cancelada");

                if (fa != 0) MessageBox.Show($"Se ha eliminado a {p.Nombre}.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            eventos.InvocarActualizarDatos();
            camposActivos(false);
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
