namespace SaaS_PDV.Forms
{
    partial class FormCadastroEmpresa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtNomeFantasia = new TextBox();
            txtCNPJ = new MaskedTextBox();
            chkAtivo = new CheckBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(232, 120);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(232, 190);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome Fantasia: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(232, 264);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 2;
            label3.Text = "CNPJ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(232, 327);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Location = new Point(307, 119);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(116, 27);
            txtCodigo.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.CharacterCasing = CharacterCasing.Upper;
            txtNomeFantasia.Location = new Point(370, 189);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(179, 27);
            txtNomeFantasia.TabIndex = 5;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(296, 264);
            txtCNPJ.Mask = "00.000.000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(127, 27);
            txtCNPJ.TabIndex = 6;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(307, 328);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(203, 24);
            chkAtivo.TabIndex = 7;
            chkAtivo.Text = "Empresa Ativa no Sistema";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(225, 204, 0);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(307, 385);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 37);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(782, 553);
            Controls.Add(btnSalvar);
            Controls.Add(chkAtivo);
            Controls.Add(txtCNPJ);
            Controls.Add(txtNomeFantasia);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Cadastro de Empresa - Master Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtNomeFantasia;
        private MaskedTextBox txtCNPJ;
        private CheckBox chkAtivo;
        private Button btnSalvar;
    }
}