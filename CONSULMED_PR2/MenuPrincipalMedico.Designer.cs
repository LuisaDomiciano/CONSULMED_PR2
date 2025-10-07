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
            this.pictureBoxMenuMedico = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.BtnAgendaMenuMed = new System.Windows.Forms.Button();
            this.BtnHistoricoMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMenuMedico
            // 
            this.pictureBoxMenuMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMenuMedico.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenuMedico.Image")));
            this.pictureBoxMenuMedico.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxMenuMedico.Name = "pictureBoxMenuMedico";
            this.pictureBoxMenuMedico.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxMenuMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuMedico.TabIndex = 1;
            this.pictureBoxMenuMedico.TabStop = false;
            this.pictureBoxMenuMedico.Click += new System.EventHandler(this.pictureBoxMenuMedico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(575, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgendaMenuMed
            // 
            this.BtnAgendaMenuMed.Location = new System.Drawing.Point(373, 173);
            this.BtnAgendaMenuMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgendaMenuMed.Name = "BtnAgendaMenuMed";
            this.BtnAgendaMenuMed.Size = new System.Drawing.Size(56, 19);
            this.BtnAgendaMenuMed.TabIndex = 2;
            this.BtnAgendaMenuMed.Text = "Agenda";
            this.BtnAgendaMenuMed.UseVisualStyleBackColor = true;
            this.BtnAgendaMenuMed.Click += new System.EventHandler(this.BtnAgendaMenuMed_Click);
            // 
            // BtnHistoricoMed
            // 
            this.BtnHistoricoMed.Location = new System.Drawing.Point(373, 224);
            this.BtnHistoricoMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHistoricoMed.Name = "BtnHistoricoMed";
            this.BtnHistoricoMed.Size = new System.Drawing.Size(56, 19);
            this.BtnHistoricoMed.TabIndex = 3;
            this.BtnHistoricoMed.Text = "Histórico";
            this.BtnHistoricoMed.UseVisualStyleBackColor = true;

            // 
            // MenuPrincipalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHistoricoMed);
            this.Controls.Add(this.BtnAgendaMenuMed);
            this.Controls.Add(this.pictureBoxMenuMedico);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPrincipalMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxMenuMedico;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button BtnAgendaMenuMed;
        private System.Windows.Forms.Button BtnHistoricoMed;
    }
}