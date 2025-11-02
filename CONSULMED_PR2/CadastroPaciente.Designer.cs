namespace CONSULMED_PR2
{
    partial class CadastroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPaciente));
            this.PictureBoxCadastroPac = new System.Windows.Forms.PictureBox();
            this.lblRegistrationPac = new System.Windows.Forms.Label();
            this.LblNamePac = new System.Windows.Forms.Label();
            this.LblCpfPac = new System.Windows.Forms.Label();
            this.LblEmailPac = new System.Windows.Forms.Label();
            this.LblFonePac = new System.Windows.Forms.Label();
            this.lblUserPac = new System.Windows.Forms.Label();
            this.lblPasswordPac = new System.Windows.Forms.Label();
            this.lblConfirmPasswordPac = new System.Windows.Forms.Label();
            this.LblSusPac = new System.Windows.Forms.Label();
            this.LblAgreementPac = new System.Windows.Forms.Label();
            this.txtConfirmPasswordPac = new System.Windows.Forms.TextBox();
            this.txtUserPac = new System.Windows.Forms.TextBox();
            this.txtPasswordPac = new System.Windows.Forms.TextBox();
            this.TxtCodSusPac = new System.Windows.Forms.TextBox();
            this.txtFonePac = new System.Windows.Forms.TextBox();
            this.txtEmailPac = new System.Windows.Forms.TextBox();
            this.txtCpfPac = new System.Windows.Forms.TextBox();
            this.txtNamePac = new System.Windows.Forms.TextBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.btnSaveRegistrationPac = new System.Windows.Forms.Button();
            this.comboBoxAgreementPac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCadastroPac)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxCadastroPac
            // 
            this.PictureBoxCadastroPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCadastroPac.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCadastroPac.Image")));
            this.PictureBoxCadastroPac.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCadastroPac.Name = "PictureBoxCadastroPac";
            this.PictureBoxCadastroPac.Size = new System.Drawing.Size(1019, 642);
            this.PictureBoxCadastroPac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCadastroPac.TabIndex = 0;
            this.PictureBoxCadastroPac.TabStop = false;
            this.PictureBoxCadastroPac.Click += new System.EventHandler(this.PictureBoxCadastroPac_Click);
            // 
            // lblRegistrationPac
            // 
            this.lblRegistrationPac.AutoSize = true;
            this.lblRegistrationPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(198)))), ((int)(((byte)(204)))));
            this.lblRegistrationPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationPac.Location = new System.Drawing.Point(43, 18);
            this.lblRegistrationPac.Name = "lblRegistrationPac";
            this.lblRegistrationPac.Size = new System.Drawing.Size(362, 91);
            this.lblRegistrationPac.TabIndex = 2;
            this.lblRegistrationPac.Text = "Cadastro";
            // 
            // LblNamePac
            // 
            this.LblNamePac.AutoSize = true;
            this.LblNamePac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblNamePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblNamePac.Location = new System.Drawing.Point(53, 162);
            this.LblNamePac.Name = "LblNamePac";
            this.LblNamePac.Size = new System.Drawing.Size(97, 32);
            this.LblNamePac.TabIndex = 3;
            this.LblNamePac.Text = "Nome:";
            // 
            // LblCpfPac
            // 
            this.LblCpfPac.AutoSize = true;
            this.LblCpfPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblCpfPac.Location = new System.Drawing.Point(53, 232);
            this.LblCpfPac.Name = "LblCpfPac";
            this.LblCpfPac.Size = new System.Drawing.Size(78, 32);
            this.LblCpfPac.TabIndex = 4;
            this.LblCpfPac.Text = "CPF:";
            // 
            // LblEmailPac
            // 
            this.LblEmailPac.AutoSize = true;
            this.LblEmailPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblEmailPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblEmailPac.Location = new System.Drawing.Point(53, 301);
            this.LblEmailPac.Name = "LblEmailPac";
            this.LblEmailPac.Size = new System.Drawing.Size(103, 32);
            this.LblEmailPac.TabIndex = 5;
            this.LblEmailPac.Text = "E-mail:";
            // 
            // LblFonePac
            // 
            this.LblFonePac.AutoSize = true;
            this.LblFonePac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblFonePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblFonePac.Location = new System.Drawing.Point(53, 383);
            this.LblFonePac.Name = "LblFonePac";
            this.LblFonePac.Size = new System.Drawing.Size(134, 32);
            this.LblFonePac.TabIndex = 6;
            this.LblFonePac.Text = "Telefone:";
            // 
            // lblUserPac
            // 
            this.lblUserPac.AutoSize = true;
            this.lblUserPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblUserPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblUserPac.Location = new System.Drawing.Point(648, 168);
            this.lblUserPac.Name = "lblUserPac";
            this.lblUserPac.Size = new System.Drawing.Size(241, 32);
            this.lblUserPac.TabIndex = 10;
            this.lblUserPac.Text = "Nome de Usuário:";
            // 
            // lblPasswordPac
            // 
            this.lblPasswordPac.AutoSize = true;
            this.lblPasswordPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblPasswordPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblPasswordPac.Location = new System.Drawing.Point(722, 301);
            this.lblPasswordPac.Name = "lblPasswordPac";
            this.lblPasswordPac.Size = new System.Drawing.Size(105, 32);
            this.lblPasswordPac.TabIndex = 11;
            this.lblPasswordPac.Text = "Senha:";
            // 
            // lblConfirmPasswordPac
            // 
            this.lblConfirmPasswordPac.AutoSize = true;
            this.lblConfirmPasswordPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblConfirmPasswordPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblConfirmPasswordPac.Location = new System.Drawing.Point(634, 411);
            this.lblConfirmPasswordPac.Name = "lblConfirmPasswordPac";
            this.lblConfirmPasswordPac.Size = new System.Drawing.Size(275, 32);
            this.lblConfirmPasswordPac.TabIndex = 12;
            this.lblConfirmPasswordPac.Text = "Confirme sua senha:";
            // 
            // LblSusPac
            // 
            this.LblSusPac.AutoSize = true;
            this.LblSusPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblSusPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblSusPac.Location = new System.Drawing.Point(53, 453);
            this.LblSusPac.Name = "LblSusPac";
            this.LblSusPac.Size = new System.Drawing.Size(156, 32);
            this.LblSusPac.TabIndex = 13;
            this.LblSusPac.Text = "Nº do SUS:";
            // 
            // LblAgreementPac
            // 
            this.LblAgreementPac.AutoSize = true;
            this.LblAgreementPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblAgreementPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblAgreementPac.Location = new System.Drawing.Point(53, 529);
            this.LblAgreementPac.Name = "LblAgreementPac";
            this.LblAgreementPac.Size = new System.Drawing.Size(236, 32);
            this.LblAgreementPac.TabIndex = 14;
            this.LblAgreementPac.Text = "Possui Convênio:";
            // 
            // txtConfirmPasswordPac
            // 
            this.txtConfirmPasswordPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtConfirmPasswordPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPasswordPac.Location = new System.Drawing.Point(687, 488);
            this.txtConfirmPasswordPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPasswordPac.Name = "txtConfirmPasswordPac";
            this.txtConfirmPasswordPac.Size = new System.Drawing.Size(193, 26);
            this.txtConfirmPasswordPac.TabIndex = 21;
            // 
            // txtUserPac
            // 
            this.txtUserPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtUserPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserPac.Location = new System.Drawing.Point(677, 239);
            this.txtUserPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPac.Name = "txtUserPac";
            this.txtUserPac.Size = new System.Drawing.Size(193, 26);
            this.txtUserPac.TabIndex = 22;
            // 
            // txtPasswordPac
            // 
            this.txtPasswordPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtPasswordPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPasswordPac.Location = new System.Drawing.Point(677, 358);
            this.txtPasswordPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordPac.Name = "txtPasswordPac";
            this.txtPasswordPac.Size = new System.Drawing.Size(193, 26);
            this.txtPasswordPac.TabIndex = 23;
            // 
            // TxtCodSusPac
            // 
            this.TxtCodSusPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.TxtCodSusPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtCodSusPac.Location = new System.Drawing.Point(215, 460);
            this.TxtCodSusPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodSusPac.Name = "TxtCodSusPac";
            this.TxtCodSusPac.Size = new System.Drawing.Size(193, 26);
            this.TxtCodSusPac.TabIndex = 24;
            // 
            // txtFonePac
            // 
            this.txtFonePac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtFonePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFonePac.Location = new System.Drawing.Point(193, 390);
            this.txtFonePac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFonePac.Name = "txtFonePac";
            this.txtFonePac.Size = new System.Drawing.Size(193, 26);
            this.txtFonePac.TabIndex = 25;
            // 
            // txtEmailPac
            // 
            this.txtEmailPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtEmailPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmailPac.Location = new System.Drawing.Point(166, 307);
            this.txtEmailPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailPac.Name = "txtEmailPac";
            this.txtEmailPac.Size = new System.Drawing.Size(193, 26);
            this.txtEmailPac.TabIndex = 26;
            // 
            // txtCpfPac
            // 
            this.txtCpfPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCpfPac.Location = new System.Drawing.Point(137, 238);
            this.txtCpfPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpfPac.Name = "txtCpfPac";
            this.txtCpfPac.Size = new System.Drawing.Size(193, 26);
            this.txtCpfPac.TabIndex = 27;
            // 
            // txtNamePac
            // 
            this.txtNamePac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtNamePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNamePac.Location = new System.Drawing.Point(156, 168);
            this.txtNamePac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePac.Name = "txtNamePac";
            this.txtNamePac.Size = new System.Drawing.Size(193, 26);
            this.txtNamePac.TabIndex = 28;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.Location = new System.Drawing.Point(316, 532);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(61, 28);
            this.radioButtonYes.TabIndex = 29;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Sim";
            this.radioButtonYes.UseVisualStyleBackColor = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.Location = new System.Drawing.Point(316, 581);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(64, 26);
            this.radioButtonNo.TabIndex = 30;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Não";
            this.radioButtonNo.UseVisualStyleBackColor = false;

            // 
            // btnSaveRegistrationPac
            // 
            this.btnSaveRegistrationPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRegistrationPac.Location = new System.Drawing.Point(871, 581);
            this.btnSaveRegistrationPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRegistrationPac.Name = "btnSaveRegistrationPac";
            this.btnSaveRegistrationPac.Size = new System.Drawing.Size(87, 43);
            this.btnSaveRegistrationPac.TabIndex = 31;
            this.btnSaveRegistrationPac.Text = "Salvar";
            this.btnSaveRegistrationPac.UseVisualStyleBackColor = true;
            this.btnSaveRegistrationPac.Click += new System.EventHandler(this.btnSaveRegistrationPac_Click);
            // 
            // comboBoxAgreementPac
            // 
            this.comboBoxAgreementPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.comboBoxAgreementPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxAgreementPac.FormattingEnabled = true;
            this.comboBoxAgreementPac.Items.AddRange(new object[] {
            "Unimed",
            "Iamsp",
            "Amil",
            "Porto Seguro",
            "Bradesco",
            "SulAmérica"});
            this.comboBoxAgreementPac.Location = new System.Drawing.Point(405, 533);
            this.comboBoxAgreementPac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAgreementPac.Name = "comboBoxAgreementPac";
            this.comboBoxAgreementPac.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAgreementPac.TabIndex = 32;
            this.comboBoxAgreementPac.Text = "Selecione:";
        
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.comboBoxAgreementPac);
            this.Controls.Add(this.btnSaveRegistrationPac);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.txtNamePac);
            this.Controls.Add(this.txtCpfPac);
            this.Controls.Add(this.txtEmailPac);
            this.Controls.Add(this.txtFonePac);
            this.Controls.Add(this.TxtCodSusPac);
            this.Controls.Add(this.txtPasswordPac);
            this.Controls.Add(this.txtUserPac);
            this.Controls.Add(this.txtConfirmPasswordPac);
            this.Controls.Add(this.LblAgreementPac);
            this.Controls.Add(this.LblSusPac);
            this.Controls.Add(this.lblConfirmPasswordPac);
            this.Controls.Add(this.lblPasswordPac);
            this.Controls.Add(this.lblUserPac);
            this.Controls.Add(this.LblFonePac);
            this.Controls.Add(this.LblEmailPac);
            this.Controls.Add(this.LblCpfPac);
            this.Controls.Add(this.LblNamePac);
            this.Controls.Add(this.lblRegistrationPac);
            this.Controls.Add(this.PictureBoxCadastroPac);
            this.Name = "CadastroPaciente";
            this.Text = "CadastroPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCadastroPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxCadastroPac;
        private System.Windows.Forms.Label lblRegistrationPac;
        private System.Windows.Forms.Label LblNamePac;
        private System.Windows.Forms.Label LblCpfPac;
        private System.Windows.Forms.Label LblEmailPac;
        private System.Windows.Forms.Label LblFonePac;
        private System.Windows.Forms.Label lblUserPac;
        private System.Windows.Forms.Label lblPasswordPac;
        private System.Windows.Forms.Label lblConfirmPasswordPac;
        private System.Windows.Forms.Label LblSusPac;
        private System.Windows.Forms.Label LblAgreementPac;
        private System.Windows.Forms.TextBox txtConfirmPasswordPac;
        private System.Windows.Forms.TextBox txtUserPac;
        private System.Windows.Forms.TextBox txtPasswordPac;
        private System.Windows.Forms.TextBox TxtCodSusPac;
        private System.Windows.Forms.TextBox txtFonePac;
        private System.Windows.Forms.TextBox txtEmailPac;
        private System.Windows.Forms.TextBox txtCpfPac;
        private System.Windows.Forms.TextBox txtNamePac;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Button btnSaveRegistrationPac;
        private System.Windows.Forms.ComboBox comboBoxAgreementPac;
    }
}