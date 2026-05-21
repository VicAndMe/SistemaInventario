using SistemaInventario.Services;

namespace SistemaInventario.Forms
{
    public partial class ProductoModalForm : Form
    {
        private int idProducto = 0;

        private readonly ProductoService productoService;

        private readonly AlmacenService almacenService;


        public ProductoModalForm()
        {
            InitializeComponent();

            productoService =
                new ProductoService();

            almacenService =
                new AlmacenService();

            CargarAlmacenes();
        }
        public ProductoModalForm(
    int id,
    string nombre,
    string descripcion,
    int cantidad,
    decimal precio,
    int idAlmacen)
        {
            InitializeComponent();

            productoService =
                new ProductoService();

            almacenService =
                new AlmacenService();

            CargarAlmacenes();

            idProducto = id;

            txtNombre.Text = nombre;

            txtDescripcion.Text =
                descripcion;

            numCantidad.Value =
                cantidad;

            txtPrecio.Text =
                precio.ToString();

            cbAlmacen.SelectedValue =
                idAlmacen;
        }

        private void CargarAlmacenes()
        {
            cbAlmacen.DataSource =
                almacenService.ObtenerAlmacenes();

            cbAlmacen.DisplayMember =
                "nombre";

            cbAlmacen.ValueMember =
                "id";
        }

        private void btnGuardar_Click(
    object sender,
    EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre"
                );

                txtNombre.Focus();

                return;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese una descripción"
                );

                txtDescripcion.Focus();

                return;
            }

            if (!decimal.TryParse(
                txtPrecio.Text,
                out decimal precio))
            {
                MessageBox.Show(
                    "Ingrese un precio válido"
                );

                txtPrecio.Focus();

                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show(
                    "El precio debe ser mayor a 0"
                );

                txtPrecio.Focus();

                return;
            }

            if (numCantidad.Value < 0)
            {
                MessageBox.Show(
                    "La cantidad no puede ser negativa"
                );

                return;
            }

            string nombre =
                txtNombre.Text.Trim();

            string descripcion =
                txtDescripcion.Text.Trim();

            int cantidad =
                (int)numCantidad.Value;

            int idAlmacen =
                Convert.ToInt32(
                    cbAlmacen.SelectedValue);

            if (idProducto == 0)
            {
                productoService.AgregarProducto(
                    nombre,
                    descripcion,
                    cantidad,
                    precio,
                    idAlmacen
                );

                MessageBox.Show(
                    "Producto agregado correctamente"
                );
            }
            else
            {
                productoService.ModificarProducto(
                    idProducto,
                    nombre,
                    descripcion,
                    cantidad,
                    precio,
                    idAlmacen
                );

                MessageBox.Show(
                    "Producto modificado correctamente"
                );
            }


            if (cbAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un almacén"
                );

                cbAlmacen.Focus();

                return;
            }

            if (txtNombre.Text.Length > 100)
            {
                MessageBox.Show(
                    "El nombre es demasiado largo"
                );

                return;
            }

            this.Close();
        }

    }
}