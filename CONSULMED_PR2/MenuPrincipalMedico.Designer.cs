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
            this.pictureBoxMenuMedico = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.BtnAgendaMenuMed = new System.Windows.Forms.Button();
            this.BtnHistoricoMed = new System.Windows.Forms.Button();
            this.BtnMinhasConsultasMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMenuMedico
            // 
            this.pictureBoxMenuMedico.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMenuMedico.Name = "pictureBoxMenuMedico";
            this.pictureBoxMenuMedico.Size = new System.Drawing.Size(1067, 554);
            this.pictureBoxMenuMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuMedico.TabIndex = 1;
            this.pictureBoxMenuMedico.TabStop = false;
            this.pictureBoxMenuMedico.Click += new System.EventHandler(this.pictureBoxMenuMedico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(767, 276);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 10);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgendaMenuMed
            // 
            this.BtnAgendaMenuMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendaMenuMed.Location = new System.Drawing.Point(444, 203);
            this.BtnAgendaMenuMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgendaMenuMed.Name = "BtnAgendaMenuMed";
            this.BtnAgendaMenuMed.Size = new System.Drawing.Size(173, 70);
            this.BtnAgendaMenuMed.TabIndex = 2;
            this.BtnAgendaMenuMed.Text = "Agenda";
            this.BtnAgendaMenuMed.UseVisualStyleBackColor = true;
            this.BtnAgendaMenuMed.Click += new System.EventHandler(this.BtnAgendaMenuMed_Click);
            // 
            // BtnHistoricoMed
            // 
            this.BtnHistoricoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoricoMed.Location = new System.Drawing.Point(444, 310);
            this.BtnHistoricoMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHistoricoMed.Name = "BtnHistoricoMed";
            this.BtnHistoricoMed.Size = new System.Drawing.Size(173, 70);
            this.BtnHistoricoMed.TabIndex = 3;
            this.BtnHistoricoMed.Text = "Histórico";
            this.BtnHistoricoMed.UseVisualStyleBackColor = true;
            this.BtnHistoricoMed.Click += new System.EventHandler(this.BtnHistoricoMed_Click_1);
            // 
            // BtnMinhasConsultasMed
            // 
            this.BtnMinhasConsultasMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinhasConsultasMed.Location = new System.Drawing.Point(444, 414);
            this.BtnMinhasConsultasMed.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinhasConsultasMed.Name = "BtnMinhasConsultasMed";
            this.BtnMinhasConsultasMed.Size = new System.Drawing.Size(173, 70);
            this.BtnMinhasConsultasMed.TabIndex = 5;
            this.BtnMinhasConsultasMed.Text = "Minhas Consultas";
            this.BtnMinhasConsultasMed.UseVisualStyleBackColor = true;
            this.BtnMinhasConsultasMed.Click += new System.EventHandler(this.BtnMinhasConsultasMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu Principal";
            // 
            // MenuPrincipalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMinhasConsultasMed);
            this.Controls.Add(this.BtnHistoricoMed);
            this.Controls.Add(this.BtnAgendaMenuMed);
            this.Controls.Add(this.pictureBoxMenuMedico);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipalMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxMenuMedico;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button BtnAgendaMenuMed;
        private System.Windows.Forms.Button BtnHistoricoMed;
        private System.Windows.Forms.Button BtnMinhasConsultasMed;
        private System.Windows.Forms.Label label1;
    }
}