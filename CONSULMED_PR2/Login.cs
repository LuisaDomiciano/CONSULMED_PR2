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

            // Capturar os valores digitados nas TextBox
            string nomeLogin = TxtUsuarioLogin.Text.Trim();
            string senhaLogin = TxtPasswordLogin.Text;

            // Validação simples
            if (string.IsNullOrEmpty(nomeLogin) || string.IsNullOrEmpty(senhaLogin))
            {
                MessageBox.Show("Por favor, preencha o login e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔍 Verificar se o login existe no banco
            string query = @"SELECT COUNT(*) FROM PaginaLog 
                     WHERE Nome_PagLog = @Nome_PagLog AND Senha_PagLog = @Senha_PagLog";

            // 💡 Colocando a conexão direto aqui
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome_PagLog", nomeLogin);
                    cmd.Parameters.AddWithValue("@Senha_PagLog", senhaLogin);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MenuPrincipalMedico menuMedico = new MenuPrincipalMedico();
                        menuMedico.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nome de login ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }




