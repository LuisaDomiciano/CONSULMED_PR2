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
            string nome = txtNameMed.Text;
            string cpf = txtCpfMed.Text;
            string email = txtEmailMed.Text;
            string telefone = txtFoneMed.Text;
            string crm = txtCrm.Text;
            bool atendeConvenio = checkBoxAgreementYesMed.Checked;
            string convenios = comboBoxAgreementMed.Text;
            string codConvenio = TxtCodAgreement.Text;
            bool atendeSUS = checkBoxYesMed.Checked;
            string codSUS = TxtCodSus.Text;
            string usuario = txtUserMed.Text;
            string senha = txtPasswordMed.Text;
            string conexao = "Server=sqlexpress;Database=CJ3027392PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string query = "INSERT INTO CadastroMedico (Nome, CPF, Email, Telefone, CRM, AtendeConvenio, Convenios, CodConvenio, AtendeSUS, CodSUS, Usuario, Senha) " +
                               "VALUES (@Nome, @CPF, @Email, @Telefone, @CRM, @AtendeConvenio, @Convenios, @CodConvenio, @AtendeSUS, @CodSUS, @Usuario, @Senha)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@CRM", crm);
                    cmd.Parameters.AddWithValue("@AtendeConvenio", atendeConvenio);
                    cmd.Parameters.AddWithValue("@Convenios", convenios);
                    cmd.Parameters.AddWithValue("@CodConvenio", codConvenio);
                    cmd.Parameters.AddWithValue("@AtendeSUS", atendeSUS);
                    cmd.Parameters.AddWithValue("@CodSUS", codSUS);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }
    }
}
