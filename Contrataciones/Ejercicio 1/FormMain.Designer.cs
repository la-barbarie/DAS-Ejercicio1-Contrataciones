namespace Ejercicio_1
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarResuemnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.mostrarResuemnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.profesiónToolStripMenuItem,
            this.nacionalidadToolStripMenuItem});
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.añadirToolStripMenuItem.Text = "Añadir";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // profesiónToolStripMenuItem
            // 
            this.profesiónToolStripMenuItem.Name = "profesiónToolStripMenuItem";
            this.profesiónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.profesiónToolStripMenuItem.Text = "Profesión";
            this.profesiónToolStripMenuItem.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // nacionalidadToolStripMenuItem
            // 
            this.nacionalidadToolStripMenuItem.Name = "nacionalidadToolStripMenuItem";
            this.nacionalidadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nacionalidadToolStripMenuItem.Text = "Nacionalidad";
            this.nacionalidadToolStripMenuItem.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem1,
            this.profesiónToolStripMenuItem1,
            this.nacionalidadToolStripMenuItem1});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // personaToolStripMenuItem1
            // 
            this.personaToolStripMenuItem1.Name = "personaToolStripMenuItem1";
            this.personaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.personaToolStripMenuItem1.Text = "Persona";
            this.personaToolStripMenuItem1.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // profesiónToolStripMenuItem1
            // 
            this.profesiónToolStripMenuItem1.Name = "profesiónToolStripMenuItem1";
            this.profesiónToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.profesiónToolStripMenuItem1.Text = "Profesión";
            this.profesiónToolStripMenuItem1.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // nacionalidadToolStripMenuItem1
            // 
            this.nacionalidadToolStripMenuItem1.Name = "nacionalidadToolStripMenuItem1";
            this.nacionalidadToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.nacionalidadToolStripMenuItem1.Text = "Nacionalidad";
            this.nacionalidadToolStripMenuItem1.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // mostrarResuemnToolStripMenuItem
            // 
            this.mostrarResuemnToolStripMenuItem.Name = "mostrarResuemnToolStripMenuItem";
            this.mostrarResuemnToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.mostrarResuemnToolStripMenuItem.Text = "Mostrar resumen";
            this.mostrarResuemnToolStripMenuItem.Click += new System.EventHandler(this.AddChangeMenu);
            // 
            // pnlControles
            // 
            this.pnlControles.Location = new System.Drawing.Point(0, 24);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(250, 310);
            this.pnlControles.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 334);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profesiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarResuemnToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControles;
    }
}

