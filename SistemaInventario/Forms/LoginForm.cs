using SistemaInventario.Forms;
using SistemaInventario.Helpers;
using SistemaInventario.Services;
using SistemaInventario.Utils;
namespace SistemaInventario
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService;

        public LoginForm()
        {
            InitializeComponent();

            authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            bool loginCorrecto = authService.Login(usuario, password);
            string rol = authService.ObtenerRol(usuario);

            if (loginCorrecto)
            {


                Sesion.Usuario = usuario;
                Sesion.Rol = rol;

                MainForm mainForm = new MainForm();

                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
    }
}