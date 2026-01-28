using SaaS_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaaS_PDV
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        // ... outras partes do código ...

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarregamento.Value < 100)
            {
                pbCarregamento.Value += 2;
            }
            else
            {
                timer1.Stop();
                FrmLogin telaLogin = new FrmLogin();
                telaLogin.Show();
                this.Hide();
            }
        }

        // ... o resto do código ...

        private void pbbarCharging_Click(object sender, EventArgs e)
        {

        }
    }
}