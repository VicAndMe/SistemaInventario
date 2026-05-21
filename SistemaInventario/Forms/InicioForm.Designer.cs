namespace SistemaInventario.Forms
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            pbLogo = new PictureBox();
            lblUsuarioActual = new Label();
            lblTitulo = new Label();
            lblUsuarioTexto = new Label();
            lblInstruccion = new Label();
            lblBienvenida = new Label();
            lbNombre = new Label();
            panelContenido = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(205, 106);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(736, 555);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // lblUsuarioActual
            // 
            lblUsuarioActual.AutoSize = true;
            lblUsuarioActual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblUsuarioActual.ForeColor = Color.FromArgb(0, 82, 158);
            lblUsuarioActual.Location = new Point(187, 632);
            lblUsuarioActual.Name = "lblUsuarioActual";
            lblUsuarioActual.Size = new Size(0, 32);
            lblUsuarioActual.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 158);
            lblTitulo.Location = new Point(148, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(847, 89);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE INVENTARIO";
            // 
            // lblUsuarioTexto
            // 
            lblUsuarioTexto.AutoSize = true;
            lblUsuarioTexto.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblUsuarioTexto.ForeColor = Color.FromArgb(217, 158, 48);
            lblUsuarioTexto.Location = new Point(4, 632);
            lblUsuarioTexto.Name = "lblUsuarioTexto";
            lblUsuarioTexto.Size = new Size(183, 32);
            lblUsuarioTexto.TabIndex = 5;
            lblUsuarioTexto.Text = "Usuario actual: ";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.Gray;
            lblInstruccion.Location = new Point(328, 580);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(470, 35);
            lblInstruccion.TabIndex = 4;
            lblInstruccion.Text = "Seleccione una opción del menu lateral.";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(217, 158, 48);
            lblBienvenida.Location = new Point(269, 534);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(586, 46);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "¡Bienvenido al sistema de inventario!";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lbNombre.ForeColor = Color.DimGray;
            lbNombre.Location = new Point(111, 106);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(906, 30);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Desarrollado por Ariel López, Eriks Castro, Ricardo Camargo, Luz Rodríguez y Victor Horta.";
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(lbNombre);
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Controls.Add(lblInstruccion);
            panelContenido.Controls.Add(lblUsuarioTexto);
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(lblUsuarioActual);
            panelContenido.Controls.Add(pbLogo);
            panelContenido.Location = new Point(8, 8);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1100, 750);
            panelContenido.TabIndex = 7;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1149, 681);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioForm";
            Text = "InicioForm";
            Resize += InicioForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblUsuarioActual;
        private Label lblTitulo;
        private Label lblUsuarioTexto;
        private Label lblInstruccion;
        private Label lblBienvenida;
        private Label lbNombre;
        private Panel panelContenido;
    }
}