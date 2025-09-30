namespace CONSULMED_PR2
{
    partial class Agendamento
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
            this.LblOpticionConsultation1 = new System.Windows.Forms.Label();
            this.comboBoxOptionsAgendamentoEspecialidade = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxOptionsAgendamentoExames = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOpticionConsultation2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOpticionConsultation1
            // 
            this.LblOpticionConsultation1.AutoSize = true;
            this.LblOpticionConsultation1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblOpticionConsultation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpticionConsultation1.Location = new System.Drawing.Point(316, 43);
            this.LblOpticionConsultation1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOpticionConsultation1.Name = "LblOpticionConsultation1";
            this.LblOpticionConsultation1.Size = new System.Drawing.Size(560, 76);
            this.LblOpticionConsultation1.TabIndex = 0;
            this.LblOpticionConsultation1.Text = "O que gostaria de";
            this.LblOpticionConsultation1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxOptionsAgendamentoEspecialidade
            // 
            this.comboBoxOptionsAgendamentoEspecialidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxOptionsAgendamentoEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOptionsAgendamentoEspecialidade.FormattingEnabled = true;
            this.comboBoxOptionsAgendamentoEspecialidade.Items.AddRange(new object[] {
            "Dermatologista",
            "Endocronologista",
            "Pediatra",
            "Psiquiatra",
            "Ortopedista",
            "Clínico Geral",
            "Dentista",
            "Gastroentreologista",
            "Otorrinolaringologista",
            "Psicoterapeuta",
            "Pneumologista",
            "Neurogista",
            "Tricologia",
            "Nefrologia",
            "Neurologista Pediatra",
            "Psicólogo",
            "Oftalmologista",
            "Quiroprata",
            ""});
            this.comboBoxOptionsAgendamentoEspecialidade.Location = new System.Drawing.Point(331, 270);
            this.comboBoxOptionsAgendamentoEspecialidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOptionsAgendamentoEspecialidade.Name = "comboBoxOptionsAgendamentoEspecialidade";
            this.comboBoxOptionsAgendamentoEspecialidade.Size = new System.Drawing.Size(496, 77);
            this.comboBoxOptionsAgendamentoEspecialidade.TabIndex = 1;
            this.comboBoxOptionsAgendamentoEspecialidade.Text = "Especialidades";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxOptionsAgendamentoExames
            // 
            this.comboBoxOptionsAgendamentoExames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxOptionsAgendamentoExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOptionsAgendamentoExames.FormattingEnabled = true;
            this.comboBoxOptionsAgendamentoExames.Items.AddRange(new object[] {
            "Hemograma completo",
            "",
            "",
            "Glicemia de jejum",
            "",
            "",
            "Colesterol total e frações",
            "",
            "",
            "Triglicerídeos",
            "",
            "",
            "Creatinina",
            "",
            "",
            "Ureia",
            "",
            "",
            "TSH",
            "",
            "T4 livre",
            "",
            "",
            "Eletrocardiograma (ECG)",
            "",
            "",
            "Ecocardiograma",
            "",
            "",
            "Raio-X",
            "",
            "",
            "Tomografia computadorizada",
            "",
            "",
            "Ressonância magnética",
            "",
            "",
            "Ultrassonografia",
            "",
            "",
            "Exame de urina (EAS)",
            "",
            "",
            "Exame de fezes",
            "",
            "",
            "Protoparasitológico",
            "",
            "",
            "",
            "",
            "Teste ergométrico",
            "",
            "",
            "Endoscopia digestiva alta",
            "",
            "",
            "Colonoscopia",
            "",
            "",
            "Audiometria",
            "",
            "",
            "Espirometria",
            "",
            "",
            "Sorologia para HIV",
            "",
            "",
            "Sorologia para hepatite B e C",
            "",
            "VDRL",
            "",
            "",
            "Beta HCG",
            "",
            "",
            "Tipagem sanguínea e fator Rh"});
            this.comboBoxOptionsAgendamentoExames.Location = new System.Drawing.Point(331, 409);
            this.comboBoxOptionsAgendamentoExames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOptionsAgendamentoExames.Name = "comboBoxOptionsAgendamentoExames";
            this.comboBoxOptionsAgendamentoExames.Size = new System.Drawing.Size(496, 77);
            this.comboBoxOptionsAgendamentoExames.TabIndex = 3;
            this.comboBoxOptionsAgendamentoExames.Text = "Exames";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CONSULMED_PR2.Properties.Resources.Design_sem_nome__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 76);
            this.label1.TabIndex = 5;
            // 
            // LblOpticionConsultation2
            // 
            this.LblOpticionConsultation2.AutoSize = true;
            this.LblOpticionConsultation2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblOpticionConsultation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpticionConsultation2.Location = new System.Drawing.Point(415, 130);
            this.LblOpticionConsultation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOpticionConsultation2.Name = "LblOpticionConsultation2";
            this.LblOpticionConsultation2.Size = new System.Drawing.Size(331, 76);
            this.LblOpticionConsultation2.TabIndex = 6;
            this.LblOpticionConsultation2.Text = " agendar?";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LblOpticionConsultation2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOptionsAgendamentoExames);
            this.Controls.Add(this.comboBoxOptionsAgendamentoEspecialidade);
            this.Controls.Add(this.LblOpticionConsultation1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOpticionConsultation1;
        private System.Windows.Forms.ComboBox comboBoxOptionsAgendamentoEspecialidade;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxOptionsAgendamentoExames;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblOpticionConsultation2;
    }
}