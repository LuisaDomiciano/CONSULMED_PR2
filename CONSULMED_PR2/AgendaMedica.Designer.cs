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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CONSULMED_PR2.Properties.Resources.Design_sem_nome__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblAgendaMed
            // 
            this.LblAgendaMed.AutoSize = true;
            this.LblAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgendaMed.Location = new System.Drawing.Point(293, 9);
            this.LblAgendaMed.Name = "LblAgendaMed";
            this.LblAgendaMed.Size = new System.Drawing.Size(312, 91);
            this.LblAgendaMed.TabIndex = 1;
            this.LblAgendaMed.Text = "Agenda";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(83, 172);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // BtnMarcarAgenda
            // 
            this.BtnMarcarAgenda.Location = new System.Drawing.Point(462, 172);
            this.BtnMarcarAgenda.Name = "BtnMarcarAgenda";
            this.BtnMarcarAgenda.Size = new System.Drawing.Size(242, 71);
            this.BtnMarcarAgenda.TabIndex = 4;
            this.BtnMarcarAgenda.Text = "Cancelar Consulta";
            this.BtnMarcarAgenda.UseVisualStyleBackColor = true;
            // 
            // BtnRemarcrAgenda
            // 
            this.BtnRemarcrAgenda.Location = new System.Drawing.Point(462, 308);
            this.BtnRemarcrAgenda.Name = "BtnRemarcrAgenda";
            this.BtnRemarcrAgenda.Size = new System.Drawing.Size(242, 71);
            this.BtnRemarcrAgenda.TabIndex = 5;
            this.BtnRemarcrAgenda.Text = "Remarcar Consulta";
            this.BtnRemarcrAgenda.UseVisualStyleBackColor = true;
            // 
            // AgendaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 490);
            this.Controls.Add(this.BtnRemarcrAgenda);
            this.Controls.Add(this.BtnMarcarAgenda);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.LblAgendaMed);
            this.Controls.Add(this.pictureBox1);
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
    }
}