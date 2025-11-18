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
    public partial class AgendarConsultaPaciente : Form
    {
        public AgendarConsultaPaciente()
        {
            InitializeComponent();
        }

        private void AgendarConsultaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxEspecialidadesAgendamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxMedicosAgendamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxHorariosAgendamentosPac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNextAgendarPac_Click(object sender, EventArgs e)
        {
            FormularioTriagem triagem = new FormularioTriagem();
            triagem.Show();
            this.Hide(); // esconder o form de cadastro depois de abrir o menu
        }

        private void BtnSetaNextAgendarPac_Click(object sender, EventArgs e)
        {
            FormularioTriagem triagem = new FormularioTriagem();
            triagem.Show();
            this.Hide(); // esconder o form de cadastro depois de abrir o menu

        }
    }
}
