﻿namespace gymtech
{
    partial class frmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.lblUserLogado = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMeusTreinos = new System.Windows.Forms.Label();
            this.comboTreinos = new System.Windows.Forms.ComboBox();
            this.lblCelularUsuario = new System.Windows.Forms.Label();
            this.lblDataUsuario = new System.Windows.Forms.Label();
            this.lblBairroUsuario = new System.Windows.Forms.Label();
            this.lblCepUsuario = new System.Windows.Forms.Label();
            this.lblEndCompUsuario = new System.Windows.Forms.Label();
            this.lblEndNumUsuario = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndComp = new System.Windows.Forms.Label();
            this.lblEndNum = new System.Windows.Forms.Label();
            this.lblEndUsuario = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblMeusDados = new System.Windows.Forms.Label();
            this.lblRgUsuario = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpfUsuario = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.Panel();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.comboResultado = new System.Windows.Forms.ComboBox();
            this.txbNivel = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbSeries = new System.Windows.Forms.TextBox();
            this.txbRep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogado.Location = new System.Drawing.Point(12, 40);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(160, 22);
            this.lblUserLogado.TabIndex = 35;
            this.lblUserLogado.Text = "Usuário logado:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(675, 27);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(97, 35);
            this.btnDesconectar.TabIndex = 34;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.Location = new System.Drawing.Point(168, 40);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(60, 22);
            this.lblApresentacao.TabIndex = 33;
            this.lblApresentacao.Text = "label";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMeusTreinos);
            this.panel1.Controls.Add(this.comboTreinos);
            this.panel1.Controls.Add(this.lblCelularUsuario);
            this.panel1.Controls.Add(this.lblDataUsuario);
            this.panel1.Controls.Add(this.lblBairroUsuario);
            this.panel1.Controls.Add(this.lblCepUsuario);
            this.panel1.Controls.Add(this.lblEndCompUsuario);
            this.panel1.Controls.Add(this.lblEndNumUsuario);
            this.panel1.Controls.Add(this.lblCelular);
            this.panel1.Controls.Add(this.lblDataNasc);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.lblEndComp);
            this.panel1.Controls.Add(this.lblEndNum);
            this.panel1.Controls.Add(this.lblEndUsuario);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.lblMeusDados);
            this.panel1.Controls.Add(this.lblRgUsuario);
            this.panel1.Controls.Add(this.lblRg);
            this.panel1.Controls.Add(this.lblCpfUsuario);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.painel);
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 459);
            this.panel1.TabIndex = 36;
            // 
            // lblMeusTreinos
            // 
            this.lblMeusTreinos.AutoSize = true;
            this.lblMeusTreinos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusTreinos.Location = new System.Drawing.Point(484, 47);
            this.lblMeusTreinos.Name = "lblMeusTreinos";
            this.lblMeusTreinos.Size = new System.Drawing.Size(130, 22);
            this.lblMeusTreinos.TabIndex = 37;
            this.lblMeusTreinos.Text = "Meus Treinos";
            // 
            // comboTreinos
            // 
            this.comboTreinos.FormattingEnabled = true;
            this.comboTreinos.Location = new System.Drawing.Point(488, 72);
            this.comboTreinos.Name = "comboTreinos";
            this.comboTreinos.Size = new System.Drawing.Size(225, 21);
            this.comboTreinos.TabIndex = 55;
            this.comboTreinos.SelectedIndexChanged += new System.EventHandler(this.comboTreinos_SelectedIndexChanged);
            // 
            // lblCelularUsuario
            // 
            this.lblCelularUsuario.AutoSize = true;
            this.lblCelularUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularUsuario.Location = new System.Drawing.Point(115, 384);
            this.lblCelularUsuario.Name = "lblCelularUsuario";
            this.lblCelularUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblCelularUsuario.TabIndex = 54;
            this.lblCelularUsuario.Text = "label";
            // 
            // lblDataUsuario
            // 
            this.lblDataUsuario.AutoSize = true;
            this.lblDataUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataUsuario.Location = new System.Drawing.Point(195, 335);
            this.lblDataUsuario.Name = "lblDataUsuario";
            this.lblDataUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblDataUsuario.TabIndex = 53;
            this.lblDataUsuario.Text = "label";
            // 
            // lblBairroUsuario
            // 
            this.lblBairroUsuario.AutoSize = true;
            this.lblBairroUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroUsuario.Location = new System.Drawing.Point(105, 277);
            this.lblBairroUsuario.Name = "lblBairroUsuario";
            this.lblBairroUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblBairroUsuario.TabIndex = 52;
            this.lblBairroUsuario.Text = "label";
            // 
            // lblCepUsuario
            // 
            this.lblCepUsuario.AutoSize = true;
            this.lblCepUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepUsuario.Location = new System.Drawing.Point(75, 255);
            this.lblCepUsuario.Name = "lblCepUsuario";
            this.lblCepUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblCepUsuario.TabIndex = 51;
            this.lblCepUsuario.Text = "label";
            // 
            // lblEndCompUsuario
            // 
            this.lblEndCompUsuario.AutoSize = true;
            this.lblEndCompUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCompUsuario.Location = new System.Drawing.Point(155, 233);
            this.lblEndCompUsuario.Name = "lblEndCompUsuario";
            this.lblEndCompUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblEndCompUsuario.TabIndex = 50;
            this.lblEndCompUsuario.Text = "label";
            // 
            // lblEndNumUsuario
            // 
            this.lblEndNumUsuario.AutoSize = true;
            this.lblEndNumUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndNumUsuario.Location = new System.Drawing.Point(105, 211);
            this.lblEndNumUsuario.Name = "lblEndNumUsuario";
            this.lblEndNumUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblEndNumUsuario.TabIndex = 49;
            this.lblEndNumUsuario.Text = "label";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(19, 384);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(90, 22);
            this.lblCelular.TabIndex = 48;
            this.lblCelular.Text = "CELULAR:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(19, 335);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(170, 22);
            this.lblDataNasc.TabIndex = 47;
            this.lblDataNasc.Text = "DATA NASCIMENTO:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(19, 277);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(80, 22);
            this.lblBairro.TabIndex = 37;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(19, 255);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(50, 22);
            this.lblCep.TabIndex = 46;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndComp
            // 
            this.lblEndComp.AutoSize = true;
            this.lblEndComp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndComp.Location = new System.Drawing.Point(19, 233);
            this.lblEndComp.Name = "lblEndComp";
            this.lblEndComp.Size = new System.Drawing.Size(130, 22);
            this.lblEndComp.TabIndex = 45;
            this.lblEndComp.Text = "COMPLEMENTO:";
            // 
            // lblEndNum
            // 
            this.lblEndNum.AutoSize = true;
            this.lblEndNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndNum.Location = new System.Drawing.Point(19, 211);
            this.lblEndNum.Name = "lblEndNum";
            this.lblEndNum.Size = new System.Drawing.Size(80, 22);
            this.lblEndNum.TabIndex = 44;
            this.lblEndNum.Text = "NÚMERO:";
            // 
            // lblEndUsuario
            // 
            this.lblEndUsuario.AutoSize = true;
            this.lblEndUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndUsuario.Location = new System.Drawing.Point(125, 189);
            this.lblEndUsuario.Name = "lblEndUsuario";
            this.lblEndUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblEndUsuario.TabIndex = 43;
            this.lblEndUsuario.Text = "label";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(19, 189);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(100, 22);
            this.lblEndereco.TabIndex = 37;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblMeusDados
            // 
            this.lblMeusDados.AutoSize = true;
            this.lblMeusDados.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusDados.Location = new System.Drawing.Point(19, 18);
            this.lblMeusDados.Name = "lblMeusDados";
            this.lblMeusDados.Size = new System.Drawing.Size(110, 22);
            this.lblMeusDados.TabIndex = 37;
            this.lblMeusDados.Text = "Meus Dados";
            // 
            // lblRgUsuario
            // 
            this.lblRgUsuario.AutoSize = true;
            this.lblRgUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgUsuario.Location = new System.Drawing.Point(65, 135);
            this.lblRgUsuario.Name = "lblRgUsuario";
            this.lblRgUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblRgUsuario.TabIndex = 42;
            this.lblRgUsuario.Text = "label";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(19, 135);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(40, 22);
            this.lblRg.TabIndex = 41;
            this.lblRg.Text = "RG:";
            // 
            // lblCpfUsuario
            // 
            this.lblCpfUsuario.AutoSize = true;
            this.lblCpfUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfUsuario.Location = new System.Drawing.Point(75, 113);
            this.lblCpfUsuario.Name = "lblCpfUsuario";
            this.lblCpfUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblCpfUsuario.TabIndex = 40;
            this.lblCpfUsuario.Text = "label";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(19, 113);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(50, 22);
            this.lblCpf.TabIndex = 39;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(85, 69);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(60, 22);
            this.lblNomeUsuario.TabIndex = 38;
            this.lblNomeUsuario.Text = "label";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 22);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "NOME:";
            // 
            // painel
            // 
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel.Controls.Add(this.label5);
            this.painel.Controls.Add(this.label4);
            this.painel.Controls.Add(this.label3);
            this.painel.Controls.Add(this.label2);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.txbRep);
            this.painel.Controls.Add(this.txbSeries);
            this.painel.Controls.Add(this.txbPeso);
            this.painel.Controls.Add(this.txbNivel);
            this.painel.Controls.Add(this.lblSelecione);
            this.painel.Controls.Add(this.comboResultado);
            this.painel.Location = new System.Drawing.Point(488, 116);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(263, 338);
            this.painel.TabIndex = 57;
            this.painel.Visible = false;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(19, 12);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(220, 22);
            this.lblSelecione.TabIndex = 58;
            this.lblSelecione.Text = "Selecione o exercício";
            this.lblSelecione.Visible = false;
            // 
            // comboResultado
            // 
            this.comboResultado.FormattingEnabled = true;
            this.comboResultado.Location = new System.Drawing.Point(23, 37);
            this.comboResultado.Name = "comboResultado";
            this.comboResultado.Size = new System.Drawing.Size(225, 21);
            this.comboResultado.TabIndex = 56;
            this.comboResultado.Visible = false;
            this.comboResultado.SelectedIndexChanged += new System.EventHandler(this.comboResultado_SelectedIndexChanged);
            // 
            // txbNivel
            // 
            this.txbNivel.Location = new System.Drawing.Point(23, 119);
            this.txbNivel.Name = "txbNivel";
            this.txbNivel.Size = new System.Drawing.Size(174, 20);
            this.txbNivel.TabIndex = 59;
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(23, 187);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(89, 20);
            this.txbPeso.TabIndex = 60;
            // 
            // txbSeries
            // 
            this.txbSeries.Location = new System.Drawing.Point(23, 251);
            this.txbSeries.Name = "txbSeries";
            this.txbSeries.Size = new System.Drawing.Size(57, 20);
            this.txbSeries.TabIndex = 61;
            // 
            // txbRep
            // 
            this.txbRep.Location = new System.Drawing.Point(101, 251);
            this.txbRep.Name = "txbRep";
            this.txbRep.Size = new System.Drawing.Size(57, 20);
            this.txbRep.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nível";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Series";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Repetições";
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblUserLogado);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRgUsuario;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpfUsuario;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMeusDados;
        private System.Windows.Forms.Label lblEndNum;
        private System.Windows.Forms.Label lblEndUsuario;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndComp;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCelularUsuario;
        private System.Windows.Forms.Label lblDataUsuario;
        private System.Windows.Forms.Label lblBairroUsuario;
        private System.Windows.Forms.Label lblCepUsuario;
        private System.Windows.Forms.Label lblEndCompUsuario;
        private System.Windows.Forms.Label lblEndNumUsuario;
        private System.Windows.Forms.ComboBox comboTreinos;
        private System.Windows.Forms.Label lblMeusTreinos;
        private System.Windows.Forms.ComboBox comboResultado;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.TextBox txbSeries;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbNivel;
        private System.Windows.Forms.TextBox txbRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}