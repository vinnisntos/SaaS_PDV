using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SaaS_PDV.UI.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            // Configurando os ícones nos campos do Guna2
            txtAmbiente.IconLeft = IconChar.Building.ToBitmap(Color.Silver, 20);
            txtUsuario.IconLeft = IconChar.User.ToBitmap(Color.Silver, 20);
            txtSenha.IconLeft = IconChar.Lock.ToBitmap(Color.Silver, 20);

            // Dica: Use IconLeftOffset para dar um respiro entre o ícone e a borda
            txtAmbiente.IconLeftOffset = new Point(5, 0);
            txtUsuario.IconLeftOffset = new Point(5, 0);
            txtSenha.IconLeftOffset = new Point(5, 0);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string ambiente = txtAmbiente.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // validação de campos vazios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(ambiente))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login usando banco de dados Azure
            using (var context = new SaaS_PDV.Data.AppDbContext())
            {
                var user = context.Usuarios
                                  .FirstOrDefault(u => u.Login == usuario && u.Senha == senha);
                if (user != null)
                {
                    // Login bem-sucedido
                    MessageBox.Show($"Bem-vindo, {user.Nome}!", "Login Bem-Sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aqui você pode abrir a próxima tela do sistema
                    var dashboard = new MainDashboard();
                    dashboard.Show();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Login falhou
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
