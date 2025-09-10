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
    public partial class Resumen : UserControl
    {
        public Resumen()
        {
            InitializeComponent();
            ActualizarDatos();
            
            cmbSelectNac.SelectedItem = cmbSelectNac.Items.Cast<BE.Nacionalidad>().FirstOrDefault(n => n.Nombre == txbNacMasCant.Text);
        }

        private void ActualizarDatos()
        {
            BLL.Personas PersonaBLL = new BLL.Personas();
            BLL.Nacionalidad NacionalidadBLL = new BLL.Nacionalidad();

            cmbNroPersona.DataSource = PersonaBLL.ListarPersonas();
            cmbNroPersona.DisplayMember = "NumeroPersona";
            cmbNroPersona.SelectedIndex = -1;

            foreach (TextBox tx in tbpResumenPersona.Controls.OfType<TextBox>()) tx.Text = "";

            txbCantPersonasGral.Text = PersonaBLL.GetCantidad().ToString();
            txbEdadMinGral.Text = PersonaBLL.GetMinEdad().ToString();
            txbEdadAvgGral.Text = PersonaBLL.GetPromedioEdad().ToString();
            txbEdadMaxGral.Text = PersonaBLL.GetMaxEdad().ToString();

            txbNacMenosCant.Text = NacionalidadBLL.GetMinPersonasRegistradas().Nacionalidad.Nombre;
            txbNacMasCant.Text = NacionalidadBLL.GetMaxPersonasRegistradas().Nacionalidad.Nombre;

            cmbSelectNac.DataSource = NacionalidadBLL.ListarNacionalidades();
            cmbSelectNac.DisplayMember = "Nombre";
            cmbSelectNac.SelectedIndex = -1;

            txbAvgEdadSelec.Text = "";
            txbCantPerSelec.Text = "";
        }

        private void cmbNroPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNroPersona.SelectedValue == null) return;

            BE.Persona p = (BE.Persona)cmbNroPersona.SelectedValue;
            txbNombre.Text = p.Nombre;
            txbApellido.Text = p.Apellido;
            txbEdad.Text = p.Edad.ToString();
            if (p.Sexo == false) txbSexo.Text = "Femenino";
            else txbSexo.Text = "Masculino";
            txbNacionalidad.Text = new BLL.Nacionalidad().GetById(p.Nacionalidad).Nombre;
            txbProfesion.Text = new BLL.Profesion().GetById(p.Profesion).Nombre;
        }

        private void cmbSelectNac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectNac.SelectedValue == null) return;

            BE.Nacionalidad n = (BE.Nacionalidad)cmbSelectNac.SelectedValue;
            txbAvgEdadSelec.Text = new BLL.Personas().GetPromedioEdadPorNacionalidad(n.IdNacionalidad).ToString();
            txbCantPerSelec.Text = new BLL.Personas().GetCantidadPersonasPorNacionalidad(n.IdNacionalidad).ToString();
        }

        private void bntBusqAvanz_Click(object sender, EventArgs e)
        {
            FindForm().Visible = false;
            Form BusquedaAv = new BusquedaAvanzada();
            BusquedaAv.ShowDialog();
            FindForm().Visible = true;
        }
    }
}
