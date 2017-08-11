using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula_08_10_2017
{
    public partial class formLogin2 : Form
    {

        public formLogin2()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSalario.Text = "";
            txtSenha.Text = "";
            rdbSexo1.Checked = false;
            rdbSexo2.Checked = false;
            cboCargo.SelectedIndex = -1;
            ltbEstadoCivil.SelectedIndex = -1;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form frmLogin = new formLogin();
            frmLogin.Show();
            this.Close();

        }

        private void formLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}