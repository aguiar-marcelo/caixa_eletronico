using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCO
{
    public partial class Login : Form
    {
        string controle = "0123456789";
        int erro = 1;
        public Login()
        {
            InitializeComponent();
            txtAgencia.MaxLength = 4;
            txtConta.MaxLength = 5;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
               string conta, agencia;
            agencia = "4567";
            conta = "45678";

            if (txtAgencia.Text == agencia && txtConta.Text == conta)
            {
                Conta form2 = new Conta();
                form2.Show();
                Hide();
            }
            else
            {
                if (erro == 3)
                {
                    Close();
                }
                else
                {

                    lblErro.Visible = true;
                    txtAgencia.Text = null;
                    txtConta.Text = null;
                    erro++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }
        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!controle.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!controle.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
