using System;
using System.Data;
using System.Windows.Forms;
using SistemaInventario.Services;
using SistemaInventario.Helpers;
using System.Collections.Generic;

namespace SistemaInventario.Forms
{
    public partial class ProductosForm : Form
    {
        private readonly ProductoService productoService;

        private void ValidarRol()
        {
            if (Sesion.Rol == "ALMACENES")
            {
                btnAgregar.Visible = false;

                btnModificar.Visible = false;

                btnEliminar.Visible = false;
            }
        }

        public ProductosForm()
        {
            InitializeComponent();

            productoService = new ProductoService();

            CargarProductos();

            ValidarRol();

        }

        private void CargarProductos()
        {
            dgvProductos.DataSource =
                productoService.ObtenerProductos();

            dgvProductos.BorderStyle = BorderStyle.None;

            dgvProductos.BackgroundColor = Color.White;

            dgvProductos.RowHeadersVisible = false;

            dgvProductos.EnableHeadersVisualStyles = false;

            dgvProductos.AllowUserToResizeRows = false;

            dgvProductos.AllowUserToResizeColumns = false;

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 82, 158);

            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvProductos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvProductos.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvProductos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.MultiSelect = false;

            dgvProductos.ReadOnly = true;

            dgvProductos.AllowUserToAddRows = false;

            dgvProductos.Columns["id"].Visible = false;

            dgvProductos.Columns["nombre"].HeaderText = "Producto";

            dgvProductos.Columns["descripcion"].HeaderText = "Descripción";

            dgvProductos.Columns["cantidad"].HeaderText = "Stock";

            dgvProductos.Columns["precio"].HeaderText = "Precio";

            dgvProductos.Columns["almacen"].HeaderText = "Almacén";

            dgvProductos.Columns["fecha_hora_creacion"]
            .HeaderText = "Fecha de creación";

            dgvProductos.Columns["fecha_hora_ultima_modificacion"]
                .HeaderText = "Fecha de modificación";

            dgvProductos.Columns["ultimo_usuario_en_modificar"]
                .HeaderText = "Último en modificar";

            dgvProductos.Columns["almacen_id"]
           .Visible = false;
        }



        private void btnAgregar_Click(
    object sender,
    EventArgs e)
        {
            ProductoModalForm modal =
                new ProductoModalForm();

            modal.ShowDialog();

            CargarProductos();
        }

        private void btnModificar_Click(
    object sender,
    EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un producto"
                );

                return;
            }

            int id = Convert.ToInt32(
                dgvProductos.CurrentRow.Cells["id"].Value);

            string nombre =
                dgvProductos.CurrentRow
                .Cells["nombre"]
                .Value
                .ToString();

            string descripcion =
                dgvProductos.CurrentRow
                .Cells["descripcion"]
                .Value
                .ToString();

            int cantidad = Convert.ToInt32(
                dgvProductos.CurrentRow
                .Cells["cantidad"]
                .Value);

            decimal precio = Convert.ToDecimal(
                dgvProductos.CurrentRow
                .Cells["precio"]
                .Value);

            int idAlmacen = Convert.ToInt32(
                dgvProductos.CurrentRow
                .Cells["almacen_id"]
                .Value);

            ProductoModalForm modal =
                new ProductoModalForm(
                    id,
                    nombre,
                    descripcion,
                    cantidad,
                    precio,
                    idAlmacen
                );

            modal.ShowDialog();

            CargarProductos();
        }


        private void btnEliminar_Click(
    object sender,
    EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un producto"
                );

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(
                    dgvProductos.CurrentRow
                    .Cells["id"]
                    .Value);

                productoService
                    .EliminarProducto(id);

                MessageBox.Show(
                    "Producto eliminado correctamente"
                );

                CargarProductos();
            }
        }

        private void FiltrarProductos()
        {
            DataTable tabla =
                productoService.ObtenerProductos();

            DataView vista =
                tabla.DefaultView;

            List<string> filtros =
                new List<string>();

            string texto =
                txtBuscar.Text.Trim();

            if (texto != "")
            {
                filtros.Add(
                    $"nombre LIKE '%{texto}%' " +
                    $"OR descripcion LIKE '%{texto}%' " +
                    $"OR almacen LIKE '%{texto}%'"
                );
            }

            if (nudPrecioMin.Value > 0)
            {
                filtros.Add(
                    $"precio >= {nudPrecioMin.Value}"
                );
            }

            if (nudPrecioMax.Value > 0)
            {
                filtros.Add(
                    $"precio <= {nudPrecioMax.Value}"
                );
            }

            if (nudStockMin.Value > 0)
            {
                filtros.Add(
                    $"cantidad >= {nudStockMin.Value}"
                );
            }

            if (nudStockMax.Value > 0)
            {
                filtros.Add(
                    $"cantidad <= {nudStockMax.Value}"
                );
            }

            vista.RowFilter =
                string.Join(" AND ", filtros);

            dgvProductos.DataSource =
                vista;
        }

        private void txtBuscar_TextChanged(
    object sender,
    EventArgs e)
        {
            FiltrarProductos();
        }

        private void nudPrecioMin_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void nudPrecioMax_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void nudStockMax_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void nudStockMin_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void nudPrecioMin_Leave(
    object sender,
    EventArgs e)
        {
            if (nudPrecioMin.Text == "")
            {
                nudPrecioMin.Value = 0;
            }
        }

        private void nudPrecioMax_Leave(
    object sender,
    EventArgs e)
        {
            if (nudPrecioMax.Text == "")
            {
                nudPrecioMax.Value = 0;
            }
        }


        private void nudStockMin_Leave(
    object sender,
    EventArgs e)
        {
            if (nudStockMin.Text == "")
            {
                nudStockMin.Value = 0;
            }
        }

        private void nudStockMax_Leave(
    object sender,
    EventArgs e)
        {
            if (nudStockMax.Text == "")
            {
                nudStockMax.Value = 0;
            }
        }


    }
}