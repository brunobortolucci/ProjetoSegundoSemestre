namespace gymtech
{
    partial class frmcadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadAluno));
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumEnd = new System.Windows.Forms.TextBox();
            this.lblNumEnd = new System.Windows.Forms.Label();
            this.txbCompEnd = new System.Windows.Forms.TextBox();
            this.lblCompEnd = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lblLoginOk = new System.Windows.Forms.Label();
            this.checkCalendario = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(55, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 22);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "NOME";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(59, 74);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(279, 30);
            this.txbNome.TabIndex = 24;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(55, 107);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 22);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF";
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(59, 132);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(279, 30);
            this.txbCpf.TabIndex = 26;
            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
            // 
            // txbRg
            // 
            this.txbRg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRg.Location = new System.Drawing.Point(59, 190);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(279, 30);
            this.txbRg.TabIndex = 27;
            this.txbRg.TextChanged += new System.EventHandler(this.txbRg_TextChanged);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(55, 165);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 22);
            this.lblRg.TabIndex = 28;
            this.lblRg.Text = "RG";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(55, 223);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(90, 22);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "ENDEREÇO";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(59, 248);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(279, 30);
            this.txbEndereco.TabIndex = 30;
            this.txbEndereco.TextChanged += new System.EventHandler(this.txbEndereco_TextChanged);
            // 
            // txbNumEnd
            // 
            this.txbNumEnd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumEnd.Location = new System.Drawing.Point(344, 248);
            this.txbNumEnd.Name = "txbNumEnd";
            this.txbNumEnd.Size = new System.Drawing.Size(86, 30);
            this.txbNumEnd.TabIndex = 31;
            this.txbNumEnd.TextChanged += new System.EventHandler(this.txbNumEnd_TextChanged);
            // 
            // lblNumEnd
            // 
            this.lblNumEnd.AutoSize = true;
            this.lblNumEnd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEnd.Location = new System.Drawing.Point(340, 223);
            this.lblNumEnd.Name = "lblNumEnd";
            this.lblNumEnd.Size = new System.Drawing.Size(40, 22);
            this.lblNumEnd.TabIndex = 32;
            this.lblNumEnd.Text = "NUM";
            // 
            // txbCompEnd
            // 
            this.txbCompEnd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompEnd.Location = new System.Drawing.Point(59, 306);
            this.txbCompEnd.Name = "txbCompEnd";
            this.txbCompEnd.Size = new System.Drawing.Size(279, 30);
            this.txbCompEnd.TabIndex = 33;
            // 
            // lblCompEnd
            // 
            this.lblCompEnd.AutoSize = true;
            this.lblCompEnd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompEnd.Location = new System.Drawing.Point(55, 281);
            this.lblCompEnd.Name = "lblCompEnd";
            this.lblCompEnd.Size = new System.Drawing.Size(120, 22);
            this.lblCompEnd.TabIndex = 34;
            this.lblCompEnd.Text = "COMPLEMENTO";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(55, 339);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 22);
            this.lblCep.TabIndex = 35;
            this.lblCep.Text = "CEP";
            // 
            // txbCep
            // 
            this.txbCep.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCep.Location = new System.Drawing.Point(59, 364);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(100, 30);
            this.txbCep.TabIndex = 36;
            this.txbCep.TextChanged += new System.EventHandler(this.txbCep_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(165, 339);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(70, 22);
            this.lblBairro.TabIndex = 37;
            this.lblBairro.Text = "BAIRRO";
            // 
            // txbBairro
            // 
            this.txbBairro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBairro.Location = new System.Drawing.Point(165, 364);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(173, 30);
            this.txbBairro.TabIndex = 38;
            this.txbBairro.TextChanged += new System.EventHandler(this.txbBairro_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(248, 397);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(190, 22);
            this.lblData.TabIndex = 39;
            this.lblData.Text = "DATA DE NASCIMENTO";
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(252, 422);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(173, 30);
            this.txbData.TabIndex = 40;
            this.txbData.TextChanged += new System.EventHandler(this.txbData_TextChanged);
            // 
            // txbCelular
            // 
            this.txbCelular.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCelular.Location = new System.Drawing.Point(59, 422);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(141, 30);
            this.txbCelular.TabIndex = 41;
            this.txbCelular.TextChanged += new System.EventHandler(this.txbCelular_TextChanged);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(55, 397);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(80, 22);
            this.lblCelular.TabIndex = 42;
            this.lblCelular.Text = "CELULAR";
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(59, 480);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(173, 30);
            this.txbLogin.TabIndex = 43;
            this.txbLogin.TextChanged += new System.EventHandler(this.txbLogin_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(55, 455);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(60, 22);
            this.lblLogin.TabIndex = 44;
            this.lblLogin.Text = "LOGIN";
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(252, 480);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(173, 30);
            this.txbSenha.TabIndex = 45;
            this.txbSenha.UseSystemPasswordChar = true;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(251, 455);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 22);
            this.lblSenha.TabIndex = 46;
            this.lblSenha.Text = "SENHA";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(59, 514);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 35);
            this.btnVerificar.TabIndex = 50;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(639, 456);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 80);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(450, 256);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 52;
            this.calendario.Visible = false;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // lblLoginOk
            // 
            this.lblLoginOk.AutoSize = true;
            this.lblLoginOk.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginOk.Location = new System.Drawing.Point(140, 525);
            this.lblLoginOk.Name = "lblLoginOk";
            this.lblLoginOk.Size = new System.Drawing.Size(67, 13);
            this.lblLoginOk.TabIndex = 53;
            this.lblLoginOk.Text = "Disponível";
            this.lblLoginOk.Visible = false;
            // 
            // checkCalendario
            // 
            this.checkCalendario.AutoSize = true;
            this.checkCalendario.Location = new System.Drawing.Point(431, 430);
            this.checkCalendario.Name = "checkCalendario";
            this.checkCalendario.Size = new System.Drawing.Size(95, 17);
            this.checkCalendario.TabIndex = 54;
            this.checkCalendario.Text = "Ver Calendário";
            this.checkCalendario.UseVisualStyleBackColor = true;
            this.checkCalendario.CheckedChanged += new System.EventHandler(this.checkCalendario_CheckedChanged);
            // 
            // frmcadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.checkCalendario);
            this.Controls.Add(this.lblLoginOk);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txbCelular);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblCompEnd);
            this.Controls.Add(this.txbCompEnd);
            this.Controls.Add(this.lblNumEnd);
            this.Controls.Add(this.txbNumEnd);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM TECH - Cadastro de Aluno";
            this.Load += new System.EventHandler(this.frmcadAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumEnd;
        private System.Windows.Forms.Label lblNumEnd;
        private System.Windows.Forms.TextBox txbCompEnd;
        private System.Windows.Forms.Label lblCompEnd;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label lblLoginOk;
        private System.Windows.Forms.CheckBox checkCalendario;
    }
}