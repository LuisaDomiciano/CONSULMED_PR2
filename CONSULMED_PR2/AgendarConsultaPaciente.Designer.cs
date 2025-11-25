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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarConsultaPaciente));
            this.ComboBoxEspecialidadesAgendamento = new System.Windows.Forms.ComboBox();
            this.ComboBoxMedicosAgendamentos = new System.Windows.Forms.ComboBox();
            this.ComboBoxHorariosAgendamentosPac = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTituloAgendarPac = new System.Windows.Forms.Label();
            this.BtnSetaNextAgendarPac = new System.Windows.Forms.Button();
            this.BtnNextAgendarPac = new System.Windows.Forms.Button();
            this.cJ3027392PR2DataSet = new CONSULMED_PR2.CJ3027392PR2DataSet();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new CONSULMED_PR2.CJ3027392PR2DataSetTableAdapters.EspecialidadesTableAdapter();
            this.cJ3027392PR2DataSet1 = new CONSULMED_PR2.CJ3027392PR2DataSet1();
            this.medicoProfissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medico_ProfissionalTableAdapter = new CONSULMED_PR2.CJ3027392PR2DataSet1TableAdapters.Medico_ProfissionalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027392PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027392PR2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoProfissionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxEspecialidadesAgendamento
            // 
            this.ComboBoxEspecialidadesAgendamento.DataSource = this.medicoProfissionalBindingSource;
            this.ComboBoxEspecialidadesAgendamento.DisplayMember = "Especialidade_Principal";
            this.ComboBoxEspecialidadesAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEspecialidadesAgendamento.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxEspecialidadesAgendamento.FormattingEnabled = true;
            this.ComboBoxEspecialidadesAgendamento.Location = new System.Drawing.Point(299, 171);
            this.ComboBoxEspecialidadesAgendamento.Name = "ComboBoxEspecialidadesAgendamento";
            this.ComboBoxEspecialidadesAgendamento.Size = new System.Drawing.Size(216, 30);
            this.ComboBoxEspecialidadesAgendamento.TabIndex = 0;
            this.ComboBoxEspecialidadesAgendamento.ValueMember = "Especialidade_Principal";
            this.ComboBoxEspecialidadesAgendamento.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEspecialidadesAgendamento_SelectedIndexChanged);
            // 
            // ComboBoxMedicosAgendamentos
            // 
            this.ComboBoxMedicosAgendamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMedicosAgendamentos.FormattingEnabled = true;
            this.ComboBoxMedicosAgendamentos.Location = new System.Drawing.Point(299, 223);
            this.ComboBoxMedicosAgendamentos.Name = "ComboBoxMedicosAgendamentos";
            this.ComboBoxMedicosAgendamentos.Size = new System.Drawing.Size(216, 30);
            this.ComboBoxMedicosAgendamentos.TabIndex = 1;
            this.ComboBoxMedicosAgendamentos.Text = "Médicos";
            this.ComboBoxMedicosAgendamentos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMedicosAgendamentos_SelectedIndexChanged);
            // 
            // ComboBoxHorariosAgendamentosPac
            // 
            this.ComboBoxHorariosAgendamentosPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxHorariosAgendamentosPac.FormattingEnabled = true;
            this.ComboBoxHorariosAgendamentosPac.Location = new System.Drawing.Point(299, 327);
            this.ComboBoxHorariosAgendamentosPac.Name = "ComboBoxHorariosAgendamentosPac";
            this.ComboBoxHorariosAgendamentosPac.Size = new System.Drawing.Size(216, 30);
            this.ComboBoxHorariosAgendamentosPac.TabIndex = 2;
            this.ComboBoxHorariosAgendamentosPac.Text = "Horários disponíveis";
            this.ComboBoxHorariosAgendamentosPac.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHorariosAgendamentosPac_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 28);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LblTituloAgendarPac
            // 
            this.LblTituloAgendarPac.AutoSize = true;
            this.LblTituloAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAgendarPac.Location = new System.Drawing.Point(200, 51);
            this.LblTituloAgendarPac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloAgendarPac.Name = "LblTituloAgendarPac";
            this.LblTituloAgendarPac.Size = new System.Drawing.Size(434, 55);
            this.LblTituloAgendarPac.TabIndex = 5;
            this.LblTituloAgendarPac.Text = "Agendar Consultas";
            // 
            // BtnSetaNextAgendarPac
            // 
            this.BtnSetaNextAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetaNextAgendarPac.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetaNextAgendarPac.Image")));
            this.BtnSetaNextAgendarPac.Location = new System.Drawing.Point(740, 412);
            this.BtnSetaNextAgendarPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSetaNextAgendarPac.Name = "BtnSetaNextAgendarPac";
            this.BtnSetaNextAgendarPac.Size = new System.Drawing.Size(28, 28);
            this.BtnSetaNextAgendarPac.TabIndex = 6;
            this.BtnSetaNextAgendarPac.UseVisualStyleBackColor = true;
            // 
            // BtnNextAgendarPac
            // 
            this.BtnNextAgendarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextAgendarPac.Location = new System.Drawing.Point(659, 412);
            this.BtnNextAgendarPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNextAgendarPac.Name = "BtnNextAgendarPac";
            this.BtnNextAgendarPac.Size = new System.Drawing.Size(83, 28);
            this.BtnNextAgendarPac.TabIndex = 7;
            this.BtnNextAgendarPac.Text = "Próximo";
            this.BtnNextAgendarPac.UseVisualStyleBackColor = true;
            this.BtnNextAgendarPac.Click += new System.EventHandler(this.BtnNextAgendarPac_Click);
            // 
            // cJ3027392PR2DataSet
            // 
            this.cJ3027392PR2DataSet.DataSetName = "CJ3027392PR2DataSet";
            this.cJ3027392PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "Especialidades";
            this.especialidadesBindingSource.DataSource = this.cJ3027392PR2DataSet;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // cJ3027392PR2DataSet1
            // 
            this.cJ3027392PR2DataSet1.DataSetName = "CJ3027392PR2DataSet1";
            this.cJ3027392PR2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoProfissionalBindingSource
            // 
            this.medicoProfissionalBindingSource.DataMember = "Medico_Profissional";
            this.medicoProfissionalBindingSource.DataSource = this.cJ3027392PR2DataSet1;
            // 
            // medico_ProfissionalTableAdapter
            // 
            this.medico_ProfissionalTableAdapter.ClearBeforeFill = true;
            // 
            // AgendarConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNextAgendarPac);
            this.Controls.Add(this.BtnSetaNextAgendarPac);
            this.Controls.Add(this.LblTituloAgendarPac);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ComboBoxHorariosAgendamentosPac);
            this.Controls.Add(this.ComboBoxMedicosAgendamentos);
            this.Controls.Add(this.ComboBoxEspecialidadesAgendamento);
            this.Name = "AgendarConsultaPaciente";
            this.Text = "AgendarConsultaPaciente";
            this.Load += new System.EventHandler(this.AgendarConsultaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027392PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027392PR2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoProfissionalBindingSource)).EndInit();
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
        private CJ3027392PR2DataSet cJ3027392PR2DataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private CJ3027392PR2DataSetTableAdapters.EspecialidadesTableAdapter especialidadesTableAdapter;
        private CJ3027392PR2DataSet1 cJ3027392PR2DataSet1;
        private System.Windows.Forms.BindingSource medicoProfissionalBindingSource;
        private CJ3027392PR2DataSet1TableAdapters.Medico_ProfissionalTableAdapter medico_ProfissionalTableAdapter;
    }
}