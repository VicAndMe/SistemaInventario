using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaInventario.Forms;

namespace SistemaInventario.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnCerrarSesion.Top = panelMenu.Height - btnCerrarSesion.Height - 30;

            this.WindowState = FormWindowState.Maximized;

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            AbrirFormulario(new InicioForm());
        }

        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ProductosForm());
        }

        private void btnAlmacenes_Click(
    object sender,
    EventArgs e)
        {
            AbrirFormulario(
                new AlmacenesForm()
            );
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new InicioForm());
        }

        private void btnCerrarSesion_Click(
    object sender,
    EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Desea cerrar sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                LoginForm login =
                    new LoginForm();

                login.Show();

                this.Close();
            }
        }
    }
}