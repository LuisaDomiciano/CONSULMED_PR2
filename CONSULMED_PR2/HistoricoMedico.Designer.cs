namespace CONSULMED_PR2
{
    partial class HistoricoMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoMedico));
            this.PictureBoxHistoryMed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxHistoryMed
            // 
            this.PictureBoxHistoryMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxHistoryMed.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHistoryMed.Image")));
            this.PictureBoxHistoryMed.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxHistoryMed.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxHistoryMed.Name = "PictureBoxHistoryMed";
            this.PictureBoxHistoryMed.Size = new System.Drawing.Size(800, 450);
            this.PictureBoxHistoryMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHistoryMed.TabIndex = 1;
            this.PictureBoxHistoryMed.TabStop = false;
            // 
            // HistoricoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxHistoryMed);
            this.Name = "HistoricoMedico";
            this.Text = "HistoricoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHistoryMed;
    }
}