namespace AppDesktop_FORMNETCORE_
{
    partial class FormMostrarInfo
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
            txtMostrar = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            labelPregunta = new Label();
            SuspendLayout();
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(12, 29);
            txtMostrar.Multiline = true;
            txtMostrar.Name = "txtMostrar";
            txtMostrar.ReadOnly = true;
            txtMostrar.Size = new Size(285, 190);
            txtMostrar.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(12, 225);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(222, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelPregunta
            // 
            labelPregunta.AutoSize = true;
            labelPregunta.Location = new Point(12, 9);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(126, 15);
            labelPregunta.TabIndex = 3;
            labelPregunta.Text = "¿Desea - este Alumno?";
            // 
            // FormMostrarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 255);
            Controls.Add(labelPregunta);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtMostrar);
            Name = "FormMostrarInfo";
            Text = "FormMostrarInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        public TextBox txtMostrar;
        public Label labelPregunta;
    }
}