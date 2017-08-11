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
        Form frmLogin2 = new formLogin2();

        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "doctum" && txtSenha.Text == "123mudar")
            {

                frmLogin2.Show();
                this.Hide();
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
    }
}