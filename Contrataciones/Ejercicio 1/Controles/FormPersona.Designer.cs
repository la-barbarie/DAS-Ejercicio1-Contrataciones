namespace Ejercicio_1.Controles
{
    partial class FormPersona
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbNroPersona = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbProfesion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.cmbNroPersona = new System.Windows.Forms.ComboBox();
            this.gbxGrupo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.gbxGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(19, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 20);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbNroPersona
            // 
            this.txbNroPersona.Location = new System.Drawing.Point(91, 24);
            this.txbNroPersona.Name = "txbNroPersona";
            this.txbNroPersona.ReadOnly = true;
            this.txbNroPersona.Size = new System.Drawing.Size(120, 20);
            this.txbNroPersona.TabIndex = 7;
            this.txbNroPersona.Text = "---";
            this.txbNroPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 21);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "---";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(91, 101);
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(120, 20);
            this.nupEdad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Profesión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P. Número";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(91, 75);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(120, 20);
            this.txbApellido.TabIndex = 9;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(91, 127);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 21);
            this.cmbSexo.TabIndex = 11;
            // 
            // cmbProfesion
            // 
            this.cmbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesion.FormattingEnabled = true;
            this.cmbProfesion.Location = new System.Drawing.Point(91, 181);
            this.cmbProfesion.Name = "cmbProfesion";
            this.cmbProfesion.Size = new System.Drawing.Size(120, 21);
            this.cmbProfesion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(91, 49);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(120, 20);
            this.txbNombre.TabIndex = 8;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(91, 154);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(120, 21);
            this.cmbNacionalidad.TabIndex = 12;
            // 
            // cmbNroPersona
            // 
            this.cmbNroPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroPersona.FormattingEnabled = true;
            this.cmbNroPersona.Location = new System.Drawing.Point(91, 23);
            this.cmbNroPersona.Name = "cmbNroPersona";
            this.cmbNroPersona.Size = new System.Drawing.Size(120, 21);
            this.cmbNroPersona.TabIndex = 7;
            this.cmbNroPersona.SelectedIndexChanged += new System.EventHandler(this.cmbNroPersona_SelectedIndexChanged);
            // 
            // gbxGrupo
            // 
            this.gbxGrupo.Controls.Add(this.btnEliminar);
            this.gbxGrupo.Controls.Add(this.txbNroPersona);
            this.gbxGrupo.Controls.Add(this.btnAceptar);
            this.gbxGrupo.Controls.Add(this.nupEdad);
            this.gbxGrupo.Controls.Add(this.label7);
            this.gbxGrupo.Controls.Add(this.label5);
            this.gbxGrupo.Controls.Add(this.label4);
            this.gbxGrupo.Controls.Add(this.label1);
            this.gbxGrupo.Controls.Add(this.txbApellido);
            this.gbxGrupo.Controls.Add(this.cmbSexo);
            this.gbxGrupo.Controls.Add(this.cmbProfesion);
            this.gbxGrupo.Controls.Add(this.label6);
            this.gbxGrupo.Controls.Add(this.label3);
            this.gbxGrupo.Controls.Add(this.label2);
            this.gbxGrupo.Controls.Add(this.txbNombre);
            this.gbxGrupo.Controls.Add(this.cmbNacionalidad);
            this.gbxGrupo.Controls.Add(this.cmbNroPersona);
            this.gbxGrupo.Location = new System.Drawing.Point(2, -1);
            this.gbxGrupo.Name = "gbxGrupo";
            this.gbxGrupo.Size = new System.Drawing.Size(230, 272);
            this.gbxGrupo.TabIndex = 32;
            this.gbxGrupo.TabStop = false;
            this.gbxGrupo.Text = "---";
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 271);
            this.Controls.Add(this.gbxGrupo);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.gbxGrupo.ResumeLayout(false);
            this.gbxGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbNroPersona;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbProfesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.ComboBox cmbNroPersona;
        private System.Windows.Forms.GroupBox gbxGrupo;
    }
}