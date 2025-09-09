namespace CONSULMED_PR2
{
    partial class CadastroMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMedico));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegistrationMed = new System.Windows.Forms.Label();
            this.lblNameMed = new System.Windows.Forms.Label();
            this.lblCpfMed = new System.Windows.Forms.Label();
            this.lblEmailMed = new System.Windows.Forms.Label();
            this.lblFoneMed = new System.Windows.Forms.Label();
            this.lblCrm = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.lblSusMed = new System.Windows.Forms.Label();
            this.lblUserMed = new System.Windows.Forms.Label();
            this.lblPasswordMed = new System.Windows.Forms.Label();
            this.lblConfirmPasswordMed = new System.Windows.Forms.Label();
            this.lblCrmMed = new System.Windows.Forms.Label();
            this.comboBoxAgreementMed = new System.Windows.Forms.ComboBox();
            this.checkBoxAgreementNoMed = new System.Windows.Forms.CheckBox();
            this.checkBoxAgreementYesMed = new System.Windows.Forms.CheckBox();
            this.checkBoxNoMed = new System.Windows.Forms.CheckBox();
            this.checkBoxYesMed = new System.Windows.Forms.CheckBox();
            this.txtNameMed = new System.Windows.Forms.TextBox();
            this.txtCpfMed = new System.Windows.Forms.TextBox();
            this.txtEmailMed = new System.Windows.Forms.TextBox();
            this.txtUserMed = new System.Windows.Forms.TextBox();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtFoneMed = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordMed = new System.Windows.Forms.TextBox();
            this.txtPasswordMed = new System.Windows.Forms.TextBox();
            this.btnSaveRegistrationMed = new System.Windows.Forms.Button();
            this.LblCodSus = new System.Windows.Forms.Label();
            this.TxtCodSus = new System.Windows.Forms.TextBox();
            this.LblCodAgreement = new System.Windows.Forms.Label();
            this.TxtCodAgreement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblRegistrationMed
            // 
            this.lblRegistrationMed.AutoSize = true;
            this.lblRegistrationMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(198)))), ((int)(((byte)(204)))));
            this.lblRegistrationMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationMed.Location = new System.Drawing.Point(21, 25);
            this.lblRegistrationMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationMed.Name = "lblRegistrationMed";
            this.lblRegistrationMed.Size = new System.Drawing.Size(293, 73);
            this.lblRegistrationMed.TabIndex = 1;
            this.lblRegistrationMed.Text = "Cadastro";
            // 
            // lblNameMed
            // 
            this.lblNameMed.AutoSize = true;
            this.lblNameMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblNameMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblNameMed.Location = new System.Drawing.Point(36, 124);
            this.lblNameMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameMed.Name = "lblNameMed";
            this.lblNameMed.Size = new System.Drawing.Size(77, 26);
            this.lblNameMed.TabIndex = 2;
            this.lblNameMed.Text = "Nome:";
            // 
            // lblCpfMed
            // 
            this.lblCpfMed.AutoSize = true;
            this.lblCpfMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblCpfMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblCpfMed.Location = new System.Drawing.Point(36, 177);
            this.lblCpfMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfMed.Name = "lblCpfMed";
            this.lblCpfMed.Size = new System.Drawing.Size(62, 26);
            this.lblCpfMed.TabIndex = 3;
            this.lblCpfMed.Text = "CPF:";
            // 
            // lblEmailMed
            // 
            this.lblEmailMed.AutoSize = true;
            this.lblEmailMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblEmailMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblEmailMed.Location = new System.Drawing.Point(36, 223);
            this.lblEmailMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailMed.Name = "lblEmailMed";
            this.lblEmailMed.Size = new System.Drawing.Size(81, 26);
            this.lblEmailMed.TabIndex = 4;
            this.lblEmailMed.Text = "E-mail:";
            // 
            // lblFoneMed
            // 
            this.lblFoneMed.AutoSize = true;
            this.lblFoneMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblFoneMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblFoneMed.Location = new System.Drawing.Point(36, 265);
            this.lblFoneMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoneMed.Name = "lblFoneMed";
            this.lblFoneMed.Size = new System.Drawing.Size(101, 26);
            this.lblFoneMed.TabIndex = 5;
            this.lblFoneMed.Text = "Telefone:";
            // 
            // lblCrm
            // 
            this.lblCrm.AutoSize = true;
            this.lblCrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblCrm.Location = new System.Drawing.Point(36, 317);
            this.lblCrm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrm.Name = "lblCrm";
            this.lblCrm.Size = new System.Drawing.Size(0, 26);
            this.lblCrm.TabIndex = 6;
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblAgreement.Location = new System.Drawing.Point(36, 359);
            this.lblAgreement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(185, 26);
            this.lblAgreement.TabIndex = 7;
            this.lblAgreement.Text = "Atende Convênio:";
            // 
            // lblSusMed
            // 
            this.lblSusMed.AutoSize = true;
            this.lblSusMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblSusMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblSusMed.Location = new System.Drawing.Point(459, 124);
            this.lblSusMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSusMed.Name = "lblSusMed";
            this.lblSusMed.Size = new System.Drawing.Size(139, 26);
            this.lblSusMed.TabIndex = 8;
            this.lblSusMed.Text = "Atende SUS:";
            // 
            // lblUserMed
            // 
            this.lblUserMed.AutoSize = true;
            this.lblUserMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblUserMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblUserMed.Location = new System.Drawing.Point(459, 238);
            this.lblUserMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserMed.Name = "lblUserMed";
            this.lblUserMed.Size = new System.Drawing.Size(188, 26);
            this.lblUserMed.TabIndex = 9;
            this.lblUserMed.Text = "Nome de Usuário:";
            // 
            // lblPasswordMed
            // 
            this.lblPasswordMed.AutoSize = true;
            this.lblPasswordMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblPasswordMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblPasswordMed.Location = new System.Drawing.Point(507, 316);
            this.lblPasswordMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordMed.Name = "lblPasswordMed";
            this.lblPasswordMed.Size = new System.Drawing.Size(81, 26);
            this.lblPasswordMed.TabIndex = 10;
            this.lblPasswordMed.Text = "Senha:";
            // 
            // lblConfirmPasswordMed
            // 
            this.lblConfirmPasswordMed.AutoSize = true;
            this.lblConfirmPasswordMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblConfirmPasswordMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblConfirmPasswordMed.Location = new System.Drawing.Point(459, 409);
            this.lblConfirmPasswordMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPasswordMed.Name = "lblConfirmPasswordMed";
            this.lblConfirmPasswordMed.Size = new System.Drawing.Size(213, 26);
            this.lblConfirmPasswordMed.TabIndex = 11;
            this.lblConfirmPasswordMed.Text = "Confirme sua senha:";
            // 
            // lblCrmMed
            // 
            this.lblCrmMed.AutoSize = true;
            this.lblCrmMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.lblCrmMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblCrmMed.Location = new System.Drawing.Point(36, 317);
            this.lblCrmMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrmMed.Name = "lblCrmMed";
            this.lblCrmMed.Size = new System.Drawing.Size(68, 26);
            this.lblCrmMed.TabIndex = 12;
            this.lblCrmMed.Text = "CRM:";
            // 
            // comboBoxAgreementMed
            // 
            this.comboBoxAgreementMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.comboBoxAgreementMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxAgreementMed.FormattingEnabled = true;
            this.comboBoxAgreementMed.Items.AddRange(new object[] {
            "Unimed",
            "Iamsp",
            "Amil",
            "Porto Seguro",
            "Bradesco",
            "SulAmérica"});
            this.comboBoxAgreementMed.Location = new System.Drawing.Point(288, 397);
            this.comboBoxAgreementMed.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAgreementMed.Name = "comboBoxAgreementMed";
            this.comboBoxAgreementMed.Size = new System.Drawing.Size(92, 24);
            this.comboBoxAgreementMed.TabIndex = 15;
            this.comboBoxAgreementMed.Text = "Qual(is)?";
            // 
            // checkBoxAgreementNoMed
            // 
            this.checkBoxAgreementNoMed.AutoSize = true;
            this.checkBoxAgreementNoMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.checkBoxAgreementNoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAgreementNoMed.Location = new System.Drawing.Point(234, 364);
            this.checkBoxAgreementNoMed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAgreementNoMed.Name = "checkBoxAgreementNoMed";
            this.checkBoxAgreementNoMed.Size = new System.Drawing.Size(53, 21);
            this.checkBoxAgreementNoMed.TabIndex = 16;
            this.checkBoxAgreementNoMed.Text = "Não";
            this.checkBoxAgreementNoMed.UseVisualStyleBackColor = false;
            this.checkBoxAgreementNoMed.CheckedChanged += new System.EventHandler(this.CheckBoxAgreementNoMed_CheckedChanged);
            // 
            // checkBoxAgreementYesMed
            // 
            this.checkBoxAgreementYesMed.AutoSize = true;
            this.checkBoxAgreementYesMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.checkBoxAgreementYesMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAgreementYesMed.Location = new System.Drawing.Point(234, 400);
            this.checkBoxAgreementYesMed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAgreementYesMed.Name = "checkBoxAgreementYesMed";
            this.checkBoxAgreementYesMed.Size = new System.Drawing.Size(50, 21);
            this.checkBoxAgreementYesMed.TabIndex = 17;
            this.checkBoxAgreementYesMed.Text = "Sim";
            this.checkBoxAgreementYesMed.UseVisualStyleBackColor = false;
            this.checkBoxAgreementYesMed.CheckedChanged += new System.EventHandler(this.CheckBoxAgreementYesMed);
            // 
            // checkBoxNoMed
            // 
            this.checkBoxNoMed.AutoSize = true;
            this.checkBoxNoMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.checkBoxNoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxNoMed.Location = new System.Drawing.Point(693, 132);
            this.checkBoxNoMed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNoMed.Name = "checkBoxNoMed";
            this.checkBoxNoMed.Size = new System.Drawing.Size(53, 21);
            this.checkBoxNoMed.TabIndex = 18;
            this.checkBoxNoMed.Text = "Não";
            this.checkBoxNoMed.UseVisualStyleBackColor = false;
            // 
            // checkBoxYesMed
            // 
            this.checkBoxYesMed.AutoSize = true;
            this.checkBoxYesMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.checkBoxYesMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxYesMed.Location = new System.Drawing.Point(622, 132);
            this.checkBoxYesMed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxYesMed.Name = "checkBoxYesMed";
            this.checkBoxYesMed.Size = new System.Drawing.Size(50, 21);
            this.checkBoxYesMed.TabIndex = 19;
            this.checkBoxYesMed.Text = "Sim";
            this.checkBoxYesMed.UseVisualStyleBackColor = false;
            // 
            // txtNameMed
            // 
            this.txtNameMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtNameMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameMed.Location = new System.Drawing.Point(119, 127);
            this.txtNameMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameMed.Name = "txtNameMed";
            this.txtNameMed.Size = new System.Drawing.Size(146, 23);
            this.txtNameMed.TabIndex = 20;
            // 
            // txtCpfMed
            // 
            this.txtCpfMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtCpfMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCpfMed.Location = new System.Drawing.Point(94, 181);
            this.txtCpfMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpfMed.Name = "txtCpfMed";
            this.txtCpfMed.Size = new System.Drawing.Size(146, 23);
            this.txtCpfMed.TabIndex = 21;
            // 
            // txtEmailMed
            // 
            this.txtEmailMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtEmailMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmailMed.Location = new System.Drawing.Point(119, 228);
            this.txtEmailMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailMed.Name = "txtEmailMed";
            this.txtEmailMed.Size = new System.Drawing.Size(146, 23);
            this.txtEmailMed.TabIndex = 22;
            // 
            // txtUserMed
            // 
            this.txtUserMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtUserMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserMed.Location = new System.Drawing.Point(482, 280);
            this.txtUserMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserMed.Name = "txtUserMed";
            this.txtUserMed.Size = new System.Drawing.Size(146, 23);
            this.txtUserMed.TabIndex = 23;
            // 
            // txtCrm
            // 
            this.txtCrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCrm.Location = new System.Drawing.Point(115, 321);
            this.txtCrm.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(146, 23);
            this.txtCrm.TabIndex = 24;
            // 
            // txtFoneMed
            // 
            this.txtFoneMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtFoneMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFoneMed.Location = new System.Drawing.Point(141, 269);
            this.txtFoneMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoneMed.Name = "txtFoneMed";
            this.txtFoneMed.Size = new System.Drawing.Size(146, 23);
            this.txtFoneMed.TabIndex = 25;
            // 
            // txtConfirmPasswordMed
            // 
            this.txtConfirmPasswordMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtConfirmPasswordMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPasswordMed.Location = new System.Drawing.Point(491, 453);
            this.txtConfirmPasswordMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPasswordMed.Name = "txtConfirmPasswordMed";
            this.txtConfirmPasswordMed.Size = new System.Drawing.Size(146, 23);
            this.txtConfirmPasswordMed.TabIndex = 26;
            // 
            // txtPasswordMed
            // 
            this.txtPasswordMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.txtPasswordMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPasswordMed.Location = new System.Drawing.Point(482, 364);
            this.txtPasswordMed.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordMed.Name = "txtPasswordMed";
            this.txtPasswordMed.Size = new System.Drawing.Size(146, 23);
            this.txtPasswordMed.TabIndex = 27;
            // 
            // btnSaveRegistrationMed
            // 
            this.btnSaveRegistrationMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRegistrationMed.Location = new System.Drawing.Point(705, 476);
            this.btnSaveRegistrationMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRegistrationMed.Name = "btnSaveRegistrationMed";
            this.btnSaveRegistrationMed.Size = new System.Drawing.Size(65, 35);
            this.btnSaveRegistrationMed.TabIndex = 28;
            this.btnSaveRegistrationMed.Text = "Salvar";
            this.btnSaveRegistrationMed.UseVisualStyleBackColor = true;
            this.btnSaveRegistrationMed.Click += new System.EventHandler(this.btnSaveRegistrationMed_Click);
            // 
            // LblCodSus
            // 
            this.LblCodSus.AutoSize = true;
            this.LblCodSus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblCodSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblCodSus.Location = new System.Drawing.Point(459, 179);
            this.LblCodSus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodSus.Name = "LblCodSus";
            this.LblCodSus.Size = new System.Drawing.Size(116, 26);
            this.LblCodSus.TabIndex = 29;
            this.LblCodSus.Text = "Cod. SUS:";
            this.LblCodSus.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCodSus
            // 
            this.TxtCodSus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.TxtCodSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtCodSus.Location = new System.Drawing.Point(600, 184);
            this.TxtCodSus.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodSus.Name = "TxtCodSus";
            this.TxtCodSus.Size = new System.Drawing.Size(146, 23);
            this.TxtCodSus.TabIndex = 30;
            // 
            // LblCodAgreement
            // 
            this.LblCodAgreement.AutoSize = true;
            this.LblCodAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.LblCodAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.LblCodAgreement.Location = new System.Drawing.Point(36, 453);
            this.LblCodAgreement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodAgreement.Name = "LblCodAgreement";
            this.LblCodAgreement.Size = new System.Drawing.Size(162, 26);
            this.LblCodAgreement.TabIndex = 31;
            this.LblCodAgreement.Text = "Cod. Convênio:";
            // 
            // TxtCodAgreement
            // 
            this.TxtCodAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.TxtCodAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtCodAgreement.Location = new System.Drawing.Point(214, 453);
            this.TxtCodAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodAgreement.Name = "TxtCodAgreement";
            this.TxtCodAgreement.Size = new System.Drawing.Size(146, 23);
            this.TxtCodAgreement.TabIndex = 32;
            // 
            // CadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.TxtCodAgreement);
            this.Controls.Add(this.LblCodAgreement);
            this.Controls.Add(this.TxtCodSus);
            this.Controls.Add(this.LblCodSus);
            this.Controls.Add(this.btnSaveRegistrationMed);
            this.Controls.Add(this.txtPasswordMed);
            this.Controls.Add(this.txtConfirmPasswordMed);
            this.Controls.Add(this.txtFoneMed);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.txtUserMed);
            this.Controls.Add(this.txtEmailMed);
            this.Controls.Add(this.txtCpfMed);
            this.Controls.Add(this.txtNameMed);
            this.Controls.Add(this.checkBoxYesMed);
            this.Controls.Add(this.checkBoxNoMed);
            this.Controls.Add(this.checkBoxAgreementYesMed);
            this.Controls.Add(this.checkBoxAgreementNoMed);
            this.Controls.Add(this.comboBoxAgreementMed);
            this.Controls.Add(this.lblCrmMed);
            this.Controls.Add(this.lblConfirmPasswordMed);
            this.Controls.Add(this.lblPasswordMed);
            this.Controls.Add(this.lblUserMed);
            this.Controls.Add(this.lblSusMed);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.lblCrm);
            this.Controls.Add(this.lblFoneMed);
            this.Controls.Add(this.lblEmailMed);
            this.Controls.Add(this.lblCpfMed);
            this.Controls.Add(this.lblNameMed);
            this.Controls.Add(this.lblRegistrationMed);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroMedico";
            this.Text = "c";
            this.Load += new System.EventHandler(this.CadastroMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegistrationMed;
        private System.Windows.Forms.Label lblNameMed;
        private System.Windows.Forms.Label lblCpfMed;
        private System.Windows.Forms.Label lblEmailMed;
        private System.Windows.Forms.Label lblFoneMed;
        private System.Windows.Forms.Label lblCrm;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Label lblSusMed;
        private System.Windows.Forms.Label lblUserMed;
        private System.Windows.Forms.Label lblPasswordMed;
        private System.Windows.Forms.Label lblConfirmPasswordMed;
        private System.Windows.Forms.Label lblCrmMed;
        private System.Windows.Forms.ComboBox comboBoxAgreementMed;
        private System.Windows.Forms.CheckBox checkBoxAgreementNoMed;
        private System.Windows.Forms.CheckBox checkBoxAgreementYesMed;
        private System.Windows.Forms.CheckBox checkBoxNoMed;
        private System.Windows.Forms.CheckBox checkBoxYesMed;
        private System.Windows.Forms.TextBox txtNameMed;
        private System.Windows.Forms.TextBox txtCpfMed;
        private System.Windows.Forms.TextBox txtEmailMed;
        private System.Windows.Forms.TextBox txtUserMed;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtFoneMed;
        private System.Windows.Forms.TextBox txtConfirmPasswordMed;
        private System.Windows.Forms.TextBox txtPasswordMed;
        private System.Windows.Forms.Button btnSaveRegistrationMed;
        private System.Windows.Forms.Label LblCodSus;
        private System.Windows.Forms.TextBox TxtCodSus;
        private System.Windows.Forms.Label LblCodAgreement;
        private System.Windows.Forms.TextBox TxtCodAgreement;
    }
}