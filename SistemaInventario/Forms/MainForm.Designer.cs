namespace SistemaInventario.Forms
{
    partial class MainForm
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
            panelMenu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInicio = new Button();
            btnProductos = new Button();
            btnAlmacenes = new Button();
            panelContenedor = new Panel();
            btnCerrarSesion = new Button();
            panelMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 82, 158);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(flowLayoutPanel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(213, 1055);
            panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInicio);
            flowLayoutPanel1.Controls.Add(btnProductos);
            flowLayoutPanel1.Controls.Add(btnAlmacenes);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(213, 1055);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnInicio
            // 
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Location = new Point(27, 40);
            btnInicio.Margin = new Padding(27, 30, 0, 40);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(160, 50);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnProductos.ForeColor = SystemColors.ControlLightLight;
            btnProductos.Location = new Point(27, 160);
            btnProductos.Margin = new Padding(27, 30, 0, 40);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(160, 50);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAlmacenes
            // 
            btnAlmacenes.FlatStyle = FlatStyle.Flat;
            btnAlmacenes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAlmacenes.ForeColor = SystemColors.ControlLightLight;
            btnAlmacenes.Location = new Point(27, 280);
            btnAlmacenes.Margin = new Padding(27, 30, 0, 220);
            btnAlmacenes.Name = "btnAlmacenes";
            btnAlmacenes.Size = new Size(160, 50);
            btnAlmacenes.TabIndex = 2;
            btnAlmacenes.Text = "Almacenes";
            btnAlmacenes.UseVisualStyleBackColor = true;
            btnAlmacenes.Click += btnAlmacenes_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContenedor.Location = new Point(213, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(590, 1055);
            panelContenedor.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.BackColor = Color.FromArgb(217, 158, 48);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(24, 960);
            btnCerrarSesion.Margin = new Padding(27, 30, 0, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(165, 50);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "➜] Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 1055);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Sistema de Inventario";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnAlmacenes;
        private Button btnProductos;
        private Button btnInicio;
        private Panel panelContenedor;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCerrarSesion;
    }
}