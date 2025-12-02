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
    public partial class MenuPrincipalMedico : Form
    {
        public MenuPrincipalMedico()
        {
            InitializeComponent();
        }

        private void pictureBoxMenuMedico_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgendaMenuMed_Click(object sender, EventArgs e)
        {
            // Abrir o formulário AgendaMedica
            AgendaMedica agendaMedica = new AgendaMedica();
            agendaMedica.Show(); // Mostra o novo formulário
            this.Hide(); // Esconde o formulário atual (opcional)
        }

        private void BtnHistoricoMed_Click(object sender, EventArgs e)
        {

        }

        private void BtnHistoricoMed_Click_1(object sender, EventArgs e)
        {
            HistoricoMedico historicoMedico = new HistoricoMedico();
            historicoMedico.Show();
            this.Hide();
        }
        private void BtnMinhasConsultasMed_Click(object sender, EventArgs e)
        {
            ConsultasMedico ConsultasMedico = new ConsultasMedico();
            ConsultasMedico.Show();
            this.Hide();
        }
    }
}
