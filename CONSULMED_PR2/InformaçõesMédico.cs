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
    public partial class InformaçõesMédico : Form

    {
        public InformaçõesMédico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InformaçõesMédico_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValorConsulta_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obrigatórios
                if (string.IsNullOrWhiteSpace(txtEspecialidadePrincipal.Text))
                {
                    MessageBox.Show("Preencha a especialidade principal!", "Aviso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conectar e salvar no SQL
                using (SqlConnection conexao = new SqlConnection(@"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;"))
                {
                    conexao.Open();

                    string query = @"INSERT INTO Medico_Profissional
                           (Especialidade_Principal, Subespecialidade, Numero_RQE, 
                           Instituicao_Formacao, Ano_Formatura,  Tempo_Experiencia, 
                            Horario_Atendimento, Valor_Consulta) 
                           VALUES (@Especialidade, @Subespecialidade, @ROE, 
                                   @Instituicao, @AnoFormatura, @Experiencia, 
                                   @Horario, @Valor)";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Especialidade", txtEspecialidadePrincipal.Text);
                        comando.Parameters.AddWithValue("@Subespecialidade", txtSubespecialidade.Text ?? "");
                        comando.Parameters.AddWithValue("@ROE", txtNumeroROE.Text ?? "");
                        comando.Parameters.AddWithValue("@Instituicao", txtInstituicaoFormacao.Text ?? "");
                        comando.Parameters.AddWithValue("@AnoFormatura",
                            string.IsNullOrEmpty(txtAnoFormatura.Text) ? (object)DBNull.Value : Convert.ToInt32(txtAnoFormatura.Text));
                        comando.Parameters.AddWithValue("@Experiencia",
                            string.IsNullOrEmpty(txtTempoExperiencia.Text) ? (object)DBNull.Value : Convert.ToInt32(txtTempoExperiencia.Text));
                        comando.Parameters.AddWithValue("@Horario", txtHorarioAtendimento.Text ?? "");
                        comando.Parameters.AddWithValue("@Valor",
                            string.IsNullOrEmpty(txtValorConsulta.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtValorConsulta.Text));

                        comando.ExecuteNonQuery();
                    }
                }

                // Mensagem de sucesso
                MessageBox.Show("Dados salvos com sucesso!", "Informação",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir Menu Principal
                MenuPrincipalMedico menuPrincipalMed = new MenuPrincipalMedico();
                menuPrincipalMed.Show();
                this.Hide(); // Fecha o formulário atual

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}

