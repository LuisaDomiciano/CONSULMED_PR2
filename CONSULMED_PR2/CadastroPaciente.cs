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
        string connectionString = @"Data Source=sqlexpress; Initial Catalog=CJ302392PR2;Integrated Security=True";



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
            // SQL de inserção
            string sql = @"INSERT INTO CadastroPaciente
                          (NOME_PAC, CPF_PAC, EMAIL_PAC, TELEFONE_PAC, CODSUS_PAC, USUARIO_PAC, SENHA_PAC, CONFIRME_SENHA_PAC)
                          VALUES (@NOME, @CPF, @EMAIL, @TELEFONE, @SUS, @USUARIO, @SENHA, @CONFIRMESENHA)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Adicionando valores das TextBox
                        cmd.Parameters.AddWithValue("@NOME", txtNamePac.Text);
                        cmd.Parameters.AddWithValue("@CPF", txtCpfPac.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txtEmailPac.Text);
                        cmd.Parameters.AddWithValue("@TELEFONE", txtFonePac.Text);
                        cmd.Parameters.AddWithValue("@SUS", TxtCodSusPac.Text);
                        cmd.Parameters.AddWithValue("@USUARIO", txtUserPac.Text);
                        cmd.Parameters.AddWithValue("@SENHA", txtPasswordPac.Text);
                        cmd.Parameters.AddWithValue("@CONFIRMESENHA", txtConfirmPasswordPac.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxCadastroPac_Click(object sender, EventArgs e)
        {

        }
    }
}
