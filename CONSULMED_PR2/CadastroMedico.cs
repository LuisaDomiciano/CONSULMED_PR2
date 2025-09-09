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
        private const string V = @"INSERT INTO CadastroMedico 
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
            try
            {
                // String de conexão com o banco (ajuste conforme seu servidor e banco de dados)
                string connectionString = @"Server=sqlepress;Database=CJ3027392PR2;User Id=aluno;Password=aluno";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = V;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Pegando valores das TextBox
                        cmd.Parameters.AddWithValue("@NOME_MED", txtNameMed.Text);
                        cmd.Parameters.AddWithValue("@CPF_MED", txtCpfMed.Text);
                        cmd.Parameters.AddWithValue("@EMAIL_MED", txtEmailMed.Text);
                        cmd.Parameters.AddWithValue("@TELEFONE_MED", txtFoneMed.Text);
                        cmd.Parameters.AddWithValue("@CRM", txtCrm.Text);
                        cmd.Parameters.AddWithValue("@CODCONVENIO", TxtCodAgreement.Text);
                        cmd.Parameters.AddWithValue("@CODSUS_MED", TxtCodSus.Text);
                        cmd.Parameters.AddWithValue("@USUARIO_MED", txtUserMed.Text);
                        cmd.Parameters.AddWithValue("@SENHA_MED", txtPasswordMed.Text);
                        cmd.Parameters.AddWithValue("@CONFIRME_SENHA_MED", txtConfirmPasswordMed.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



                 
            
    

