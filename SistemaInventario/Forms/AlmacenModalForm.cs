using SistemaInventario.Services;

namespace SistemaInventario.Forms
{
    public partial class AlmacenModalForm : Form
    {
        private int idAlmacen = 0;

        private readonly AlmacenService almacenService;

        public AlmacenModalForm()
        {
            InitializeComponent();

            almacenService =
                new AlmacenService();
        }

        public AlmacenModalForm(
            int id,
            string nombre,
            string ubicacion)
        {
            InitializeComponent();

            almacenService =
                new AlmacenService();

            idAlmacen = id;

            txtNombre.Text = nombre;

            txtUbicacion.Text =
                ubicacion;
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            string nombre =
                txtNombre.Text;

            string ubicacion =
                txtUbicacion.Text;

            if (idAlmacen == 0)
            {
                almacenService
                    .AgregarAlmacen(
                        nombre,
                        ubicacion
                    );

                MessageBox.Show(
                    "Almacén agregado correctamente"
                );
            }
            else
            {
                almacenService
                    .ModificarAlmacen(
                        idAlmacen,
                        nombre,
                        ubicacion
                    );

                MessageBox.Show(
                    "Almacén modificado correctamente"
                );
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre"
                );

                txtNombre.Focus();

                return;
            }

            if (txtUbicacion.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese una ubicación"
                );

                txtUbicacion.Focus();

                return;
            }

            this.Close();
        }
    }
}