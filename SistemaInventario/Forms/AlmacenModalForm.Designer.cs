namespace SistemaInventario.Forms
{
    partial class AlmacenModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components =
            null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtUbicacion = new TextBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            lblNombre = new Label();
            lblUbicacion = new Label();

            SuspendLayout();

            // 
            // txtNombre
            // 
            txtNombre.BorderStyle =
                BorderStyle.FixedSingle;

            txtNombre.Location =
                new Point(200, 70);

            txtNombre.Name =
                "txtNombre";

            txtNombre.Size =
                new Size(250, 30);

            txtNombre.TabIndex = 0;

            // 
            // txtUbicacion
            // 
            txtUbicacion.BorderStyle =
                BorderStyle.FixedSingle;

            txtUbicacion.Location =
                new Point(200, 150);

            txtUbicacion.Name =
                "txtUbicacion";

            txtUbicacion.Size =
                new Size(250, 30);

            txtUbicacion.TabIndex = 1;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(217, 158, 48);

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.Font =
                new Font(
                    "Segoe UI Semibold",
                    10.8F,
                    FontStyle.Bold);

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(300, 260);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(120, 40);

            btnGuardar.TabIndex = 2;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor =
                false;

            btnGuardar.Click +=
                btnGuardar_Click;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.FromArgb(220, 53, 69);

            btnCancelar.DialogResult =
                DialogResult.Cancel;

            btnCancelar.FlatAppearance.BorderSize =
                0;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.Font =
                new Font(
                    "Segoe UI Semibold",
                    10.8F,
                    FontStyle.Bold);

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(120, 260);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(120, 40);

            btnCancelar.TabIndex = 3;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Font =
                new Font(
                    "Segoe UI",
                    10.2F,
                    FontStyle.Bold);

            lblNombre.ForeColor =
                Color.FromArgb(0, 82, 158);

            lblNombre.Location =
                new Point(60, 70);

            lblNombre.Name =
                "lblNombre";

            lblNombre.Size =
                new Size(76, 23);

            lblNombre.TabIndex = 4;

            lblNombre.Text =
                "Nombre";

            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;

            lblUbicacion.Font =
                new Font(
                    "Segoe UI",
                    10.2F,
                    FontStyle.Bold);

            lblUbicacion.ForeColor =
                Color.FromArgb(0, 82, 158);

            lblUbicacion.Location =
                new Point(60, 150);

            lblUbicacion.Name =
                "lblUbicacion";

            lblUbicacion.Size =
                new Size(93, 23);

            lblUbicacion.TabIndex = 5;

            lblUbicacion.Text =
                "Ubicación";

            // 
            // AlmacenModalForm
            // 
            AcceptButton = btnGuardar;

            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            CancelButton =
                btnCancelar;

            ClientSize =
                new Size(520, 360);

            Controls.Add(lblUbicacion);
            Controls.Add(lblNombre);

            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);

            Controls.Add(txtUbicacion);
            Controls.Add(txtNombre);

            Font =
                new Font(
                    "Segoe UI",
                    10.2F,
                    FontStyle.Regular);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;

            MinimizeBox = false;

            Name =
                "AlmacenModalForm";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Almacén";

            ResumeLayout(false);

            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;

        private TextBox txtUbicacion;

        private Button btnGuardar;

        private Button btnCancelar;

        private Label lblNombre;

        private Label lblUbicacion;
    }
}