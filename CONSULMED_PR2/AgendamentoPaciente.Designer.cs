namespace CONSULMED_PR2
{
    partial class AgendamentoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendamentoPaciente));
            this.lblAgendamentosMed = new System.Windows.Forms.Label();
            this.LblFiltroPac = new System.Windows.Forms.Label();
            this.comboBoxFiltroMed = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroEspecialidade = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFiltroPac = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgendamentosMed
            // 
            this.lblAgendamentosMed.AutoSize = true;
            this.lblAgendamentosMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.lblAgendamentosMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblAgendamentosMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.lblAgendamentosMed.Location = new System.Drawing.Point(245, 9);
            this.lblAgendamentosMed.Name = "lblAgendamentosMed";
            this.lblAgendamentosMed.Size = new System.Drawing.Size(424, 73);
            this.lblAgendamentosMed.TabIndex = 2;
            this.lblAgendamentosMed.Text = "CONSULTAS";
            // 
            // LblFiltroPac
            // 
            this.LblFiltroPac.AutoSize = true;
            this.LblFiltroPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.LblFiltroPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltroPac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblFiltroPac.Location = new System.Drawing.Point(60, 112);
            this.LblFiltroPac.Name = "LblFiltroPac";
            this.LblFiltroPac.Size = new System.Drawing.Size(92, 29);
            this.LblFiltroPac.TabIndex = 9;
            this.LblFiltroPac.Text = "Filtros: ";
            // 
            // comboBoxFiltroMed
            // 
            this.comboBoxFiltroMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.comboBoxFiltroMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxFiltroMed.FormattingEnabled = true;
            this.comboBoxFiltroMed.Items.AddRange(new object[] {
            "Carlos",
            "Felipe",
            "Rodrigo",
            "Fernando",
            "José",
            "Ronaldo",
            "Jéssica",
            "Suzana",
            "Simone",
            "Rafaela",
            "Rafael",
            "Marques",
            "Marlon",
            "Walter",
            "Ubiratan",
            "Alisson",
            "Karin",
            "Tiago",
            "Luciana",
            "Ana Paula",
            "Bianch",
            "Waldemir",
            "Gabriel",
            "Heder",
            "Maíra"});
            this.comboBoxFiltroMed.Location = new System.Drawing.Point(168, 112);
            this.comboBoxFiltroMed.Name = "comboBoxFiltroMed";
            this.comboBoxFiltroMed.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFiltroMed.TabIndex = 10;
            this.comboBoxFiltroMed.Text = "Medico:";
            // 
            // comboBoxFiltroEspecialidade
            // 
            this.comboBoxFiltroEspecialidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.comboBoxFiltroEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxFiltroEspecialidade.FormattingEnabled = true;
            this.comboBoxFiltroEspecialidade.Items.AddRange(new object[] {
            "Clínica Geral / Medicina da Família",
            "",
            "",
            "Pediatria",
            "",
            "",
            "Ginecologia",
            "Obstetrícia",
            "",
            "",
            "Cardiologia",
            "",
            "",
            "Dermatologia",
            "",
            "",
            "Ortopedia ",
            "Traumatologia",
            "",
            "Oftalmologia",
            "",
            "",
            "Otorrinolaringologia ",
            "Neurologia",
            "",
            "",
            "Psiquiatria",
            "",
            "",
            "Endocrinologia",
            "",
            "",
            "Gastroenterologia",
            "",
            "",
            "Urologia",
            "",
            "",
            "Reumatologia",
            "",
            "",
            "Nefrologia",
            "",
            "",
            "Pneumologia",
            "",
            "",
            "Infectologia"});
            this.comboBoxFiltroEspecialidade.Location = new System.Drawing.Point(314, 114);
            this.comboBoxFiltroEspecialidade.Name = "comboBoxFiltroEspecialidade";
            this.comboBoxFiltroEspecialidade.Size = new System.Drawing.Size(154, 28);
            this.comboBoxFiltroEspecialidade.TabIndex = 11;
            this.comboBoxFiltroEspecialidade.Text = "Especialidades: ";
            // 
            // dateTimePickerFiltroPac
            // 
            this.dateTimePickerFiltroPac.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.dateTimePickerFiltroPac.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.dateTimePickerFiltroPac.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.dateTimePickerFiltroPac.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.dateTimePickerFiltroPac.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(229)))));
            this.dateTimePickerFiltroPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFiltroPac.Location = new System.Drawing.Point(489, 116);
            this.dateTimePickerFiltroPac.Name = "dateTimePickerFiltroPac";
            this.dateTimePickerFiltroPac.Size = new System.Drawing.Size(332, 26);
            this.dateTimePickerFiltroPac.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AgendamentoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 495);
            this.Controls.Add(this.dateTimePickerFiltroPac);
            this.Controls.Add(this.comboBoxFiltroEspecialidade);
            this.Controls.Add(this.comboBoxFiltroMed);
            this.Controls.Add(this.LblFiltroPac);
            this.Controls.Add(this.lblAgendamentosMed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgendamentoPaciente";
            this.Text = "AgendamentoPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAgendamentosMed;
        private System.Windows.Forms.Label LblFiltroPac;
        private System.Windows.Forms.ComboBox comboBoxFiltroMed;
        private System.Windows.Forms.ComboBox comboBoxFiltroEspecialidade;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltroPac;
    }
}