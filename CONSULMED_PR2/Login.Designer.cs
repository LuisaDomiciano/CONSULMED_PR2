namespace CONSULMED_PR2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPasswordLogin = new System.Windows.Forms.Label();
            this.TxtPasswordLogin = new System.Windows.Forms.TextBox();
            this.LinkLblNotAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LinkLblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(302, 189);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(171, 20);
            this.TxtLogin.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(279, 141);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(220, 24);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Nome de login ou E-mail";
            // 
            // LblPasswordLogin
            // 
            this.LblPasswordLogin.AutoSize = true;
            this.LblPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordLogin.Location = new System.Drawing.Point(279, 243);
            this.LblPasswordLogin.Name = "LblPasswordLogin";
            this.LblPasswordLogin.Size = new System.Drawing.Size(220, 24);
            this.LblPasswordLogin.TabIndex = 3;
            this.LblPasswordLogin.Text = "Nome de login ou E-mail";
            // 
            // TxtPasswordLogin
            // 
            this.TxtPasswordLogin.Location = new System.Drawing.Point(302, 302);
            this.TxtPasswordLogin.Name = "TxtPasswordLogin";
            this.TxtPasswordLogin.Size = new System.Drawing.Size(171, 20);
            this.TxtPasswordLogin.TabIndex = 4;
            // 
            // LinkLblNotAccount
            // 
            this.LinkLblNotAccount.AutoSize = true;
            this.LinkLblNotAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblNotAccount.Location = new System.Drawing.Point(329, 346);
            this.LinkLblNotAccount.Name = "LinkLblNotAccount";
            this.LinkLblNotAccount.Size = new System.Drawing.Size(112, 16);
            this.LinkLblNotAccount.TabIndex = 5;
            this.LinkLblNotAccount.TabStop = true;
            this.LinkLblNotAccount.Text = "Não possui conta";
            this.LinkLblNotAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblNotAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LinkLblForgotPassword
            // 
            this.LinkLblForgotPassword.AutoSize = true;
            this.LinkLblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblForgotPassword.Location = new System.Drawing.Point(329, 374);
            this.LinkLblForgotPassword.Name = "LinkLblForgotPassword";
            this.LinkLblForgotPassword.Size = new System.Drawing.Size(107, 16);
            this.LinkLblForgotPassword.TabIndex = 6;
            this.LinkLblForgotPassword.TabStop = true;
            this.LinkLblForgotPassword.Text = "Esqueci a senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkLblForgotPassword);
            this.Controls.Add(this.LinkLblNotAccount);
            this.Controls.Add(this.TxtPasswordLogin);
            this.Controls.Add(this.LblPasswordLogin);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPasswordLogin;
        private System.Windows.Forms.TextBox TxtPasswordLogin;
        private System.Windows.Forms.LinkLabel LinkLblNotAccount;
        private System.Windows.Forms.LinkLabel LinkLblForgotPassword;
        private System.Windows.Forms.Label label1;
    }
}