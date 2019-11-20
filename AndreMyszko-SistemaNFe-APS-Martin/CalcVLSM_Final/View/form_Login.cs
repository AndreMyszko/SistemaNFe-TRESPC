using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trabalho2Bim;

namespace Trabalho2Bim
{
    public partial class form_login : Form
    {
        login_Cliente client = new login_Cliente();
        List<login_Cliente> listCliente = new List<login_Cliente>();

        public form_login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Boolean login = false;
            login = findUser(txt_logLogin.Text, txt_logSenha.Text);
            if (login == true)
            {
                MessageBox.Show($"Bem vindo {client.client_nome}, login efetuado com sucesso!");
                this.Hide();
                CalcVLSM_Final.ViewCalc areaRestrita = new CalcVLSM_Final.ViewCalc();
                areaRestrita.Show();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado, insira um login utilizável ou cadastre-se abaixo.");
            }
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            login_Cliente client = new login_Cliente();

            client.client_nome = txt_cadLogin.Text;
            client.client_senha = txt_cadSenha.Text;
            listCliente.Add(client);

            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        public Boolean findUser(string logNome, string logPass)
        {
            login_Cliente userName = (listCliente.Find(x => x.client_nome.Contains(logNome)));
            login_Cliente userPass = (listCliente.Find(x => x.client_senha.Contains(logPass)));

            if (userName != null && userPass != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
