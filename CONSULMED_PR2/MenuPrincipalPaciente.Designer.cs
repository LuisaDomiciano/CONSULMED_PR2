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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalPaciente));
            this.panelMenuPac = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerMenuPac = new System.Windows.Forms.Timer(this.components);
            this.buttonHistoricoMenuPac = new System.Windows.Forms.Button();
            this.BtnAgendarConsultaPac = new System.Windows.Forms.Button();
            this.BtnMinhasConsultasPac = new System.Windows.Forms.Button();
            this.LblConsulmedMenuPac = new System.Windows.Forms.Label();
            this.BtnMenuPac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuPac
            // 
            this.panelMenuPac.Location = new System.Drawing.Point(925, 87);
            this.panelMenuPac.Name = "panelMenuPac";
            this.panelMenuPac.Size = new System.Drawing.Size(90, 544);
            this.panelMenuPac.TabIndex = 1;
            this.panelMenuPac.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerMenuPac
            // 
            this.timerMenuPac.Interval = 50;
            this.timerMenuPac.Tick += new System.EventHandler(this.timerMenuPac_Tick);
            // 
            // buttonHistoricoMenuPac
            // 
            this.buttonHistoricoMenuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoricoMenuPac.Location = new System.Drawing.Point(370, 257);
            this.buttonHistoricoMenuPac.Name = "buttonHistoricoMenuPac";
            this.buttonHistoricoMenuPac.Size = new System.Drawing.Size(202, 62);
            this.buttonHistoricoMenuPac.TabIndex = 3;
            this.buttonHistoricoMenuPac.Text = "Histórico";
            this.buttonHistoricoMenuPac.UseVisualStyleBackColor = true;
            // 
            // BtnAgendarConsultaPac
            // 
            this.BtnAgendarConsultaPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendarConsultaPac.Location = new System.Drawing.Point(370, 358);
            this.BtnAgendarConsultaPac.Name = "BtnAgendarConsultaPac";
            this.BtnAgendarConsultaPac.Size = new System.Drawing.Size(202, 63);
            this.BtnAgendarConsultaPac.TabIndex = 4;
            this.BtnAgendarConsultaPac.Text = "Agendar Consulta";
            this.BtnAgendarConsultaPac.UseVisualStyleBackColor = true;
            this.BtnAgendarConsultaPac.Click += new System.EventHandler(this.BtnAgendarConsultaPac_Click);
            // 
            // BtnMinhasConsultasPac
            // 
            this.BtnMinhasConsultasPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinhasConsultasPac.Location = new System.Drawing.Point(370, 456);
            this.BtnMinhasConsultasPac.Name = "BtnMinhasConsultasPac";
            this.BtnMinhasConsultasPac.Size = new System.Drawing.Size(203, 63);
            this.BtnMinhasConsultasPac.TabIndex = 5;
            this.BtnMinhasConsultasPac.Text = "Minhas Consultas";
            this.BtnMinhasConsultasPac.UseVisualStyleBackColor = true;
            // 
            // LblConsulmedMenuPac
            // 
            this.LblConsulmedMenuPac.AutoSize = true;
            this.LblConsulmedMenuPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.LblConsulmedMenuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsulmedMenuPac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(182)))), ((int)(((byte)(176)))));
            this.LblConsulmedMenuPac.Location = new System.Drawing.Point(293, 60);
            this.LblConsulmedMenuPac.Name = "LblConsulmedMenuPac";
            this.LblConsulmedMenuPac.Size = new System.Drawing.Size(450, 91);
            this.LblConsulmedMenuPac.TabIndex = 6;
            this.LblConsulmedMenuPac.Text = "ConsulMed";
            // 
            // BtnMenuPac
            // 
            this.BtnMenuPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuPac.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuPac.Image")));
            this.BtnMenuPac.Location = new System.Drawing.Point(901, 60);
            this.BtnMenuPac.Name = "BtnMenuPac";
            this.BtnMenuPac.Size = new System.Drawing.Size(84, 71);
            this.BtnMenuPac.TabIndex = 2;
            this.BtnMenuPac.UseVisualStyleBackColor = true;
            this.BtnMenuPac.Click += new System.EventHandler(this.BtnMenuPac_Click);
            // 
            // MenuPrincipalPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 619);
            this.Controls.Add(this.BtnMenuPac);
            this.Controls.Add(this.LblConsulmedMenuPac);
            this.Controls.Add(this.BtnMinhasConsultasPac);
            this.Controls.Add(this.BtnAgendarConsultaPac);
            this.Controls.Add(this.buttonHistoricoMenuPac);
            this.Controls.Add(this.panelMenuPac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPrincipalPaciente";
            this.Text = "MenuPrincipalPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuPac;
        private System.Windows.Forms.Timer timerMenuPac;
        private System.Windows.Forms.Button buttonHistoricoMenuPac;
        private System.Windows.Forms.Button BtnAgendarConsultaPac;
        private System.Windows.Forms.Button BtnMinhasConsultasPac;
        private System.Windows.Forms.Label LblConsulmedMenuPac;
        private System.Windows.Forms.Button BtnMenuPac;
    }
}