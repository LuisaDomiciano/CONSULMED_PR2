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
    public partial class HistoricoMedico : Form
    {
        public HistoricoMedico()
        {
            InitializeComponent();
        }

        private void BtnGerarAtestado_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltarMed_Click(object sender, EventArgs e)
        {

            // Abrir Menu Principal
            MenuPrincipalMedico menuPrincipalMed = new MenuPrincipalMedico();
            menuPrincipalMed.Show();
            this.Hide(); // Fecha o formulário atual
        }
    }
}
