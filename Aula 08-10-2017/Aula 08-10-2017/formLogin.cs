using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula_08_10_2017
{
    public partial class formLogin : Form
    {

        public formLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "doctum" && txtSenha.Text == "123mudar")
            {
                this.Size = new Size(336, 400);
                lblNome.Enabled = false;
                lblSenha.Enabled = false;
                txtNome.Text = null;
                txtSenha.Text = null;
                txtNome.Enabled = false;
                txtSenha.Enabled = false;

            }
            else
            {

                MessageBox.Show("Nome ou Senha incorretos !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: doctum\nSenha: 123mudar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(336, 137);
            lblNome.Enabled = true;
            lblSenha.Enabled = true;
            txtNome.Text = null;
            txtSenha.Text = null;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(336, 137);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = null;
            rdbSexo1.Checked = false;
            rdbSexo2.Checked = false;
            cboCargo.SelectedIndex = -1;
            ltbEstadoCivil.SelectedIndex = -1;
        }
    }
}