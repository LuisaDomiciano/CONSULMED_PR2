using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONSULMED_PR2
{
    public partial class MenuPrincipalPaciente : Form
    {
        public MenuPrincipalPaciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgendarConsultaPac_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de agendamento
            ConsultasPaciente formAgendar = new ConsultasPaciente();

            // Mostra o novo formulário
            formAgendar.Show();

            // Fecha ou esconde o MenuPaciente (você escolhe)
            this.Hide(); // ou this.Close();
        }

        private void BtnMinhasConsultasPac_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de agendamento
            ConsultasPaciente formConsultasPac = new ConsultasPaciente();

            // Mostra o novo formulário
            formConsultasPac.Show();

            // Fecha ou esconde o MenuPaciente (você escolhe)
            this.Hide(); // ou this.Close();
        }

        private void buttonHistoricoMenuPac_Click(object sender, EventArgs e)
        {
            HistoricoPaciente HistoricoPaciente = new HistoricoPaciente();
            HistoricoPaciente.Show();
            this.Hide();
        }
    }
}




