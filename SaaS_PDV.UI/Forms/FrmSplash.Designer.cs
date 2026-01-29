namespace SaaS_PDV.UI.Forms
{
    partial class FrmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            title = new Label();
            subtext = new Label();
            lblStatus = new Label();
            pnlBarraFundo = new Panel();
            pnlProgresso = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlBarraFundo.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(192, 134);
            title.Name = "title";
            title.Size = new Size(197, 54);
            title.TabIndex = 0;
            title.Text = "PDV PRO";
            // 
            // subtext
            // 
            subtext.AutoSize = true;
            subtext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtext.ForeColor = Color.Silver;
            subtext.Location = new Point(112, 188);
            subtext.Name = "subtext";
            subtext.Size = new Size(350, 23);
            subtext.TabIndex = 1;
            subtext.Text = "Gestão Inteligente para Múltiplos Ambientes";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(12, 321);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(147, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Inicializando sitema...";
            // 
            // pnlBarraFundo
            // 
            pnlBarraFundo.BackColor = Color.FromArgb(45, 45, 55);
            pnlBarraFundo.Controls.Add(pnlProgresso);
            pnlBarraFundo.Dock = DockStyle.Bottom;
            pnlBarraFundo.Location = new Point(0, 346);
            pnlBarraFundo.Name = "pnlBarraFundo";
            pnlBarraFundo.Size = new Size(600, 4);
            pnlBarraFundo.TabIndex = 3;
            // 
            // pnlProgresso
            // 
            pnlProgresso.BackColor = Color.FromArgb(0, 122, 204);
            pnlProgresso.Location = new Point(0, 0);
            pnlProgresso.Name = "pnlProgresso";
            pnlProgresso.Size = new Size(10, 4);
            pnlProgresso.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 32);
            ClientSize = new Size(600, 350);
            Controls.Add(pnlBarraFundo);
            Controls.Add(lblStatus);
            Controls.Add(subtext);
            Controls.Add(title);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSplash";
            pnlBarraFundo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label title;
        private Label subtext;
        private Label lblStatus;
        private Panel pnlBarraFundo;
        private Panel pnlProgresso;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}