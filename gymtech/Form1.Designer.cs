namespace gymtech
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.pnNoticias = new System.Windows.Forms.Panel();
            this.pnImagens = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.checkSenha = new System.Windows.Forms.CheckBox();
            this.picNoticias = new System.Windows.Forms.PictureBox();
            this.pnImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(483, 531);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(140, 15);
            this.lblEsqueciSenha.TabIndex = 11;
            this.lblEsqueciSenha.TabStop = true;
            this.lblEsqueciSenha.Text = "Esqueci minha senha";
            this.lblEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueciSenha_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(420, 479);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(263, 41);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(420, 422);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(42, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Senha";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(420, 370);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 15);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuário";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(420, 440);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(263, 26);
            this.txbPassword.TabIndex = 7;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(420, 388);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(263, 26);
            this.txbUser.TabIndex = 6;
            // 
            // pnNoticias
            // 
            this.pnNoticias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNoticias.Location = new System.Drawing.Point(423, 12);
            this.pnNoticias.Name = "pnNoticias";
            this.pnNoticias.Size = new System.Drawing.Size(349, 346);
            this.pnNoticias.TabIndex = 12;
            // 
            // pnImagens
            // 
            this.pnImagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImagens.Controls.Add(this.picNoticias);
            this.pnImagens.Location = new System.Drawing.Point(8, 13);
            this.pnImagens.Name = "pnImagens";
            this.pnImagens.Size = new System.Drawing.Size(406, 507);
            this.pnImagens.TabIndex = 13;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(90, 532);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(229, 13);
            this.lblCopyright.TabIndex = 14;
            this.lblCopyright.Text = "Gym Tech - Sistema de Treino para Academias";
            // 
            // checkSenha
            // 
            this.checkSenha.AutoSize = true;
            this.checkSenha.Location = new System.Drawing.Point(689, 445);
            this.checkSenha.Name = "checkSenha";
            this.checkSenha.Size = new System.Drawing.Size(95, 17);
            this.checkSenha.TabIndex = 15;
            this.checkSenha.Text = "Mostrar Senha";
            this.checkSenha.UseVisualStyleBackColor = true;
            this.checkSenha.CheckedChanged += new System.EventHandler(this.checkSenha_CheckedChanged);
            // 
            // picNoticias
            // 
            this.picNoticias.Location = new System.Drawing.Point(14, 13);
            this.picNoticias.Name = "picNoticias";
            this.picNoticias.Size = new System.Drawing.Size(374, 475);
            this.picNoticias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoticias.TabIndex = 0;
            this.picNoticias.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 561);
            this.Controls.Add(this.checkSenha);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.pnImagens);
            this.Controls.Add(this.pnNoticias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM TECH - Tela de Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNoticias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblEsqueciSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Panel pnNoticias;
        private System.Windows.Forms.Panel pnImagens;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.CheckBox checkSenha;
        private System.Windows.Forms.PictureBox picNoticias;
    }
}

