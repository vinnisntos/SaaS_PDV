using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
