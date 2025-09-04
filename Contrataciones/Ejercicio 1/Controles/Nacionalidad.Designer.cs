namespace Ejercicio_1.Controles
{
    partial class Nacionalidad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.nupIDNacionalidad = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.cmbIDNacionalidad = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.gbxGrupo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupIDNacionalidad)).BeginInit();
            this.gbxGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 21);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "---";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(91, 49);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(120, 20);
            this.txbNombre.TabIndex = 24;
            // 
            // nupIDNacionalidad
            // 
            this.nupIDNacionalidad.Location = new System.Drawing.Point(91, 23);
            this.nupIDNacionalidad.Name = "nupIDNacionalidad";
            this.nupIDNacionalidad.Size = new System.Drawing.Size(120, 20);
            this.nupIDNacionalidad.TabIndex = 23;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(19, 52);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 13);
            this.label41.TabIndex = 21;
            this.label41.Text = "Nombre";
            // 
            // cmbIDNacionalidad
            // 
            this.cmbIDNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDNacionalidad.FormattingEnabled = true;
            this.cmbIDNacionalidad.Location = new System.Drawing.Point(91, 23);
            this.cmbIDNacionalidad.Name = "cmbIDNacionalidad";
            this.cmbIDNacionalidad.Size = new System.Drawing.Size(120, 21);
            this.cmbIDNacionalidad.TabIndex = 22;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(19, 26);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 13);
            this.label40.TabIndex = 20;
            this.label40.Text = "ID Nac.";
            // 
            // gbxGrupo
            // 
            this.gbxGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.gbxGrupo.Controls.Add(this.label40);
            this.gbxGrupo.Controls.Add(this.btnAceptar);
            this.gbxGrupo.Controls.Add(this.cmbIDNacionalidad);
            this.gbxGrupo.Controls.Add(this.txbNombre);
            this.gbxGrupo.Controls.Add(this.label41);
            this.gbxGrupo.Controls.Add(this.nupIDNacionalidad);
            this.gbxGrupo.Location = new System.Drawing.Point(10, 28);
            this.gbxGrupo.Name = "gbxGrupo";
            this.gbxGrupo.Size = new System.Drawing.Size(230, 272);
            this.gbxGrupo.TabIndex = 31;
            this.gbxGrupo.TabStop = false;
            this.gbxGrupo.Text = "---";
            // 
            // Nacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gbxGrupo);
            this.Name = "Nacionalidad";
            this.Size = new System.Drawing.Size(250, 310);
            ((System.ComponentModel.ISupportInitialize)(this.nupIDNacionalidad)).EndInit();
            this.gbxGrupo.ResumeLayout(false);
            this.gbxGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.NumericUpDown nupIDNacionalidad;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cmbIDNacionalidad;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox gbxGrupo;
    }
}
