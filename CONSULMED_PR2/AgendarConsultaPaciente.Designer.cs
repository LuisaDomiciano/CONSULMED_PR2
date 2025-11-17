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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarConsultaPaciente));
            this.ComboBoxEspecialidadesAgendamento = new System.Windows.Forms.ComboBox();
            this.ComboBoxMedicosAgendamentos = new System.Windows.Forms.ComboBox();
            this.ComboBoxHorariosAgendamentosPac = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTituloAgendarPac = new System.Windows.Forms.Label();
            this.BtnSetaNextAgendarPac = new System.Windows.Forms.Button();
            this.BtnNextAgendarPac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxEspecialidadesAgendamento
            // 
            this.ComboBoxEspecialidadesAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ComboBoxEspecialidadesAgendamento.Location = new System.Drawing.Point(399, 210);
            this.ComboBoxEspecialidadesAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxEspecialidadesAgendamento.Name = "ComboBoxEspecialidadesAgendamento";
            this.ComboBoxEspecialidadesAgendamento.Size = new System.Drawing.Size(287, 37);
            this.ComboBoxEspecialidadesAgendamento.TabIndex = 0;
            this.ComboBoxEspecialidadesAgendamento.Text = "Especialidade";
            this.ComboBoxEspecialidadesAgendamento.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEspecialidadesAgendamento_SelectedIndexChanged);
            // 
            // ComboBoxMedicosAgendamentos
            // 
            this.ComboBoxMedicosAgendamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMedicosAgendamentos.FormattingEnabled = true;
            this.ComboBoxMedicosAgendamentos.Location = new System.Drawing.Point(399, 275);
            this.ComboBoxMedicosAgendamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxMedicosAgendamentos.Name = "ComboBoxMedicosAgendamentos";
            this.ComboBoxMedicosAgendamentos.Size = new System.Drawing.Size(287, 37);
            this.ComboBoxMedicosAgendamentos.TabIndex = 1;
            this.ComboBoxMedicosAgendamentos.Text = "Médicos";
            this.ComboBoxMedicosAgendamentos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMedicosAgendamentos_SelectedIndexChanged);
            // 
            // ComboBoxHorariosAgendamentosPac
            // 
            this.ComboBoxHorariosAgendamentosPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxHorariosAgendamentosPac.FormattingEnabled = true;
            this.ComboBoxHorariosAgendamentosPac.Location = new System.Drawing.Point(399, 402);
            this.ComboBoxHorariosAgendamentosPac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxHorariosAgendamentosPac.Name = "ComboBoxHorariosAgendamentosPac";
            this.ComboBoxHorariosAgendamentosPac.Size = new System.Drawing.Size(287, 37);
            this.ComboBoxHorariosAgendamentosPac.TabIndex = 2;
            this.ComboBoxHorariosAgendamentosPac.Text = "Horários disponíveis";
            this.ComboBoxHorariosAgendamentosPac.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHorariosAgendamentosPac_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 337);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 34);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LblTituloAgendarPac
            // 
            this.LblTituloAgendarPac.AutoSize = true;
            this.LblTituloAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAgendarPac.Location = new System.Drawing.Point(266, 63);
            this.LblTituloAgendarPac.Name = "LblTituloAgendarPac";
            this.LblTituloAgendarPac.Size = new System.Drawing.Size(537, 69);
            this.LblTituloAgendarPac.TabIndex = 5;
            this.LblTituloAgendarPac.Text = "Agendar Consultas";
            // 
            // BtnSetaNextAgendarPac
            // 
            this.BtnSetaNextAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetaNextAgendarPac.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetaNextAgendarPac.Image")));
            this.BtnSetaNextAgendarPac.Location = new System.Drawing.Point(986, 507);
            this.BtnSetaNextAgendarPac.Name = "BtnSetaNextAgendarPac";
            this.BtnSetaNextAgendarPac.Size = new System.Drawing.Size(38, 35);
            this.BtnSetaNextAgendarPac.TabIndex = 6;
            this.BtnSetaNextAgendarPac.UseVisualStyleBackColor = true;
            // 
            // BtnNextAgendarPac
            // 
            this.BtnNextAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextAgendarPac.Location = new System.Drawing.Point(879, 507);
            this.BtnNextAgendarPac.Name = "BtnNextAgendarPac";
            this.BtnNextAgendarPac.Size = new System.Drawing.Size(111, 35);
            this.BtnNextAgendarPac.TabIndex = 7;
            this.BtnNextAgendarPac.Text = "Próximo";
            this.BtnNextAgendarPac.UseVisualStyleBackColor = true;
            // 
            // AgendarConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNextAgendarPac);
            this.Controls.Add(this.BtnSetaNextAgendarPac);
            this.Controls.Add(this.LblTituloAgendarPac);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ComboBoxHorariosAgendamentosPac);
            this.Controls.Add(this.ComboBoxMedicosAgendamentos);
            this.Controls.Add(this.ComboBoxEspecialidadesAgendamento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgendarConsultaPaciente";
            this.Text = "AgendarConsultaPaciente";
            this.Load += new System.EventHandler(this.AgendarConsultaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEspecialidadesAgendamento;
        private System.Windows.Forms.ComboBox ComboBoxMedicosAgendamentos;
        private System.Windows.Forms.ComboBox ComboBoxHorariosAgendamentosPac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblTituloAgendarPac;
        private System.Windows.Forms.Button BtnSetaNextAgendarPac;
        private System.Windows.Forms.Button BtnNextAgendarPac;
    }
}