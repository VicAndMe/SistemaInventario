namespace SistemaInventario.Forms
{
    partial class AlmacenesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed;
        /// otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvAlmacenes = new DataGridView();
            flowBotones = new FlowLayoutPanel();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtBuscar = new TextBox();
            lblBoxAlmacenes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenes).BeginInit();
            flowBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 158);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ALMACENES";
            // 
            // dgvAlmacenes
            // 
            dgvAlmacenes.AllowUserToAddRows = false;
            dgvAlmacenes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlmacenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlmacenes.Location = new Point(12, 63);
            dgvAlmacenes.MultiSelect = false;
            dgvAlmacenes.Name = "dgvAlmacenes";
            dgvAlmacenes.ReadOnly = true;
            dgvAlmacenes.RowHeadersWidth = 51;
            dgvAlmacenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlmacenes.Size = new Size(1149, 375);
            dgvAlmacenes.TabIndex = 1;
            // 
            // flowBotones
            // 
            flowBotones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowBotones.AutoSize = true;
            flowBotones.Controls.Add(btnEliminar);
            flowBotones.Controls.Add(btnAgregar);
            flowBotones.Controls.Add(btnModificar);
            flowBotones.FlowDirection = FlowDirection.RightToLeft;
            flowBotones.Location = new Point(576, 2);
            flowBotones.Name = "flowBotones";
            flowBotones.Size = new Size(585, 55);
            flowBotones.TabIndex = 2;
            flowBotones.WrapContents = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(217, 158, 48);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(440, 5);
            btnEliminar.Margin = new Padding(50, 5, 15, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 45);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "⛌ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(217, 158, 48);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(245, 5);
            btnAgregar.Margin = new Padding(50, 5, 15, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 45);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "✚ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(217, 158, 48);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnModificar.Location = new Point(50, 5);
            btnModificar.Margin = new Padding(50, 5, 15, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 45);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "⟳ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(333, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(220, 27);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBoxAlmacenes
            // 
            lblBoxAlmacenes.AutoSize = true;
            lblBoxAlmacenes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBoxAlmacenes.ForeColor = Color.FromArgb(0, 82, 158);
            lblBoxAlmacenes.Location = new Point(252, 22);
            lblBoxAlmacenes.Name = "lblBoxAlmacenes";
            lblBoxAlmacenes.Size = new Size(82, 25);
            lblBoxAlmacenes.TabIndex = 4;
            lblBoxAlmacenes.Text = "Buscar: ";
            // 
            // AlmacenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 450);
            Controls.Add(lblBoxAlmacenes);
            Controls.Add(txtBuscar);
            Controls.Add(flowBotones);
            Controls.Add(dgvAlmacenes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlmacenesForm";
            Text = "AlmacenesForm";
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenes).EndInit();
            flowBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;

        private DataGridView dgvAlmacenes;

        private FlowLayoutPanel flowBotones;

        private Button btnAgregar;

        private Button btnModificar;

        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label lblBoxAlmacenes;
    }
}