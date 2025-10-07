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
    public partial class CadastroMedico : Form
    {

        // String de conexão com o banco de dados
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

        // Comando SQL para inserir os dados

        private const string InsertSql = @"INSERT INTO CadastroMedico 
                                    (NOME_MED, CPF_MED, EMAIL_MED, TELEFONE_MED, CRM, CODCONVENIO, CODSUS_MED, USUARIO_MED, SENHA_MED, CONFIRME_SENHA_MED)
                                     VALUES (@NOME_MED, @CPF_MED, @EMAIL_MED, @TELEFONE_MED, @CRM, @CODCONVENIO, @CODSUS_MED, @USUARIO_MED, @SENHA_MED, @CONFIRME_SENHA_MED)";

        public CadastroMedico()
        {
            InitializeComponent();
        }

        private void CadastroMedico_Load(object sender, EventArgs e)
        {
            comboBoxAgreementMed.Visible = false;

        }

        private void CheckBoxAgreementNoMed_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAgreementMed.Visible = false; // Esconder se marcado "Não"
        }

        private void CheckBoxAgreementYesMed(object sender, EventArgs e)
        {
            comboBoxAgreementMed.Visible = true; // Mostrar se marcado "Sim"
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRegistrationMed_Click(object sender, EventArgs e)
        {

            {
                // Ler valores das textboxes (código anterior mantido)
                string nome = txtNameMed.Text.Trim();
                string cpf = txtCpfMed.Text.Trim();
                string email = txtEmailMed.Text.Trim();
                string telefone = txtFoneMed.Text.Trim();
                string crm = txtCrm.Text.Trim();
                string codConvenio = TxtCodAgreement.Text.Trim();
                string codSus = TxtCodSus.Text.Trim();
                string usuario = txtUserMed.Text.Trim();
                string senha = txtPasswordMed.Text;
                string confirma = txtConfirmPasswordMed.Text;

                // Validações básicas (código anterior mantido)
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Por favor preencha os campos obrigatórios (Nome, CPF, Usuário, Senha).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (senha != confirma)
                {
                    MessageBox.Show("Senha e confirmação de senha não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converter valores opcionais para DBNull (código anterior mantido)
                object dbCodConvenio = DBNull.Value;
                if ((checkBoxAgreementYesMed != null && checkBoxAgreementYesMed.Checked) && !string.IsNullOrEmpty(codConvenio))
                {
                    dbCodConvenio = codConvenio;
                }

                object dbCodSus = string.IsNullOrEmpty(codSus) ? DBNull.Value : (object)codSus;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Iniciar uma transação para garantir que ambas as operações sejam executadas
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // 1️⃣ Inserir na tabela CadastroMedico
                                using (SqlCommand cmd = new SqlCommand(InsertSql, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@NOME_MED", nome);
                                    cmd.Parameters.AddWithValue("@CPF_MED", cpf);
                                    cmd.Parameters.AddWithValue("@EMAIL_MED", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                                    cmd.Parameters.AddWithValue("@TELEFONE_MED", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                                    cmd.Parameters.AddWithValue("@CRM", string.IsNullOrEmpty(crm) ? (object)DBNull.Value : crm);
                                    cmd.Parameters.AddWithValue("@CODCONVENIO", dbCodConvenio);
                                    cmd.Parameters.AddWithValue("@CODSUS_MED", dbCodSus);
                                    cmd.Parameters.AddWithValue("@USUARIO_MED", usuario);
                                    cmd.Parameters.AddWithValue("@SENHA_MED", senha);
                                    cmd.Parameters.AddWithValue("@CONFIRME_SENHA_MED", confirma);

                                    int rows = cmd.ExecuteNonQuery();

                                    if (rows <= 0)
                                    {
                                        throw new Exception("Nenhuma linha inserida na tabela CadastroMedico.");
                                    }
                                }

                                // 2️⃣ Inserir na tabela PaginaLog
                                string insertLogin = @"INSERT INTO PaginaLog (Nome_PagLog, Senha_PagLog) 
                                   VALUES (@Usuario, @Senha)";

                                using (SqlCommand cmdLogin = new SqlCommand(insertLogin, conn, transaction))
                                {
                                    cmdLogin.Parameters.AddWithValue("@Usuario", usuario);
                                    cmdLogin.Parameters.AddWithValue("@Senha", senha);

                                    int rowsLogin = cmdLogin.ExecuteNonQuery();

                                    if (rowsLogin <= 0)
                                    {
                                        throw new Exception("Nenhuma linha inserida na tabela PaginaLog.");
                                    }
                                }

                                // Commit da transação se ambas as operações foram bem sucedidas
                                transaction.Commit();

                                MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Abre menu e esconde este form
                                MenuPrincipalMedico menuMed = new MenuPrincipalMedico();
                                menuMed.Show();
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                // Rollback em caso de erro
                                transaction.Rollback();
                                throw new Exception("Erro durante o cadastro: " + ex.Message, ex);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao salvar no banco de dados:\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}