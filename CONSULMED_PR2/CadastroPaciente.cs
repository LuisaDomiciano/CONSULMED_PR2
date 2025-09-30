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
            // Aqui você pode salvar no banco os dados do paciente primeiro
            MenuPrincipalPaciente menuPac = new MenuPrincipalPaciente();
            menuPac.Show();
            this.Hide();
        }

        private void pictureBoxCadastroPac_Click(object sender, EventArgs e)
        {

        }
    }
}
