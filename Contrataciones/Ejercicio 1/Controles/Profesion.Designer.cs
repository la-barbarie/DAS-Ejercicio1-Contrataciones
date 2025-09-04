namespace Ejercicio_1.Controles
{
    partial class Profesion
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
            this.gbxGrupo = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.nupIDProfesion = new System.Windows.Forms.NumericUpDown();
            this.cmbIDProfesion = new System.Windows.Forms.ComboBox();
            this.gbxGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIDProfesion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGrupo
            // 
            this.gbxGrupo.Controls.Add(this.cmbIDProfesion);
            this.gbxGrupo.Controls.Add(this.nupIDProfesion);
            this.gbxGrupo.Controls.Add(this.txbNombre);
            this.gbxGrupo.Controls.Add(this.label2);
            this.gbxGrupo.Controls.Add(this.label1);
            this.gbxGrupo.Controls.Add(this.btnAceptar);
            this.gbxGrupo.Location = new System.Drawing.Point(10, 28);
            this.gbxGrupo.Name = "gbxGrupo";
            this.gbxGrupo.Size = new System.Drawing.Size(230, 272);
            this.gbxGrupo.TabIndex = 15;
            this.gbxGrupo.TabStop = false;
            this.gbxGrupo.Text = "---";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 21);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "---";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Profesion";
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
            // nupIDProfesion
            // 
            this.nupIDProfesion.Location = new System.Drawing.Point(91, 23);
            this.nupIDProfesion.Name = "nupIDProfesion";
            this.nupIDProfesion.Size = new System.Drawing.Size(120, 20);
            this.nupIDProfesion.TabIndex = 7;
            // 
            // cmbIDProfesion
            // 
            this.cmbIDProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDProfesion.FormattingEnabled = true;
            this.cmbIDProfesion.Location = new System.Drawing.Point(91, 23);
            this.cmbIDProfesion.Name = "cmbIDProfesion";
            this.cmbIDProfesion.Size = new System.Drawing.Size(120, 21);
            this.cmbIDProfesion.TabIndex = 7;
            // 
            // Profesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxGrupo);
            this.Name = "Profesion";
            this.Size = new System.Drawing.Size(250, 310);
            this.gbxGrupo.ResumeLayout(false);
            this.gbxGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIDProfesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.NumericUpDown nupIDProfesion;
        private System.Windows.Forms.ComboBox cmbIDProfesion;
        private System.Windows.Forms.Button btnAceptar;
    }
}
