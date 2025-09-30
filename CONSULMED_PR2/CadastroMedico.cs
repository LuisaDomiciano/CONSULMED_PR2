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
            // Aqui você pode salvar no banco os dados do médico primeiro
            MenuPrincipalMedico menuMed = new MenuPrincipalMedico();
            menuMed.Show();
            this.Hide();
        }

    }
}




                 
            
    

