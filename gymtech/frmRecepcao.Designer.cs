namespace gymtech
{
    partial class frmRecepcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcao));
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnRemoverAluno = new System.Windows.Forms.Button();
            this.lblRemAluno = new System.Windows.Forms.Label();
            this.btnCadProfessor = new System.Windows.Forms.Button();
            this.btnRemProfessor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.checkCpf = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.Location = new System.Drawing.Point(27, 44);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(70, 24);
            this.lblApresentacao.TabIndex = 0;
            this.lblApresentacao.Text = "Label";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(654, 28);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(87, 40);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.checkCpf);
            this.panel1.Controls.Add(this.checkNome);
            this.panel1.Controls.Add(this.lblBusca);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnRemProfessor);
            this.panel1.Controls.Add(this.btnCadProfessor);
            this.panel1.Controls.Add(this.lblRemAluno);
            this.panel1.Controls.Add(this.btnRemoverAluno);
            this.panel1.Controls.Add(this.lblSelecione);
            this.panel1.Controls.Add(this.btnCadAluno);
            this.panel1.Location = new System.Drawing.Point(31, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 452);
            this.panel1.TabIndex = 2;
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadAluno.Location = new System.Drawing.Point(26, 131);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(130, 78);
            this.btnCadAluno.TabIndex = 0;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(13, 10);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(238, 24);
            this.lblSelecione.TabIndex = 2;
            this.lblSelecione.Text = "Selecione sua opção";
            // 
            // btnRemoverAluno
            // 
            this.btnRemoverAluno.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverAluno.Location = new System.Drawing.Point(26, 284);
            this.btnRemoverAluno.Name = "btnRemoverAluno";
            this.btnRemoverAluno.Size = new System.Drawing.Size(130, 78);
            this.btnRemoverAluno.TabIndex = 3;
            this.btnRemoverAluno.Text = "Remover Aluno";
            this.btnRemoverAluno.UseVisualStyleBackColor = true;
            this.btnRemoverAluno.Click += new System.EventHandler(this.btnRemoverAluno_Click);
            // 
            // lblRemAluno
            // 
            this.lblRemAluno.AutoSize = true;
            this.lblRemAluno.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemAluno.Location = new System.Drawing.Point(23, 266);
            this.lblRemAluno.Name = "lblRemAluno";
            this.lblRemAluno.Size = new System.Drawing.Size(0, 15);
            this.lblRemAluno.TabIndex = 4;
            // 
            // btnCadProfessor
            // 
            this.btnCadProfessor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProfessor.Location = new System.Drawing.Point(204, 131);
            this.btnCadProfessor.Name = "btnCadProfessor";
            this.btnCadProfessor.Size = new System.Drawing.Size(130, 78);
            this.btnCadProfessor.TabIndex = 5;
            this.btnCadProfessor.Text = "Cadastrar Professor";
            this.btnCadProfessor.UseVisualStyleBackColor = true;
            this.btnCadProfessor.Click += new System.EventHandler(this.btnCadProfessor_Click);
            // 
            // btnRemProfessor
            // 
            this.btnRemProfessor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemProfessor.Location = new System.Drawing.Point(204, 284);
            this.btnRemProfessor.Name = "btnRemProfessor";
            this.btnRemProfessor.Size = new System.Drawing.Size(130, 78);
            this.btnRemProfessor.TabIndex = 6;
            this.btnRemProfessor.Text = "Remover Professor";
            this.btnRemProfessor.UseVisualStyleBackColor = true;
            this.btnRemProfessor.Click += new System.EventHandler(this.btnRemProfessor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(407, 214);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(109, 13);
            this.lblBusca.TabIndex = 8;
            this.lblBusca.Text = "Procurar Cadastro";
            // 
            // checkNome
            // 
            this.checkNome.AutoSize = true;
            this.checkNome.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNome.Location = new System.Drawing.Point(407, 265);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(50, 17);
            this.checkNome.TabIndex = 9;
            this.checkNome.Text = "NOME";
            this.checkNome.UseVisualStyleBackColor = true;
            this.checkNome.CheckedChanged += new System.EventHandler(this.checkNome_CheckedChanged);
            // 
            // checkCpf
            // 
            this.checkCpf.AutoSize = true;
            this.checkCpf.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCpf.Location = new System.Drawing.Point(467, 265);
            this.checkCpf.Name = "checkCpf";
            this.checkCpf.Size = new System.Drawing.Size(44, 17);
            this.checkCpf.TabIndex = 10;
            this.checkCpf.Text = "CPF";
            this.checkCpf.UseVisualStyleBackColor = true;
            this.checkCpf.CheckedChanged += new System.EventHandler(this.checkCpf_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(586, 261);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmRecepcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblApresentacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecepcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM TECH - Menu Recepção";
            this.Load += new System.EventHandler(this.frmRecepcao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btnRemoverAluno;
        private System.Windows.Forms.Label lblRemAluno;
        private System.Windows.Forms.Button btnRemProfessor;
        private System.Windows.Forms.Button btnCadProfessor;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkNome;
        private System.Windows.Forms.CheckBox checkCpf;
        private System.Windows.Forms.Button btnBuscar;
    }
}