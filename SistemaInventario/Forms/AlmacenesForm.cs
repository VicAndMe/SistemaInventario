using SistemaInventario.Helpers;
using SistemaInventario.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaInventario.Forms
{
    public partial class AlmacenesForm : Form
    {
        private readonly AlmacenService almacenService;

        private void ValidarRol()
        {
            if (Sesion.Rol == "PRODUCTOS")
            {
                btnAgregar.Visible = false;

                btnModificar.Visible = false;

                btnEliminar.Visible = false;
            }
        }

        public AlmacenesForm()
        {
            InitializeComponent();

            almacenService =
                new AlmacenService();

            CargarAlmacenes();

            txtBuscar.TextChanged += txtBuscar_TextChanged;

            ValidarRol();
        }

        private void CargarAlmacenes()
        {
            dgvAlmacenes.DataSource =
                almacenService.ObtenerAlmacenes();

            dgvAlmacenes.BorderStyle =
                BorderStyle.None;

            dgvAlmacenes.BackgroundColor =
                Color.White;

            dgvAlmacenes.RowHeadersVisible =
                false;

            dgvAlmacenes.EnableHeadersVisualStyles =
                false;

            dgvAlmacenes.AllowUserToResizeRows =
                false;

            dgvAlmacenes.AllowUserToResizeColumns =
                false;

            dgvAlmacenes.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 82, 158);

            dgvAlmacenes.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvAlmacenes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Bold);

            dgvAlmacenes.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvAlmacenes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlmacenes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAlmacenes.MultiSelect = false;

            dgvAlmacenes.ReadOnly = true;

            dgvAlmacenes.AllowUserToAddRows = false;

            dgvAlmacenes.Columns["id"]
                .Visible = false;

            dgvAlmacenes.Columns["nombre"]
                .HeaderText = "Almacén";

            dgvAlmacenes.Columns["ubicacion"]
                .HeaderText = "Ubicación";

            dgvAlmacenes.Columns["descripcion"]
    .HeaderText = "Descripción";

            dgvAlmacenes.Columns["fecha_hora_creacion"]
                .HeaderText = "Fecha de creación";

            dgvAlmacenes.Columns["fecha_hora_ultima_modificacion"]
                .HeaderText = "Fecha de modificación";

            dgvAlmacenes.Columns["ultimo_usuario_en_modificar"]
                .HeaderText = "Último en modificar";
        }

        private void btnAgregar_Click(
    object sender,
    EventArgs e)
        {
            AlmacenModalForm modal =
                new AlmacenModalForm();

            modal.ShowDialog();

            CargarAlmacenes();
        }


        private void btnModificar_Click(
    object sender,
    EventArgs e)
        {
            if (dgvAlmacenes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un almacén"
                );

                return;
            }

            int id = Convert.ToInt32(
                dgvAlmacenes.CurrentRow
                .Cells["id"]
                .Value);

            string nombre =
                dgvAlmacenes.CurrentRow
                .Cells["nombre"]
                .Value
                .ToString();

            string ubicacion =
                dgvAlmacenes.CurrentRow
                .Cells["ubicacion"]
                .Value
                .ToString();

            AlmacenModalForm modal =
                new AlmacenModalForm(
                    id,
                    nombre,
                    ubicacion
                );

            modal.ShowDialog();

            CargarAlmacenes();
        }

        private void btnEliminar_Click(
    object sender,
    EventArgs e)
        {
            if (dgvAlmacenes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un almacén"
                );

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro de eliminar este almacén?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(
                    dgvAlmacenes.CurrentRow
                    .Cells["id"]
                    .Value);

                almacenService
                    .EliminarAlmacen(id);

                MessageBox.Show(
                    "Almacén eliminado correctamente"
                );

                CargarAlmacenes();
            }
        }

        private void FiltrarAlmacenes()
        {
            DataTable tabla =
                almacenService.ObtenerAlmacenes();

            string texto =
                txtBuscar.Text
                .Trim()
                .ToLower();

            if (texto != "")
            {
                DataView vista =
                    tabla.DefaultView;

                vista.RowFilter =
                    $"nombre LIKE '%{texto}%' " +
                    $"OR ubicacion LIKE '%{texto}%' " +
                    $"OR descripcion LIKE '%{texto}%' " +
                    $"OR ultimo_usuario_en_modificar LIKE '%{texto}%'";

                dgvAlmacenes.DataSource =
                    vista;
            }
            else
            {
                dgvAlmacenes.DataSource =
                    tabla;
            }
        }

        private void txtBuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            FiltrarAlmacenes();
        }

        
    }
}