namespace CONSULMED_PR2
{
    partial class MenuPrincipalPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalPaciente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHistoricoMenuPac = new System.Windows.Forms.Button();
            this.BtnAgendarConsultaPac = new System.Windows.Forms.Button();
            this.BtnMinhasConsultasPac = new System.Windows.Forms.Button();
            this.LblConsulmedMenuPac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonHistoricoMenuPac
            // 
            this.buttonHistoricoMenuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoricoMenuPac.Location = new System.Drawing.Point(321, 224);
            this.buttonHistoricoMenuPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHistoricoMenuPac.Name = "buttonHistoricoMenuPac";
            this.buttonHistoricoMenuPac.Size = new System.Drawing.Size(152, 51);
            this.buttonHistoricoMenuPac.TabIndex = 3;
            this.buttonHistoricoMenuPac.Text = "Histórico";
            this.buttonHistoricoMenuPac.UseVisualStyleBackColor = true;
            this.buttonHistoricoMenuPac.Click += new System.EventHandler(this.buttonHistoricoMenuPac_Click);
            // 
            // BtnAgendarConsultaPac
            // 
            this.BtnAgendarConsultaPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendarConsultaPac.Location = new System.Drawing.Point(321, 296);
            this.BtnAgendarConsultaPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgendarConsultaPac.Name = "BtnAgendarConsultaPac";
            this.BtnAgendarConsultaPac.Size = new System.Drawing.Size(152, 51);
            this.BtnAgendarConsultaPac.TabIndex = 4;
            this.BtnAgendarConsultaPac.Text = "Agendar Consulta";
            this.BtnAgendarConsultaPac.UseVisualStyleBackColor = true;
            this.BtnAgendarConsultaPac.Click += new System.EventHandler(this.BtnAgendarConsultaPac_Click);
            // 
            // BtnMinhasConsultasPac
            // 
            this.BtnMinhasConsultasPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinhasConsultasPac.Location = new System.Drawing.Point(321, 371);
            this.BtnMinhasConsultasPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMinhasConsultasPac.Name = "BtnMinhasConsultasPac";
            this.BtnMinhasConsultasPac.Size = new System.Drawing.Size(152, 51);
            this.BtnMinhasConsultasPac.TabIndex = 5;
            this.BtnMinhasConsultasPac.Text = "Minhas Consultas";
            this.BtnMinhasConsultasPac.UseVisualStyleBackColor = true;
            this.BtnMinhasConsultasPac.Click += new System.EventHandler(this.BtnMinhasConsultasPac_Click);
            // 
            // LblConsulmedMenuPac
            // 
            this.LblConsulmedMenuPac.AutoSize = true;
            this.LblConsulmedMenuPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.LblConsulmedMenuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsulmedMenuPac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(182)))), ((int)(((byte)(176)))));
            this.LblConsulmedMenuPac.Location = new System.Drawing.Point(220, 49);
            this.LblConsulmedMenuPac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblConsulmedMenuPac.Name = "LblConsulmedMenuPac";
            this.LblConsulmedMenuPac.Size = new System.Drawing.Size(366, 73);
            this.LblConsulmedMenuPac.TabIndex = 6;
            this.LblConsulmedMenuPac.Text = "ConsulMed";
            // 
            // MenuPrincipalPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 503);
            this.Controls.Add(this.LblConsulmedMenuPac);
            this.Controls.Add(this.BtnMinhasConsultasPac);
            this.Controls.Add(this.BtnAgendarConsultaPac);
            this.Controls.Add(this.buttonHistoricoMenuPac);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipalPaciente";
            this.Text = "MenuPrincipalPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHistoricoMenuPac;
        private System.Windows.Forms.Button BtnAgendarConsultaPac;
        private System.Windows.Forms.Button BtnMinhasConsultasPac;
        private System.Windows.Forms.Label LblConsulmedMenuPac;
    }
}