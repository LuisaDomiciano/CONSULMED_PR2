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

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrEmpty(codigoDigitado) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o código está correto
            if (codigoDigitado != RecoveryStorage.CodigoRecuperacao)
            {
                MessageBox.Show("O código de recuperação está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as senhas coincidem
            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atualiza a senha no banco de dados
            string emailUsuario = RecoveryStorage.EmailRecuperacao;
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";
            string query = "UPDATE PaginaLog SET Senha_PagLog = @NovaSenha WHERE Nome_PagLog = @Email OR Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NovaSenha", novaSenha);
                        cmd.Parameters.AddWithValue("@Email", emailUsuario);
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpa dados temporários
                            RecoveryStorage.EmailRecuperacao = string.Empty;
                            RecoveryStorage.CodigoRecuperacao = string.Empty;

                            // Volta para a tela de login
                            this.Hide();
                            TxtLoginLog login = new TxtLoginLog();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar a senha. Verifique o e-mail cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao redefinir a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

