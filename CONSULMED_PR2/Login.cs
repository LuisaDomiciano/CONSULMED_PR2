using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONSULMED_PR2
{
    public partial class TxtLoginLog : Form
    {
        public TxtLoginLog()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLblNotAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)      
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }




        public partial class Login : Form
        {
            // Ajuste a string de conexão para o seu servidor/banco

            public Login()
            {

            }




            private void PictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnterLogin_Click(object sender, EventArgs e)
        {
      
            // Exemplo sem validação de usuário
            MenuPrincipalMedico menuMedico = new MenuPrincipalMedico();
            menuMedico.Show();
            this.Hide(); // esconde a tela de login
        }

    }
}



