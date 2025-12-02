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
        private const string InsertSql = @"INSERT INTO Paciente
(NOME_PAC, CPF_PAC, EMAIL_PAC, TELEFONE_PAC, COD_SUS_PAC, USUARIO_PAC, SENHA_PAC, CONFIRME_SENHA_PAC)
VALUES (@NOME_PAC, @CPF_PAC, @EMAIL_PAC, @TELEFONE_PAC, @COD_SUS_PAC, @USUARIO_PAC, @SENHA_PAC, @CONFIRME_SENHA_PAC)";

        // Comando SQL para inserir também os dados de login
        private const string InsertLoginSql = @"INSERT INTO LoginPac
(Usuario_LogPac, Senha_LogPac)
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

            }
            else
            {

            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            // Esconde o ComboBox se "Não" estiver marcado
            if (radioButtonNo.Checked)
            {

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
                    // Variáveis para armazenar o estado do convênio (bool) e o nome selecionado (string)
                    bool possuiConvenio = false;
                    string nomeConvenio = null;

                    // Verifica se o Radio Button "Sim" está marcado
                    if (radioButtonYes.Checked) // Substitua 'rbSimConvenio' pelo nome real do seu Radio Button 'Sim'
                    {
                        possuiConvenio = true;

                        // Captura o nome do convênio selecionado no ComboBox (Dropdown)
                        if (comboBoxAgreementPac.SelectedItem != null) // Substitua 'cmbConvenio' pelo nome real do seu ComboBox
                        {
                            nomeConvenio = comboBoxAgreementPac.SelectedItem.ToString();
                        }
                    }
                    // Se o 'Não' estiver marcado, possuiConvenio já é 'false' e nomeConvenio já é 'null'.

                    // Define o valor do convênio para o banco (DBNull.Value se estiver vazio)
                    object dbNomeConvenio = string.IsNullOrEmpty(nomeConvenio) ? (object)DBNull.Value : nomeConvenio;


                    // 2. --- Adiciona parâmetros (Incluindo os de Convênio) ---

                    // Adiciona parâmetros
                    cmd.Parameters.AddWithValue("@NOME_PAC", nomePac);
                    cmd.Parameters.AddWithValue("@CPF_PAC", cpfPac);
                    cmd.Parameters.AddWithValue("@EMAIL_PAC", emailPac);
                    cmd.Parameters.AddWithValue("@TELEFONE_PAC", telefonePac);
                    cmd.Parameters.AddWithValue("@COD_SUS_PAC", codSusPac);

                    // Parâmetros de Convênio ENCAIXADOS AQUI
                    cmd.Parameters.AddWithValue("@POSSUI_CONVENIO", possuiConvenio); // BIT/BOOLEAN (1 ou 0)
                    cmd.Parameters.AddWithValue("@CONVENIO_SELECIONADO", dbNomeConvenio); // VARCHAR (Nome do Convênio ou NULL)

                    cmd.Parameters.AddWithValue("@USUARIO_PAC", usuarioPac);
                    cmd.Parameters.AddWithValue("@SENHA_PAC", senhaPac);
                    cmd.Parameters.AddWithValue("@CONFIRME_SENHA_PAC", confirmaPac);

                    // ... (cmd.ExecuteNonQuery() ou o restante do seu código)
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

                        MenuPrincipalPaciente MenuPaciente = new MenuPrincipalPaciente();
                        MenuPaciente.Show();
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

        private void radioButtonYes_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = true; // Mostrar se marcado "Sim"
        }

        private void comboBoxAgreementPac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
