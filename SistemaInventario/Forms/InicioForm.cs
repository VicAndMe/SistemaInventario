using SistemaInventario;
using SistemaInventario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaInventario.Forms
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();

            lblUsuarioActual.Text = Sesion.Usuario.ToUpper();

            CentrarPanel();
        }

        private void CentrarPanel()
        {
            panelContenido.Left =
                (this.ClientSize.Width -
                panelContenido.Width) / 2;

            panelContenido.Top =
                (this.ClientSize.Height -
                panelContenido.Height) / 2;
        }

        private void InicioForm_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        
    }
}
