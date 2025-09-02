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
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = false;
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label L;
        }

        private void checkBoxAgreementNoPac_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = false; // Esconder se marcado "Não"
        }

        private void CheckBoxAgreementYesPac_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAgreementPac.Visible = true; // Mostrar se marcado "Sim"
        }
    }
}
