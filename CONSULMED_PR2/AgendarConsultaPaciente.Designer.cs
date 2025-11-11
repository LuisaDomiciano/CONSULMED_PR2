namespace CONSULMED_PR2
{
    partial class AgendarConsultaPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxEspecialidadesAgendamento = new System.Windows.Forms.ComboBox();
            this.ComboBoxMedicosAgendamentos = new System.Windows.Forms.ComboBox();
            this.ComboBoxHorariosAgendamentosPac = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ComboBoxEspecialidadesAgendamento
            // 
            this.ComboBoxEspecialidadesAgendamento.FormattingEnabled = true;
            this.ComboBoxEspecialidadesAgendamento.Items.AddRange(new object[] {
            "Clínica Geral",
            "Pediatria",
            "Ginecologia",
            "Cardiologia",
            "Ortopedia",
            "Dermatologia",
            "Oftalmologia",
            "Otorrinolaringologia",
            "Gastroenterologia",
            "Neurologia",
            "Psiquiatria",
            "Endocrinologia",
            "Urologia",
            "Cirurgia Geral",
            "Oncologia",
            "Pneumologia",
            "Geriatria"});
            this.ComboBoxEspecialidadesAgendamento.Location = new System.Drawing.Point(299, 131);
            this.ComboBoxEspecialidadesAgendamento.Name = "ComboBoxEspecialidadesAgendamento";
            this.ComboBoxEspecialidadesAgendamento.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxEspecialidadesAgendamento.TabIndex = 0;
            this.ComboBoxEspecialidadesAgendamento.Text = "Especialidade";
            this.ComboBoxEspecialidadesAgendamento.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEspecialidadesAgendamento_SelectedIndexChanged);
            // 
            // ComboBoxMedicosAgendamentos
            // 
            this.ComboBoxMedicosAgendamentos.FormattingEnabled = true;
            this.ComboBoxMedicosAgendamentos.Location = new System.Drawing.Point(299, 180);
            this.ComboBoxMedicosAgendamentos.Name = "ComboBoxMedicosAgendamentos";
            this.ComboBoxMedicosAgendamentos.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxMedicosAgendamentos.TabIndex = 1;
            this.ComboBoxMedicosAgendamentos.Text = "Médicos";
            this.ComboBoxMedicosAgendamentos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMedicosAgendamentos_SelectedIndexChanged);
            // 
            // ComboBoxHorariosAgendamentosPac
            // 
            this.ComboBoxHorariosAgendamentosPac.FormattingEnabled = true;
            this.ComboBoxHorariosAgendamentosPac.Location = new System.Drawing.Point(299, 262);
            this.ComboBoxHorariosAgendamentosPac.Name = "ComboBoxHorariosAgendamentosPac";
            this.ComboBoxHorariosAgendamentosPac.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxHorariosAgendamentosPac.TabIndex = 2;
            this.ComboBoxHorariosAgendamentosPac.Text = "Horários disponíveis";
            this.ComboBoxHorariosAgendamentosPac.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHorariosAgendamentosPac_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AgendarConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ComboBoxHorariosAgendamentosPac);
            this.Controls.Add(this.ComboBoxMedicosAgendamentos);
            this.Controls.Add(this.ComboBoxEspecialidadesAgendamento);
            this.Name = "AgendarConsultaPaciente";
            this.Text = "AgendarConsultaPaciente";
            this.Load += new System.EventHandler(this.AgendarConsultaPaciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEspecialidadesAgendamento;
        private System.Windows.Forms.ComboBox ComboBoxMedicosAgendamentos;
        private System.Windows.Forms.ComboBox ComboBoxHorariosAgendamentosPac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}