using CONSULMED_PR2;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CONSULMED_PR2
{
    public partial class CadastroPaciente : Form
    {
        // Ajuste a string de conexão para o seu servidor e banco
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

        // Comando SQL para inserir os dados
        private const string InsertSql = @"INSERT INTO CadastroPaciente
(NOME_PAC, CPF_PAC, EMAIL_PAC, TELEFONE_PAC, CODSUS_PAC, USUARIO_PAC, SENHA_PAC, CONFIRME_SENHA_PAC)
VALUES (@NOME_PAC, @CPF_PAC, @EMAIL_PAC, @TELEFONE_PAC, @CODSUS_PAC, @USUARIO_PAC, @SENHA_PAC, @CONFIRME_SENHA_PAC)";

        // Comando SQL para inserir também os dados de login
        private const string InsertLoginSql = @"INSERT INTO PaginaLog
(Nome_PagLog, Senha_PagLog)
VALUES (@USUARIO, @SENHA)";

        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            // O ComboBox começa invisível
            comboBoxAgreementPac.Visible = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            // Mostra o ComboBox somente se "Sim" estiver marcado
            if (radioButtonYes.Checked)
            {
                comboBoxAgreementPac.Visible = true;
            }
            else
            {
                comboBoxAgreementPac.Visible = false;
            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            // Esconde o ComboBox se "Não" estiver marcado
            if (radioButtonNo.Checked)
            {
                comboBoxAgreementPac.Visible = false;
            }
        }

        private void PictureBoxCadastroPac_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRegistrationPac_Click(object sender, EventArgs e)
        {
            // Ler valores das textboxes (ajuste nomes se necessário)
            string nomePac = txtNamePac.Text.Trim();
            string cpfPac = txtCpfPac.Text.Trim();
            string emailPac = txtEmailPac.Text.Trim();
            string telefonePac = txtFonePac.Text.Trim();
            string codSusPac = TxtCodSusPac.Text.Trim();
            string usuarioPac = txtUserPac.Text.Trim();
            string senhaPac = txtPasswordPac.Text;
            string confirmaPac = txtConfirmPasswordPac.Text;

            // Validações básicas
            if (string.IsNullOrEmpty(nomePac) || string.IsNullOrEmpty(cpfPac) || string.IsNullOrEmpty(usuarioPac) || string.IsNullOrEmpty(senhaPac))
            {
                MessageBox.Show("Por favor preencha os campos obrigatórios (Nome, CPF, Usuário, Senha).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senhaPac != confirmaPac)
            {
                MessageBox.Show("Senha e confirmação de senha não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converter valores opcionais para DBNull quando apropriado
            object dbCodConvenio = DBNull.Value;
            object dbCodSus = string.IsNullOrEmpty(codSusPac) ? DBNull.Value : (object)codSusPac;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(InsertSql, conn))
                {
                    // Adiciona parâmetros
                    cmd.Parameters.AddWithValue("@NOME_PAC", nomePac);
                    cmd.Parameters.AddWithValue("@CPF_PAC", cpfPac);
                    cmd.Parameters.AddWithValue("@EMAIL_PAC", emailPac);
                    cmd.Parameters.AddWithValue("@TELEFONE_PAC", telefonePac);
                    cmd.Parameters.AddWithValue("@CODSUS_PAC", codSusPac);
                    cmd.Parameters.AddWithValue("@USUARIO_PAC", usuarioPac);
                    cmd.Parameters.AddWithValue("@SENHA_PAC", senhaPac);
                    cmd.Parameters.AddWithValue("@CONFIRME_SENHA_PAC", confirmaPac);

                    conn.Open();

                    // Executa inserção na tabela de pacientes
                    int rows = cmd.ExecuteNonQuery();

                    // Insere login apenas se o INSERT do paciente tiver sido bem-sucedido
                    if (rows > 0)
                    {
                        using (SqlCommand cmdLogin = new SqlCommand(InsertLoginSql, conn))
                        {
                            cmdLogin.Parameters.AddWithValue("@USUARIO", usuarioPac);
                            cmdLogin.Parameters.AddWithValue("@SENHA", senhaPac);
                            cmdLogin.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MenuPrincipalPaciente menuPaciente = new MenuPrincipalPaciente();
                        menuPaciente.Show();
                        this.Hide(); // esconder o form de cadastro depois de abrir o menu
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha inserida. Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (SqlException ex)
            {
                // Mensagem mais amigável, mas mostre detalhe se necessário
                MessageBox.Show("Erro ao salvar no banco de dados:\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pictureBoxCadastroPac_Click(object sender, EventArgs e)
        {

        }
    }
}