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

        private void MenuPrincipalPac(object sender, EventArgs e)
        {
            panelMenuPac.Visible = false;
        }

        bool menuExpandido = false;
        private void BtnMenuPac_Click(object sender, EventArgs e)
        {
            panelMenuPac.Visible = !panelMenuPac.Visible;

            timerMenuPac.Start();
        }


        private void timerMenuPac_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenuPac.Width -= 20;
                if (panelMenuPac.Width <= 0)
                {
                    timerMenuPac.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                panelMenuPac.Width += 20;
                if (panelMenuPac.Width >= 200)
                {
                    timerMenuPac.Stop();
                    menuExpandido = true;
                }
            }

        }

        private void BtnAgendarConsultaPac_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de agendamento
            AgendarConsultaPaciente formAgendar = new AgendarConsultaPaciente();

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
    }
}




