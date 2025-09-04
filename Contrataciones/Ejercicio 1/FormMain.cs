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
            CargarControles(new Resumen());
        }

        private void CargarControles(UserControl menu)
        {
            menu.Dock = DockStyle.Fill;
            pnlControles.Controls.Clear();
            pnlControles.Controls.Add(menu);
        }

        private void AddChangeMenu(object sender, EventArgs e)
        {
            ToolStripMenuItem boton = sender as ToolStripMenuItem;

            switch (boton.Text)
            {
                case "Persona":
                    if (boton.OwnerItem.Text == "Modificar") CargarControles(new Persona(true));
                    else CargarControles(new Persona(false));
                    break;
                case "Nacionalidad":
                    if (boton.OwnerItem.Text == "Modificar") CargarControles(new Nacionalidad(true));
                    else CargarControles(new Nacionalidad(false));
                    break;
                case "Profesión":
                    if (boton.OwnerItem.Text == "Modificar") CargarControles(new Profesion(true));
                    else CargarControles(new Profesion(false));
                    break;
                default:
                    CargarControles(new Resumen());
                    break;
            }
        }
    }
}
