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
    public static class RecoveryStorage
    {
        public static string EmailRecuperacao { get; set; } = string.Empty;
        public static string CodigoRecuperacao { get; set; } = string.Empty;
    }
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void RedefinirSenha_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOkRedefinirSenha_Click(object sender, EventArgs e)
        {
            string codigoDigitado = TxtCodigoRecuperacao.Text.Trim();
            string novaSenha = TxtNovaSenha.Text.Trim();
            string confirmarSenha = TxtConfirmeNovaSenha.Text.Trim();

            if (string.IsNullOrEmpty(codigoDigitado) ||
                string.IsNullOrEmpty(novaSenha) ||
                string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção");
                return;
            }

            // Verifica código
            if (codigoDigitado != RecoveryStorage.CodigoRecuperacao)
            {
                MessageBox.Show("Código incorreto.", "Erro");
                return;
            }

            // Verifica senhas
            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro");
                return;
            }

            string emailUsuario = RecoveryStorage.EmailRecuperacao;
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

            string query = "UPDATE PaginaLog SET Senha_PagLog = @NovaSenha WHERE Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NovaSenha", novaSenha);
                        cmd.Parameters.AddWithValue("@Email", emailUsuario);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Senha redefinida com sucesso!", "Sucesso");

                            RecoveryStorage.EmailRecuperacao = "";
                            RecoveryStorage.CodigoRecuperacao = "";

                            this.Hide();
                            new TxtLoginLog().Show();
                        }
                        else
                        {
                            MessageBox.Show("Email não encontrado.", "Erro");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

