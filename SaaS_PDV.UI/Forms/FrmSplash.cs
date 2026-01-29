using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace SaaS_PDV.UI.Forms
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        // Este evento roda a cada 30ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. Aumenta a largura da barra azul
            pnlProgresso.Width += 5; // Cresce 5 pixels por vez

            // 2. Simula textos de carregamento para parecer profissional
            if (pnlProgresso.Width > 100 && pnlProgresso.Width < 250)
            {
                lblStatus.Text = "Verificando banco de dados...";
            }
            else if (pnlProgresso.Width > 250 && pnlProgresso.Width < 450)
            {
                lblStatus.Text = "Carregando configurações do ambiente...";
            }
            else if (pnlProgresso.Width > 450)
            {
                lblStatus.Text = "Finalizando...";
            }

            // 3. Verifica se a barra chegou no final da tela
            if (pnlProgresso.Width >= this.Width)
            {
                // Para o timer
                timer1.Stop();

                // Fecha o Splash com sucesso. 
                // O Program.cs vai entender que pode abrir o Login agora.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}