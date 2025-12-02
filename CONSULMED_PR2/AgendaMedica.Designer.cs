namespace CONSULMED_PR2
{
    partial class AgendaMedica
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblAgendaMed = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnMarcarAgenda = new System.Windows.Forms.Button();
            this.BtnRemarcrAgenda = new System.Windows.Forms.Button();
            this.BtnVoltarMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CONSULMED_PR2.Properties.Resources.Design_sem_nome__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblAgendaMed
            // 
            this.LblAgendaMed.AutoSize = true;
            this.LblAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgendaMed.Location = new System.Drawing.Point(220, 7);
            this.LblAgendaMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAgendaMed.Name = "LblAgendaMed";
            this.LblAgendaMed.Size = new System.Drawing.Size(255, 73);
            this.LblAgendaMed.TabIndex = 1;
            this.LblAgendaMed.Text = "Agenda";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 140);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // BtnMarcarAgenda
            // 
            this.BtnMarcarAgenda.Location = new System.Drawing.Point(346, 140);
            this.BtnMarcarAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMarcarAgenda.Name = "BtnMarcarAgenda";
            this.BtnMarcarAgenda.Size = new System.Drawing.Size(182, 58);
            this.BtnMarcarAgenda.TabIndex = 4;
            this.BtnMarcarAgenda.Text = "Cancelar Consulta";
            this.BtnMarcarAgenda.UseVisualStyleBackColor = true;
            // 
            // BtnRemarcrAgenda
            // 
            this.BtnRemarcrAgenda.Location = new System.Drawing.Point(346, 250);
            this.BtnRemarcrAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRemarcrAgenda.Name = "BtnRemarcrAgenda";
            this.BtnRemarcrAgenda.Size = new System.Drawing.Size(182, 58);
            this.BtnRemarcrAgenda.TabIndex = 5;
            this.BtnRemarcrAgenda.Text = "Remarcar Consulta";
            this.BtnRemarcrAgenda.UseVisualStyleBackColor = true;
            // 
            // BtnVoltarMed
            // 
            this.BtnVoltarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarMed.Location = new System.Drawing.Point(12, 351);
            this.BtnVoltarMed.Name = "BtnVoltarMed";
            this.BtnVoltarMed.Size = new System.Drawing.Size(71, 35);
            this.BtnVoltarMed.TabIndex = 11;
            this.BtnVoltarMed.Text = "Voltar";
            this.BtnVoltarMed.UseVisualStyleBackColor = true;
            this.BtnVoltarMed.Click += new System.EventHandler(this.BtnVoltarMed_Click);
            // 
            // AgendaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 398);
            this.Controls.Add(this.BtnVoltarMed);
            this.Controls.Add(this.BtnRemarcrAgenda);
            this.Controls.Add(this.BtnMarcarAgenda);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.LblAgendaMed);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgendaMedica";
            this.Text = "AgendaMedica";
            this.Load += new System.EventHandler(this.AgendaMedica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblAgendaMed;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnMarcarAgenda;
        private System.Windows.Forms.Button BtnRemarcrAgenda;
        private System.Windows.Forms.Button BtnVoltarMed;
    }
}