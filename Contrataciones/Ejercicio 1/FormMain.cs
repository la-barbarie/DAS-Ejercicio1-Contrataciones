using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Controles;

namespace Ejercicio_1
{
    public partial class FormMain : Form
    {        
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
                    FormPersona personaCargar = new FormPersona(false);
                    personaCargar.MdiParent = this;
                    personaCargar.Show();
                    break;
                case "Nacionalidad":
                    FormNacionalidad nacionalidadCargar = new FormNacionalidad(false);
                    nacionalidadCargar.MdiParent = this;
                    nacionalidadCargar.Show();
                    break;
                case "Profesión":
                    FormProfesion profesionCargar = new FormProfesion(false);
                    profesionCargar.MdiParent = this;
                    profesionCargar.Show();
                    break;
                default:
                    FormResumen formResumen = new FormResumen();
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
                    FormPersona personaCargar = new FormPersona(true);
                    personaCargar.MdiParent = this;
                    personaCargar.Show();
                    break;
                case "Nacionalidad":
                    FormNacionalidad nacionalidadCargar = new FormNacionalidad(true);
                    nacionalidadCargar.MdiParent = this;
                    nacionalidadCargar.Show();
                    break;
                case "Profesión":
                    FormProfesion profesionCargar = new FormProfesion(true);
                    profesionCargar.MdiParent = this;
                    profesionCargar.Show();
                    break;
                default:
                    FormResumen formResumen = new FormResumen();
                    formResumen.MdiParent = this;
                    formResumen.Show();
                    break;
            }
        }
    }
}
