namespace Aula_08_10_2017
{
    partial class formLogin
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.rdbSexo2 = new System.Windows.Forms.RadioButton();
            this.rdbSexo1 = new System.Windows.Forms.RadioButton();
            this.ltbEstadoCivil = new System.Windows.Forms.ListBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 12);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(168, 15);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(211, 12);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(13, 58);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(106, 23);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(141, 58);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(274, 58);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(34, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(211, 316);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 44;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Advogado",
            "Médico",
            "Analista de Sistemas",
            "Gerente",
            "TI"});
            this.cboCargo.Location = new System.Drawing.Point(101, 141);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(158, 21);
            this.cboCargo.TabIndex = 43;
            // 
            // rdbSexo2
            // 
            this.rdbSexo2.AutoSize = true;
            this.rdbSexo2.Location = new System.Drawing.Point(186, 169);
            this.rdbSexo2.Name = "rdbSexo2";
            this.rdbSexo2.Size = new System.Drawing.Size(73, 17);
            this.rdbSexo2.TabIndex = 42;
            this.rdbSexo2.TabStop = true;
            this.rdbSexo2.Text = "Masculino";
            this.rdbSexo2.UseVisualStyleBackColor = true;
            // 
            // rdbSexo1
            // 
            this.rdbSexo1.AutoSize = true;
            this.rdbSexo1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbSexo1.Location = new System.Drawing.Point(102, 169);
            this.rdbSexo1.Name = "rdbSexo1";
            this.rdbSexo1.Size = new System.Drawing.Size(67, 17);
            this.rdbSexo1.TabIndex = 41;
            this.rdbSexo1.TabStop = true;
            this.rdbSexo1.Text = "Feminino";
            this.rdbSexo1.UseVisualStyleBackColor = true;
            // 
            // ltbEstadoCivil
            // 
            this.ltbEstadoCivil.FormattingEnabled = true;
            this.ltbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viuvo(a)",
            "Divorciado(a)",
            "União Estável"});
            this.ltbEstadoCivil.Location = new System.Drawing.Point(102, 200);
            this.ltbEstadoCivil.Name = "ltbEstadoCivil";
            this.ltbEstadoCivil.Size = new System.Drawing.Size(157, 95);
            this.ltbEstadoCivil.TabIndex = 40;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(102, 109);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(157, 20);
            this.txtSalario.TabIndex = 39;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(121, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(28, 316);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 37;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(23, 200);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 36;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(23, 171);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 35;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(23, 144);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 34;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(23, 112);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 33;
            this.lblSalario.Text = "Salário:";
            // 
            // formLogin
            // 
            this.AcceptButton = this.btnValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(320, 361);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.rdbSexo2);
            this.Controls.Add(this.rdbSexo1);
            this.Controls.Add(this.ltbEstadoCivil);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.RadioButton rdbSexo2;
        private System.Windows.Forms.RadioButton rdbSexo1;
        private System.Windows.Forms.ListBox ltbEstadoCivil;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalario;
    }
}

