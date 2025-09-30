namespace CONSULMED_PR2
{
    partial class HistoricoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoPaciente));
            this.PictureBoxHistoryMed = new System.Windows.Forms.PictureBox();
            this.LblHistory = new System.Windows.Forms.Label();
            this.DataGridViewHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxHistoryMed
            // 
            this.PictureBoxHistoryMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxHistoryMed.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHistoryMed.Image")));
            this.PictureBoxHistoryMed.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxHistoryMed.Name = "PictureBoxHistoryMed";
            this.PictureBoxHistoryMed.Size = new System.Drawing.Size(873, 501);
            this.PictureBoxHistoryMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHistoryMed.TabIndex = 0;
            this.PictureBoxHistoryMed.TabStop = false;
            // 
            // LblHistory
            // 
            this.LblHistory.AutoSize = true;
            this.LblHistory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistory.Location = new System.Drawing.Point(328, 38);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(348, 91);
            this.LblHistory.TabIndex = 1;
            this.LblHistory.Text = "Histórico";
            // 
            // DataGridViewHistory
            // 
            this.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHistory.Location = new System.Drawing.Point(455, 199);
            this.DataGridViewHistory.Name = "DataGridViewHistory";
            this.DataGridViewHistory.RowHeadersWidth = 51;
            this.DataGridViewHistory.RowTemplate.Height = 24;
            this.DataGridViewHistory.Size = new System.Drawing.Size(240, 150);
            this.DataGridViewHistory.TabIndex = 2;
            // 
            // HistoricoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 501);
            this.Controls.Add(this.DataGridViewHistory);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.PictureBoxHistoryMed);
            this.Name = "HistoricoPaciente";
            this.Text = "HistoricoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHistoryMed;
        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.DataGridView DataGridViewHistory;
    }
}