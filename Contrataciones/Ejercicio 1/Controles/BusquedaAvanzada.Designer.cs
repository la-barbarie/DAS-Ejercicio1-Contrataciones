namespace Ejercicio_1.Controles
{
    partial class BusquedaAvanzada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbNac = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.nupEdMin = new System.Windows.Forms.NumericUpDown();
            this.nupEdMax = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdMax)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(12, 30);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(120, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(138, 30);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(120, 20);
            this.txbApellido.TabIndex = 1;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "",
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(396, 30);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 21);
            this.cmbSexo.TabIndex = 4;
            // 
            // cmbNac
            // 
            this.cmbNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNac.FormattingEnabled = true;
            this.cmbNac.Location = new System.Drawing.Point(522, 30);
            this.cmbNac.Name = "cmbNac";
            this.cmbNac.Size = new System.Drawing.Size(120, 21);
            this.cmbNac.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 56);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(756, 362);
            this.dgvDatos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad mín.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad max.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nacionalidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Profesión";
            // 
            // cmbProf
            // 
            this.cmbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(648, 30);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(120, 21);
            this.cmbProf.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 424);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(756, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // nupEdMin
            // 
            this.nupEdMin.Location = new System.Drawing.Point(264, 30);
            this.nupEdMin.Name = "nupEdMin";
            this.nupEdMin.Size = new System.Drawing.Size(60, 20);
            this.nupEdMin.TabIndex = 16;
            // 
            // nupEdMax
            // 
            this.nupEdMax.Location = new System.Drawing.Point(330, 30);
            this.nupEdMax.Name = "nupEdMax";
            this.nupEdMax.Size = new System.Drawing.Size(60, 20);
            this.nupEdMax.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(756, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nupEdMax);
            this.Controls.Add(this.nupEdMin);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.cmbNac);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Name = "BusquedaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda Avanzada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbNac;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.NumericUpDown nupEdMin;
        private System.Windows.Forms.NumericUpDown nupEdMax;
        private System.Windows.Forms.Button button1;
    }
}