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
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;Integrated Security=True"))
                {
                    con.Open();

                    string sql = @"INSERT INTO medico
                      (NOME_MED, CPF_MED, EMAIL_MED, TELEFONE_MED, 
                       CRM, COD_CONVENIO, COD_SUS_MED, 
                       USUARIO_MED, SENHA_MED_US, CONFIRM_SENHA_MED_US)
                       VALUES (@id, @nome, @cpf, @email, @telefone, 
                               @crm, @convenio, @sus, 
                               @usuario, @senha, @confSenha)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
            
                        string idGerado = Guid.NewGuid().ToString("N").Substring(0, 4);

                        cmd.Parameters.AddWithValue("@id", idGerado);
                        cmd.Parameters.AddWithValue("@nome", txtNameMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@cpf", txtCpfMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmailMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefone", txtFoneMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@crm", txtCrm.Text.Trim());

                        // Se atende convênio
                        if (checkBoxAgreementYesMed.Checked) 
                            cmd.Parameters.AddWithValue("@convenio", TxtCodAgreement.Text.Trim());
                        else
                            cmd.Parameters.AddWithValue("@convenio", DBNull.Value);

                        // Se atende SUS
                        if (checkBoxYesMed.Checked)
                            cmd.Parameters.AddWithValue("@sus", TxtCodSus.Text.Trim());
                        else
                            cmd.Parameters.AddWithValue("@sus", DBNull.Value);

                        cmd.Parameters.AddWithValue("@usuario", txtUserMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", txtPasswordMed.Text.Trim());
                        cmd.Parameters.AddWithValue("@confSenha", txtConfirmPasswordMed.Text.Trim());

                        // Executa o INSERT
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Médico cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro: " + ex.Message);
            }


            {



            }
        }
    }
}

                 
            
    

