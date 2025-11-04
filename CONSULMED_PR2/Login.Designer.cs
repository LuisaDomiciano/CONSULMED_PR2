namespace CONSULMED_PR2
{
    partial class TxtLoginLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TxtLoginLog));
            this.TxtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPasswordLogin = new System.Windows.Forms.Label();
            this.TxtPasswordLogin = new System.Windows.Forms.TextBox();
            this.LinkLblNotAccount = new System.Windows.Forms.LinkLabel();
            this.LinkLblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.BtnEnterLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuarioLogin
            // 
            this.TxtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.TxtUsuarioLogin.Location = new System.Drawing.Point(319, 188);
            this.TxtUsuarioLogin.Name = "TxtUsuarioLogin";
            this.TxtUsuarioLogin.Size = new System.Drawing.Size(171, 20);
            this.TxtUsuarioLogin.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(288, 139);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(220, 24);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Nome de login ou E-mail";
            // 
            // LblPasswordLogin
            // 
            this.LblPasswordLogin.AutoSize = true;
            this.LblPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordLogin.Location = new System.Drawing.Point(375, 248);
            this.LblPasswordLogin.Name = "LblPasswordLogin";
            this.LblPasswordLogin.Size = new System.Drawing.Size(65, 24);
            this.LblPasswordLogin.TabIndex = 3;
            this.LblPasswordLogin.Text = "Senha";
            // 
            // TxtPasswordLogin
            // 
            this.TxtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.TxtPasswordLogin.Location = new System.Drawing.Point(319, 300);
            this.TxtPasswordLogin.Name = "TxtPasswordLogin";
            this.TxtPasswordLogin.PasswordChar = '*';
            this.TxtPasswordLogin.Size = new System.Drawing.Size(171, 20);
            this.TxtPasswordLogin.TabIndex = 4;
            this.TxtPasswordLogin.UseSystemPasswordChar = true;
            this.TxtPasswordLogin.TextChanged += new System.EventHandler(this.TxtPasswordLogin_TextChanged);
            // 
            // LinkLblNotAccount
            // 
            this.LinkLblNotAccount.AutoSize = true;
            this.LinkLblNotAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblNotAccount.Location = new System.Drawing.Point(342, 346);
            this.LinkLblNotAccount.Name = "LinkLblNotAccount";
            this.LinkLblNotAccount.Size = new System.Drawing.Size(112, 16);
            this.LinkLblNotAccount.TabIndex = 5;
            this.LinkLblNotAccount.TabStop = true;
            this.LinkLblNotAccount.Text = "Não possui conta";
            this.LinkLblNotAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblNotAccount_LinkClicked);
            // 
            // LinkLblForgotPassword
            // 
            this.LinkLblForgotPassword.AutoSize = true;
            this.LinkLblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblForgotPassword.Location = new System.Drawing.Point(342, 375);
            this.LinkLblForgotPassword.Name = "LinkLblForgotPassword";
            this.LinkLblForgotPassword.Size = new System.Drawing.Size(107, 16);
            this.LinkLblForgotPassword.TabIndex = 6;
            this.LinkLblForgotPassword.TabStop = true;
            this.LinkLblForgotPassword.Text = "Esqueci a senha";
            this.LinkLblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblForgotPassword_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnEnterLogin
            // 
            this.BtnEnterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.BtnEnterLogin.Location = new System.Drawing.Point(697, 405);
            this.BtnEnterLogin.Name = "BtnEnterLogin";
            this.BtnEnterLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnEnterLogin.TabIndex = 8;
            this.BtnEnterLogin.Text = "ENTRAR";
            this.BtnEnterLogin.UseVisualStyleBackColor = false;
            this.BtnEnterLogin.Click += new System.EventHandler(this.BtnEnterLogin_Click);
            // 
            // TxtLoginLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEnterLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkLblForgotPassword);
            this.Controls.Add(this.LinkLblNotAccount);
            this.Controls.Add(this.TxtPasswordLogin);
            this.Controls.Add(this.LblPasswordLogin);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtUsuarioLogin);
            this.Controls.Add(this.pictureBoxLogin);
            this.Name = "TxtLoginLog";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsuarioLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPasswordLogin;
        private System.Windows.Forms.TextBox TxtPasswordLogin;
        private System.Windows.Forms.LinkLabel LinkLblNotAccount;
        private System.Windows.Forms.LinkLabel LinkLblForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button BtnEnterLogin;
    }
}