namespace Aula_08_10_2017
{
    partial class formLogin2
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cboCargo.Location = new System.Drawing.Point(86, 134);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(158, 21);
            this.cboCargo.TabIndex = 31;
            // 
            // rdbSexo2
            // 
            this.rdbSexo2.AutoSize = true;
            this.rdbSexo2.Location = new System.Drawing.Point(171, 162);
            this.rdbSexo2.Name = "rdbSexo2";
            this.rdbSexo2.Size = new System.Drawing.Size(73, 17);
            this.rdbSexo2.TabIndex = 30;
            this.rdbSexo2.TabStop = true;
            this.rdbSexo2.Text = "Masculino";
            this.rdbSexo2.UseVisualStyleBackColor = true;
            // 
            // rdbSexo1
            // 
            this.rdbSexo1.AutoSize = true;
            this.rdbSexo1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbSexo1.Location = new System.Drawing.Point(87, 162);
            this.rdbSexo1.Name = "rdbSexo1";
            this.rdbSexo1.Size = new System.Drawing.Size(67, 17);
            this.rdbSexo1.TabIndex = 29;
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
            this.ltbEstadoCivil.Location = new System.Drawing.Point(87, 193);
            this.ltbEstadoCivil.Name = "ltbEstadoCivil";
            this.ltbEstadoCivil.Size = new System.Drawing.Size(157, 95);
            this.ltbEstadoCivil.TabIndex = 28;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(87, 102);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(157, 20);
            this.txtSalario.TabIndex = 27;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(126, 309);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(33, 309);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 25;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(8, 193);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 24;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(8, 164);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(8, 137);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 22;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(8, 105);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário:";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(11, 58);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(298, 23);
            this.btnValidar.TabIndex = 20;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(209, 12);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.Text = "********";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(166, 15);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 18;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 12);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 17;
            this.txtNome.Text = "doctum";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(216, 309);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // formLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(324, 353);
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
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;

    }
}