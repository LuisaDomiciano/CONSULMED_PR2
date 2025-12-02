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
            this.dataGridViewHistoricoMedico = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblHistory = new System.Windows.Forms.Label();
            this.BtnVoltarMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoMedico)).BeginInit();
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
            // dataGridViewHistoricoMedico
            // 
            this.dataGridViewHistoricoMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricoMedico.Location = new System.Drawing.Point(274, 173);
            this.dataGridViewHistoricoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHistoricoMedico.Name = "dataGridViewHistoricoMedico";
            this.dataGridViewHistoricoMedico.RowHeadersWidth = 51;
            this.dataGridViewHistoricoMedico.RowTemplate.Height = 24;
            this.dataGridViewHistoricoMedico.Size = new System.Drawing.Size(319, 202);
            this.dataGridViewHistoricoMedico.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblHistory
            // 
            this.LblHistory.AutoSize = true;
            this.LblHistory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistory.Location = new System.Drawing.Point(289, 57);
            this.LblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(281, 73);
            this.LblHistory.TabIndex = 5;
            this.LblHistory.Text = "Histórico";
            // 
            // BtnVoltarMed
            // 
            this.BtnVoltarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarMed.Location = new System.Drawing.Point(12, 403);
            this.BtnVoltarMed.Name = "BtnVoltarMed";
            this.BtnVoltarMed.Size = new System.Drawing.Size(71, 35);
            this.BtnVoltarMed.TabIndex = 11;
            this.BtnVoltarMed.Text = "Voltar";
            this.BtnVoltarMed.UseVisualStyleBackColor = true;
            this.BtnVoltarMed.Click += new System.EventHandler(this.BtnVoltarMed_Click);
            // 
            // HistoricoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltarMed);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.dataGridViewHistoricoMedico);
            this.Controls.Add(this.PictureBoxHistoryMed);
            this.Name = "HistoricoMedico";
            this.Text = "HistoricoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHistoryMed;
        private System.Windows.Forms.DataGridView dataGridViewHistoricoMedico;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.Button BtnVoltarMed;
    }
}