namespace gymtech
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            this.lblUserLogado = new System.Windows.Forms.Label();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarTreino = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnEditarTreino = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.checkCpf = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogado.Location = new System.Drawing.Point(12, 41);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(160, 22);
            this.lblUserLogado.TabIndex = 34;
            this.lblUserLogado.Text = "Usuário logado:";
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.Location = new System.Drawing.Point(168, 41);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(60, 22);
            this.lblApresentacao.TabIndex = 33;
            this.lblApresentacao.Text = "label";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(675, 28);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(97, 35);
            this.btnDesconectar.TabIndex = 35;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkCpf);
            this.panel1.Controls.Add(this.checkNome);
            this.panel1.Controls.Add(this.lblBusca);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnEditarTreino);
            this.panel1.Controls.Add(this.btnEditarAluno);
            this.panel1.Controls.Add(this.btnCadastrarTreino);
            this.panel1.Controls.Add(this.btnCadastrarAluno);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 457);
            this.panel1.TabIndex = 36;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(41, 101);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(174, 96);
            this.btnCadastrarAluno.TabIndex = 37;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarTreino
            // 
            this.btnCadastrarTreino.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTreino.Location = new System.Drawing.Point(41, 259);
            this.btnCadastrarTreino.Name = "btnCadastrarTreino";
            this.btnCadastrarTreino.Size = new System.Drawing.Size(174, 96);
            this.btnCadastrarTreino.TabIndex = 38;
            this.btnCadastrarTreino.Text = "Cadastrar Treino";
            this.btnCadastrarTreino.UseVisualStyleBackColor = true;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.Location = new System.Drawing.Point(261, 101);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(174, 96);
            this.btnEditarAluno.TabIndex = 39;
            this.btnEditarAluno.Text = "Editar Aluno";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            // 
            // btnEditarTreino
            // 
            this.btnEditarTreino.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTreino.Location = new System.Drawing.Point(261, 259);
            this.btnEditarTreino.Name = "btnEditarTreino";
            this.btnEditarTreino.Size = new System.Drawing.Size(174, 96);
            this.btnEditarTreino.TabIndex = 40;
            this.btnEditarTreino.Text = "Editar Treino";
            this.btnEditarTreino.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 41;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(662, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 32);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(487, 121);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(105, 15);
            this.lblBusca.TabIndex = 37;
            this.lblBusca.Text = "Procurar Aluno";
            // 
            // checkNome
            // 
            this.checkNome.AutoSize = true;
            this.checkNome.Location = new System.Drawing.Point(490, 166);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(58, 17);
            this.checkNome.TabIndex = 42;
            this.checkNome.Text = "NOME";
            this.checkNome.UseVisualStyleBackColor = true;
            // 
            // checkCpf
            // 
            this.checkCpf.AutoSize = true;
            this.checkCpf.Location = new System.Drawing.Point(554, 166);
            this.checkCpf.Name = "checkCpf";
            this.checkCpf.Size = new System.Drawing.Size(46, 17);
            this.checkCpf.TabIndex = 43;
            this.checkCpf.Text = "CPF";
            this.checkCpf.UseVisualStyleBackColor = true;
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserLogado);
            this.Controls.Add(this.lblApresentacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM TECH - Área do Professor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnCadastrarTreino;
        private System.Windows.Forms.Button btnEditarTreino;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.CheckBox checkCpf;
        private System.Windows.Forms.CheckBox checkNome;
    }
}