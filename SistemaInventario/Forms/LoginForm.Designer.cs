namespace SistemaInventario
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtUsuario = new TextBox();
            lbUsuario = new Label();
            lbLogin = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(lbPassword);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(lbUsuario);
            panelLogin.Controls.Add(lbLogin);
            panelLogin.Location = new Point(225, 100);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(350, 300);
            panelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(248, 187, 0);
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(97, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbPassword.Location = new Point(127, 173);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(86, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(46, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 26);
            txtUsuario.TabIndex = 2;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbUsuario.Location = new Point(136, 105);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(62, 20);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "Usuario";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(65, 20);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(218, 38);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Inicio de sesión";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 82, 158);
            ClientSize = new Size(782, 453);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lbUsuario;
        private Label lbLogin;
        private Label lbPassword;
        private TextBox txtUsuario;
        private Button btnLogin;
        private TextBox txtPassword;
    }
}
