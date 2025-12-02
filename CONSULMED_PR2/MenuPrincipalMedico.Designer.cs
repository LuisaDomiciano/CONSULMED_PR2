namespace CONSULMED_PR2
{
    partial class MenuPrincipalMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalMedico));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.BtnAgendaMenuMed = new System.Windows.Forms.Button();
            this.BtnHistoricoMed = new System.Windows.Forms.Button();
            this.BtnMinhasConsultasMed = new System.Windows.Forms.Button();
            this.LblConsulmedMenuMed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuMedico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgendaMenuMed
            // 
            this.BtnAgendaMenuMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendaMenuMed.Location = new System.Drawing.Point(333, 177);
            this.BtnAgendaMenuMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgendaMenuMed.Name = "BtnAgendaMenuMed";
            this.BtnAgendaMenuMed.Size = new System.Drawing.Size(166, 57);
            this.BtnAgendaMenuMed.TabIndex = 2;
            this.BtnAgendaMenuMed.Text = "Agenda";
            this.BtnAgendaMenuMed.UseVisualStyleBackColor = true;
            this.BtnAgendaMenuMed.Click += new System.EventHandler(this.BtnAgendaMenuMed_Click);
            // 
            // BtnHistoricoMed
            // 
            this.BtnHistoricoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoricoMed.Location = new System.Drawing.Point(333, 261);
            this.BtnHistoricoMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHistoricoMed.Name = "BtnHistoricoMed";
            this.BtnHistoricoMed.Size = new System.Drawing.Size(166, 57);
            this.BtnHistoricoMed.TabIndex = 3;
            this.BtnHistoricoMed.Text = "Histórico";
            this.BtnHistoricoMed.UseVisualStyleBackColor = true;
            this.BtnHistoricoMed.Click += new System.EventHandler(this.BtnHistoricoMed_Click_1);
            // 
            // BtnMinhasConsultasMed
            // 
            this.BtnMinhasConsultasMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinhasConsultasMed.Location = new System.Drawing.Point(333, 347);
            this.BtnMinhasConsultasMed.Name = "BtnMinhasConsultasMed";
            this.BtnMinhasConsultasMed.Size = new System.Drawing.Size(166, 57);
            this.BtnMinhasConsultasMed.TabIndex = 5;
            this.BtnMinhasConsultasMed.Text = "Minhas Consultas";
            this.BtnMinhasConsultasMed.UseVisualStyleBackColor = true;
            this.BtnMinhasConsultasMed.Click += new System.EventHandler(this.BtnMinhasConsultasMed_Click);
            // 
            // LblConsulmedMenuMed
            // 
            this.LblConsulmedMenuMed.AutoSize = true;
            this.LblConsulmedMenuMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.LblConsulmedMenuMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsulmedMenuMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(182)))), ((int)(((byte)(176)))));
            this.LblConsulmedMenuMed.Location = new System.Drawing.Point(246, 43);
            this.LblConsulmedMenuMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblConsulmedMenuMed.Name = "LblConsulmedMenuMed";
            this.LblConsulmedMenuMed.Size = new System.Drawing.Size(366, 73);
            this.LblConsulmedMenuMed.TabIndex = 8;
            this.LblConsulmedMenuMed.Text = "ConsulMed";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxMenuMedico
            // 
            this.pictureBoxMenuMedico.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuMedico.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMenuMedico.Name = "pictureBoxMenuMedico";
            this.pictureBoxMenuMedico.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxMenuMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuMedico.TabIndex = 1;
            this.pictureBoxMenuMedico.TabStop = false;
            this.pictureBoxMenuMedico.Click += new System.EventHandler(this.pictureBoxMenuMedico_Click);
            // 
            // MenuPrincipalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblConsulmedMenuMed);
            this.Controls.Add(this.BtnMinhasConsultasMed);
            this.Controls.Add(this.BtnHistoricoMed);
            this.Controls.Add(this.BtnAgendaMenuMed);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxMenuMedico);
            this.Name = "MenuPrincipalMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMenuMedico;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button BtnAgendaMenuMed;
        private System.Windows.Forms.Button BtnHistoricoMed;
        private System.Windows.Forms.Button BtnMinhasConsultasMed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblConsulmedMenuMed;
    }
}