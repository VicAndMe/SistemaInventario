namespace SistemaInventario.Forms
{
    partial class ProductosForm
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
            lblTitulo = new Label();
            dgvProductos = new DataGridView();
            flowBotones = new FlowLayoutPanel();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudStockMax = new NumericUpDown();
            nudStockMin = new NumericUpDown();
            nudPrecioMax = new NumericUpDown();
            nudPrecioMin = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            flowBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMin).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 158);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PRODUCTOS";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 99);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1132, 339);
            dgvProductos.TabIndex = 1;
            // 
            // flowBotones
            // 
            flowBotones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowBotones.AutoSize = true;
            flowBotones.Controls.Add(btnEliminar);
            flowBotones.Controls.Add(btnAgregar);
            flowBotones.Controls.Add(btnModificar);
            flowBotones.FlowDirection = FlowDirection.RightToLeft;
            flowBotones.Location = new Point(559, 2);
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
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI Semibold", 10.2F);
            txtBuscar.Location = new Point(333, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(220, 30);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.FromArgb(0, 82, 158);
            lblBuscar.Location = new Point(252, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(75, 25);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 82, 158);
            label1.Location = new Point(587, 70);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 11;
            label1.Text = "Filtrar por stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 82, 158);
            label2.Location = new Point(21, 70);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 5;
            label2.Text = "Filtrar por precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 82, 158);
            label3.Location = new Point(164, 70);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 9;
            label3.Text = "Mín:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 82, 158);
            label4.Location = new Point(347, 70);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 10;
            label4.Text = "Máx:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 82, 158);
            label5.Location = new Point(732, 70);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 14;
            label5.Text = "Mín:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 82, 158);
            label6.Location = new Point(914, 70);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 15;
            label6.Text = "Máx:";
            // 
            // nudStockMax
            // 
            nudStockMax.Location = new Point(968, 66);
            nudStockMax.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudStockMax.Name = "nudStockMax";
            nudStockMax.Size = new Size(120, 27);
            nudStockMax.TabIndex = 5;
            nudStockMax.ThousandsSeparator = true;
            nudStockMax.Leave += nudStockMax_Leave;
            // 
            // nudStockMin
            // 
            nudStockMin.Location = new Point(782, 66);
            nudStockMin.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudStockMin.Name = "nudStockMin";
            nudStockMin.Size = new Size(120, 27);
            nudStockMin.TabIndex = 16;
            nudStockMin.ThousandsSeparator = true;
            nudStockMin.Leave += nudStockMin_Leave;
            // 
            // nudPrecioMax
            // 
            nudPrecioMax.Location = new Point(401, 66);
            nudPrecioMax.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrecioMax.Name = "nudPrecioMax";
            nudPrecioMax.Size = new Size(120, 27);
            nudPrecioMax.TabIndex = 17;
            nudPrecioMax.ThousandsSeparator = true;
            nudPrecioMax.ValueChanged += nudPrecioMax_ValueChanged;
            nudPrecioMax.Leave += nudPrecioMax_Leave;
            // 
            // nudPrecioMin
            // 
            nudPrecioMin.Location = new Point(214, 66);
            nudPrecioMin.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudPrecioMin.Name = "nudPrecioMin";
            nudPrecioMin.Size = new Size(120, 27);
            nudPrecioMin.TabIndex = 18;
            nudPrecioMin.ThousandsSeparator = true;
            nudPrecioMin.ValueChanged += nudPrecioMin_ValueChanged;
            nudPrecioMin.Leave += nudPrecioMin_Leave;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 450);
            Controls.Add(nudPrecioMin);
            Controls.Add(nudPrecioMax);
            Controls.Add(nudStockMin);
            Controls.Add(nudStockMax);
            Controls.Add(label6);
            Controls.Add(lblBuscar);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(flowBotones);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosForm";
            Text = "ProductosForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            flowBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudStockMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvProductos;
        private FlowLayoutPanel flowBotones;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudStockMax;
        private NumericUpDown nudStockMin;
        private NumericUpDown nudPrecioMax;
        private NumericUpDown nudPrecioMin;
    }
}