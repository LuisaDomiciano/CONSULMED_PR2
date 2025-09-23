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
            this.LblOpticionConsultation = new System.Windows.Forms.Label();
            this.comboBoxOptionsAgendamento = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblOpticionConsultation
            // 
            this.LblOpticionConsultation.AutoSize = true;
            this.LblOpticionConsultation.Location = new System.Drawing.Point(364, 144);
            this.LblOpticionConsultation.Name = "LblOpticionConsultation";
            this.LblOpticionConsultation.Size = new System.Drawing.Size(139, 13);
            this.LblOpticionConsultation.TabIndex = 0;
            this.LblOpticionConsultation.Text = "O que gostaria de agendar?";
            this.LblOpticionConsultation.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxOptionsAgendamento
            // 
            this.comboBoxOptionsAgendamento.FormattingEnabled = true;
            this.comboBoxOptionsAgendamento.Items.AddRange(new object[] {
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
            this.comboBoxOptionsAgendamento.Location = new System.Drawing.Point(321, 229);
            this.comboBoxOptionsAgendamento.Name = "comboBoxOptionsAgendamento";
            this.comboBoxOptionsAgendamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOptionsAgendamento.TabIndex = 1;
            this.comboBoxOptionsAgendamento.Text = "Especialidades";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(321, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Exames";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxOptionsAgendamento);
            this.Controls.Add(this.LblOpticionConsultation);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOpticionConsultation;
        private System.Windows.Forms.ComboBox comboBoxOptionsAgendamento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}