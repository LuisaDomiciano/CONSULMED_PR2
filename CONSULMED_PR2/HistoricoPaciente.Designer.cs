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
            this.PictureBoxHistoryPac = new System.Windows.Forms.PictureBox();
            this.LblHistory = new System.Windows.Forms.Label();
            this.DataGridViewHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxHistoryPac
            // 
            this.PictureBoxHistoryPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxHistoryPac.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHistoryPac.Image")));
            this.PictureBoxHistoryPac.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxHistoryPac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBoxHistoryPac.Name = "PictureBoxHistoryPac";
            this.PictureBoxHistoryPac.Size = new System.Drawing.Size(655, 407);
            this.PictureBoxHistoryPac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHistoryPac.TabIndex = 0;
            this.PictureBoxHistoryPac.TabStop = false;
            // 
            // LblHistory
            // 
            this.LblHistory.AutoSize = true;
            this.LblHistory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistory.Location = new System.Drawing.Point(246, 31);
            this.LblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(281, 73);
            this.LblHistory.TabIndex = 1;
            this.LblHistory.Text = "Histórico";
            // 
            // DataGridViewHistory
            // 
            this.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHistory.Location = new System.Drawing.Point(341, 162);
            this.DataGridViewHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridViewHistory.Name = "DataGridViewHistory";
            this.DataGridViewHistory.RowHeadersWidth = 51;
            this.DataGridViewHistory.RowTemplate.Height = 24;
            this.DataGridViewHistory.Size = new System.Drawing.Size(180, 122);
            this.DataGridViewHistory.TabIndex = 2;
            // 
            // HistoricoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 407);
            this.Controls.Add(this.DataGridViewHistory);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.PictureBoxHistoryPac);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HistoricoPaciente";
            this.Text = "HistoricoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHistoryPac;
        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.DataGridView DataGridViewHistory;
    }
}