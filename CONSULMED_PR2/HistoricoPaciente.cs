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
    public partial class HistoricoPaciente : Form
    {
        public HistoricoPaciente()
        {
            InitializeComponent();
        }

        private void BtnVoltarPac_Click(object sender, EventArgs e)
        {

            MenuPrincipalPaciente MenuPaciente = new MenuPrincipalPaciente();
            MenuPaciente.Show();
            this.Hide();
        }
    }
}
