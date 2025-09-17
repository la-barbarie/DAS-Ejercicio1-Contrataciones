using BLL;
using Ejercicio_1.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormMain : Form
    {        
        Eventos eventos = new Eventos();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // CargarControles(new Resumen());
        }

        private void AddChangeMenuCargar(object sender, EventArgs e)
        {
            ToolStripMenuItem boton = sender as ToolStripMenuItem;

            switch (boton.Text)
            {
                case "Persona":
                    FormPersona personaCargar = new FormPersona(false, eventos);
                    personaCargar.MdiParent = this;
                    personaCargar.Show();
                    break;
                case "Nacionalidad":
                    FormNacionalidad nacionalidadCargar = new FormNacionalidad(false, eventos);
                    nacionalidadCargar.MdiParent = this;
                    nacionalidadCargar.Show();
                    break;
                case "Profesión":
                    FormProfesion profesionCargar = new FormProfesion(false, eventos);
                    profesionCargar.MdiParent = this;
                    profesionCargar.Show();
                    break;
                default:
                    FormResumen formResumen = new FormResumen(eventos);
                    formResumen.MdiParent = this;
                    formResumen.Show();
                    break;
            }
        }

        private void AddChangeMenuEditar(object sender, EventArgs e)
        {
            ToolStripMenuItem boton = sender as ToolStripMenuItem;

            switch (boton.Text)
            {
                case "Persona":
                    FormPersona personaCargar = new FormPersona(true, eventos);
                    personaCargar.MdiParent = this;
                    personaCargar.Show();
                    break;
                case "Nacionalidad":
                    FormNacionalidad nacionalidadCargar = new FormNacionalidad(true, eventos);
                    nacionalidadCargar.MdiParent = this;
                    nacionalidadCargar.Show();
                    break;
                case "Profesión":
                    FormProfesion profesionCargar = new FormProfesion(true, eventos);
                    profesionCargar.MdiParent = this;
                    profesionCargar.Show();
                    break;
                default:
                    FormResumen formResumen = new FormResumen(eventos);
                    formResumen.MdiParent = this;
                    formResumen.Show();
                    break;
            }
        }
    }
}
