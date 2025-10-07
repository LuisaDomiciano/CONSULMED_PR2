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
    public partial class CadastroPaciente : Form
    {
        // Ajuste a string de conexão para o seu servidor e banco
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

        // Comando SQL para inserir os dados

        private const string InsertSql = @"INSERT INTO CadastroPaciente 
    (NOME_PAC, CPF_PAC, EMAIL_PAC, TELEFONE_PAC, CODSUS_PAC, USUARIO_PAC, SENHA_PAC, CONFIRME_SENHA_PAC)
    VALUES (@NOME_PAC, @CPF_PAC, @EMAIL_PAC, @TELEFONE_PAC, @CODSUS_PAC, @USUARIO_PAC, @SENHA_PAC, @CONFIRME_SENHA_PAC)";




        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = false;
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAgreementNoPac_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = false; // Esconder se marcado "Não"
        }

        private void CheckBoxAgreementYesPac_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = true; // Mostrar se marcado "Sim"
        }

        private void btnSaveRegistrationPac_Click(object sender, EventArgs e)
        {
            // Aqui você pode salvar no banco os dados do paciente primeiro
            MenuPrincipalPaciente menuPac = new MenuPrincipalPaciente();
            menuPac.Show();
            this.Hide();

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
            // Se o médico atende convênio e foi informado o código, envia o valor; caso contrário deixa NULL


            object dbCodSus = string.IsNullOrEmpty(codSusPac) ? DBNull.Value : (object)codSusPac;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(InsertSql, conn))
                {
                    // Adiciona parâmetros - use tipos se quiser maior controle (SqlDbType)
                    cmd.Parameters.AddWithValue("@NOME_PAC", txtNamePac);
                    cmd.Parameters.AddWithValue("@CPF_PAC", txtCpfPac);
                    cmd.Parameters.AddWithValue("@EMAIL_PAC", txtEmailPac);
                    cmd.Parameters.AddWithValue("@TELEFONE_PAC", txtFonePac);
                    cmd.Parameters.AddWithValue("@CODSUS_PAC", TxtCodSusPac);
                    cmd.Parameters.AddWithValue("@USUARIO_PAC", txtUserPac);
                    cmd.Parameters.AddWithValue("@SENHA_PAC", txtPasswordPac);
                    cmd.Parameters.AddWithValue("@CONFIRME_SENHA_PAC", txtConfirmPasswordPac);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abre menu e esconde este form (como você já tinha)
                        MenuPrincipalMedico menuMed = new MenuPrincipalMedico();
                        menuMed.Show();
                        this.Hide();
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
