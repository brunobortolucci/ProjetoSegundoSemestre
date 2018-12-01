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
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(107, 283);
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
            this.btnLogin.Location = new System.Drawing.Point(42, 227);
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
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 24);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Senha:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(38, 72);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 24);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuário";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(42, 170);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(263, 32);
            this.txbPassword.TabIndex = 7;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(42, 99);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(263, 32);
            this.txbUser.TabIndex = 6;
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.BackColor = System.Drawing.Color.White;
            this.btnMostrarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarSenha.BackgroundImage")));
            this.btnMostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarSenha.Location = new System.Drawing.Point(311, 171);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(31, 28);
            this.btnMostrarSenha.TabIndex = 12;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            this.btnMostrarSenha.MouseHover += new System.EventHandler(this.btnMostrarSenha_MouseHover);
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.btnMostrarSenha);
            this.pnLogin.Controls.Add(this.txbPassword);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.txbUser);
            this.pnLogin.Controls.Add(this.lblUser);
            this.pnLogin.Controls.Add(this.lblEsqueciSenha);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Location = new System.Drawing.Point(407, 236);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(365, 313);
            this.pnLogin.TabIndex = 13;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM TECH";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblEsqueciSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.Panel pnLogin;
    }
}

