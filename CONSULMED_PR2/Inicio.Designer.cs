namespace CONSULMED_PR2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblWelcome2 = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.btnInicialMed = new System.Windows.Forms.Button();
            this.btnIncialPac = new System.Windows.Forms.Button();
            this.pictureBoxInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.LblWelcome.Location = new System.Drawing.Point(433, 47);
            this.LblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(439, 73);
            this.LblWelcome.TabIndex = 1;
            this.LblWelcome.Text = "Bem-Vindo ao";
            // 
            // LblWelcome2
            // 
            this.LblWelcome2.AutoSize = true;
            this.LblWelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.LblWelcome2.Location = new System.Drawing.Point(468, 142);
            this.LblWelcome2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWelcome2.Name = "LblWelcome2";
            this.LblWelcome2.Size = new System.Drawing.Size(375, 73);
            this.LblWelcome2.TabIndex = 2;
            this.LblWelcome2.Text = "ConsulMed!";
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(440, 300);
            this.LblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(369, 36);
            this.LblInicio.TabIndex = 3;
            this.LblInicio.Text = "Para iniciarmos, selecione:";
            // 
            // btnInicialMed
            // 
            this.btnInicialMed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicialMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicialMed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicialMed.Location = new System.Drawing.Point(481, 354);
            this.btnInicialMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicialMed.Name = "btnInicialMed";
            this.btnInicialMed.Size = new System.Drawing.Size(115, 46);
            this.btnInicialMed.TabIndex = 4;
            this.btnInicialMed.Text = "Médico";
            this.btnInicialMed.UseVisualStyleBackColor = false;
            this.btnInicialMed.Click += new System.EventHandler(this.btnInicialMed_Click);
            // 
            // btnIncialPac
            // 
            this.btnIncialPac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncialPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncialPac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIncialPac.Location = new System.Drawing.Point(667, 354);
            this.btnIncialPac.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncialPac.Name = "btnIncialPac";
            this.btnIncialPac.Size = new System.Drawing.Size(115, 46);
            this.btnIncialPac.TabIndex = 5;
            this.btnIncialPac.Text = "Paciente";
            this.btnIncialPac.UseVisualStyleBackColor = false;
            this.btnIncialPac.Click += new System.EventHandler(this.btnIncialPac_Click);
            // 
            // pictureBoxInicio
            // 
            this.pictureBoxInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInicio.Image")));
            this.pictureBoxInicio.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInicio.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxInicio.Name = "pictureBoxInicio";
            this.pictureBoxInicio.Size = new System.Drawing.Size(912, 548);
            this.pictureBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInicio.TabIndex = 0;
            this.pictureBoxInicio.TabStop = false;
            this.pictureBoxInicio.Click += new System.EventHandler(this.pictureBoxInicio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 548);
            this.Controls.Add(this.btnIncialPac);
            this.Controls.Add(this.btnInicialMed);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.LblWelcome2);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.pictureBoxInicio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblWelcome2;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Button btnInicialMed;
        private System.Windows.Forms.Button btnIncialPac;
        private System.Windows.Forms.PictureBox pictureBoxInicio;
    }
}