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
    public partial class AgendarConsultaPaciente : Form
    {
        public AgendarConsultaPaciente()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";
        // ADICIONE ESTE MÉTODO ANTES do AgendarConsultaPaciente_Load (por volta da linha 30)
        private void CarregarMedicosPorEspecialidade(string idEspecialidade)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT m.ID_Medico, m.Nome_Medico, m.CRM 
                           FROM Medicos m
                           INNER JOIN Medico_Especialidade me ON m.ID_Medico = me.ID_Medico
                           WHERE me.ID_Especialidade = @IdEspecialidade";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@IdEspecialidade", idEspecialidade);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ComboBoxMedicosAgendamentos.DataSource = dt;
                    ComboBoxMedicosAgendamentos.DisplayMember = "Nome_Medico";
                    ComboBoxMedicosAgendamentos.ValueMember = "ID_Medico";
                    ComboBoxMedicosAgendamentos.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar médicos: {ex.Message}");
            }
        }
        // ADICIONE ESTE MÉTODO APÓS o CarregarMedicosPorEspecialidade
        private void CarregarHorariosDisponiveis(string idMedico, DateTime data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Horario FROM Horarios_Disponiveis 
                           WHERE ID_Medico = @IdMedico AND Data = @Data 
                           AND Disponivel = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@IdMedico", idMedico);
                    da.SelectCommand.Parameters.AddWithValue("@Data", data.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ComboBoxHorariosAgendamentosPac.DataSource = dt;
                    ComboBoxHorariosAgendamentosPac.DisplayMember = "Horario";
                    ComboBoxHorariosAgendamentosPac.ValueMember = "Horario";
                    ComboBoxHorariosAgendamentosPac.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar horários: {ex.Message}");
            }
        }
        private void AgendarConsultaPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027392PR2DataSet1.Medico_Profissional'. Você pode movê-la ou removê-la conforme necessário.
            this.medico_ProfissionalTableAdapter.Fill(this.cJ3027392PR2DataSet1.Medico_Profissional);
            // TODO: esta linha de código carrega dados na tabela 'cJ3027392PR2DataSet.Especialidades'. Você pode movê-la ou removê-la conforme necessário.
            //this.especialidadesTableAdapter.Fill(this.cJ3027392PR2DataSet.Especialidades);


            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    string query = "SELECT Id_Especialidade, Nome_Especialidade FROM Especialidades";

            //    SqlDataAdapter da = new SqlDataAdapter(query, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    ComboBoxEspecialidadesAgendamento.DataSource = dt;
            //    ComboBoxEspecialidadesAgendamento.DisplayMember = "Nome_Especialidade";
            //    ComboBoxEspecialidadesAgendamento.ValueMember = "Id_Especialidade";
            //    ComboBoxEspecialidadesAgendamento.SelectedIndex = -1; // deixa vazio no início
            //}
        }


        private void ComboBoxEspecialidadesAgendamento_SelectedIndexChanged(object sender, EventArgs e)

        {
            // CORRIJA ESTE MÉTODO - estava chamando horários em vez de médicos
           
        }





        private void ComboBoxMedicosAgendamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ADICIONE ESTE CÓDIGO AQUI (dentro do método existente)
            if (ComboBoxMedicosAgendamentos.SelectedValue != null && dateTimePicker1.Value != null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // ADICIONE ESTE CÓDIGO AQUI (dentro do método existente)
            if (ComboBoxMedicosAgendamentos.SelectedValue != null)
            {
                CarregarHorariosDisponiveis(ComboBoxMedicosAgendamentos.SelectedValue.ToString(), dateTimePicker1.Value);
            }
        }
        

        private void ComboBoxHorariosAgendamentosPac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNextAgendarPac_Click(object sender, EventArgs e)
        {
 
            // ADICIONE ESTA VALIDAÇÃO NO INÍCIO DO MÉTODO
            if (ComboBoxEspecialidadesAgendamento.SelectedValue == null ||
                ComboBoxMedicosAgendamentos.SelectedValue == null ||
                ComboBoxHorariosAgendamentosPac.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione especialidade, médico e horário antes de continuar.");
                return;
            }

            FormularioTriagem triagem = new FormularioTriagem();
            triagem.Show();
            this.Hide();
        }


    }

}
