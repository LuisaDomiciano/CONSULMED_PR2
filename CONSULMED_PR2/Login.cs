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
            Inicio telaInicio = new Inicio();

            // Mostra o form de início
            telaInicio.Show();

            // Esconde ou fecha o form de login
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e);


        public partial class Login : Form
        {
            // Ajuste a string de conexão para o seu servidor/banco
            string connectionString = @"Server=sqlepress;Database=CJ3027392PR2;User Id=aluno;Password=aluno";

            public Login()
            {
  
            }

            private void btnEntrar_Click(object sender, EventArgs e)
            {
                string sql = @"INSERT INTO Login
                          (Nome_PagLog, Senha_PagLog)
                          VALUES (@NOME, @SENHA)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            // Pegando dados das TextBox
                            cmd.Parameters.AddWithValue("@NOME", TxtUsuarioLogin.Text);
                            cmd.Parameters.AddWithValue("@SENHA", TxtPasswordLogin.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Dados de login salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                }
            }
        }
    }


