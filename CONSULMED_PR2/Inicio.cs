using CONSULMED_PR2;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnInicialMed_Click(object sender, EventArgs e)
        {
            CadastroMedico cadastroMedico = new CadastroMedico();
            cadastroMedico.Show();
            this.Hide(); // Esconde a tela inicial

        }

        private void btnIncialPac_Click(object sender, EventArgs e)
        {
            CadastroPaciente cadastroPaciente = new CadastroPaciente();
            cadastroPaciente.Show();
            this.Hide(); // Esconde a tela inicial

        }
    }
}

