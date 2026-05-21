namespace SistemaInventario.Forms
{
    partial class ProductoModalForm
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            numCantidad = new NumericUpDown();
            cbAlmacen = new ComboBox();
            btnGuardar = new Button();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblAlmacen = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(200, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 30);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(200, 118);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 30);
            txtDescripcion.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(200, 238);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(265, 30);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(200, 178);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(265, 30);
            numCantidad.TabIndex = 3;
            numCantidad.TextAlign = HorizontalAlignment.Right;
            numCantidad.Minimum = 0;

            // 
            // cbAlmacen
            // 
            cbAlmacen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlmacen.FormattingEnabled = true;
            cbAlmacen.Location = new Point(200, 298);
            cbAlmacen.Name = "cbAlmacen";
            cbAlmacen.Size = new Size(265, 31);
            cbAlmacen.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(217, 158, 48);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(334, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(0, 82, 158);
            lblNombre.Location = new Point(60, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(76, 23);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(0, 82, 158);
            lblDescripcion.Location = new Point(60, 120);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(103, 23);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(0, 82, 158);
            lblCantidad.Location = new Point(60, 180);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(0, 82, 158);
            lblPrecio.Location = new Point(60, 240);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 23);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // lblAlmacen
            // 
            lblAlmacen.AutoSize = true;
            lblAlmacen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAlmacen.ForeColor = Color.FromArgb(0, 82, 158);
            lblAlmacen.Location = new Point(60, 300);
            lblAlmacen.Name = "lblAlmacen";
            lblAlmacen.Size = new Size(79, 23);
            lblAlmacen.TabIndex = 10;
            lblAlmacen.Text = "Almacen";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 53, 69);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(100, 450);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ProductoModalForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(542, 521);
            Controls.Add(btnCancelar);
            Controls.Add(lblAlmacen);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(cbAlmacen);
            Controls.Add(numCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private NumericUpDown numCantidad;
        private ComboBox cbAlmacen;
        private Button btnGuardar;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblAlmacen;
        private Button btnCancelar;
    }
}