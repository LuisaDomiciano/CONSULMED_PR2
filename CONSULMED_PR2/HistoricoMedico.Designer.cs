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
            this.BtnGerarAtestado = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnEnviarHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxHistoryMed
            // 
            this.PictureBoxHistoryMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxHistoryMed.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHistoryMed.Image")));
            this.PictureBoxHistoryMed.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxHistoryMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxHistoryMed.Name = "PictureBoxHistoryMed";
            this.PictureBoxHistoryMed.Size = new System.Drawing.Size(1067, 554);
            this.PictureBoxHistoryMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHistoryMed.TabIndex = 1;
            this.PictureBoxHistoryMed.TabStop = false;
            // 
            // dataGridViewHistoricoMedico
            // 
            this.dataGridViewHistoricoMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricoMedico.Location = new System.Drawing.Point(431, 205);
            this.dataGridViewHistoricoMedico.Name = "dataGridViewHistoricoMedico";
            this.dataGridViewHistoricoMedico.RowHeadersWidth = 51;
            this.dataGridViewHistoricoMedico.RowTemplate.Height = 24;
            this.dataGridViewHistoricoMedico.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewHistoricoMedico.TabIndex = 2;
            // 
            // BtnGerarAtestado
            // 
            this.BtnGerarAtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarAtestado.Location = new System.Drawing.Point(827, 368);
            this.BtnGerarAtestado.Name = "BtnGerarAtestado";
            this.BtnGerarAtestado.Size = new System.Drawing.Size(162, 49);
            this.BtnGerarAtestado.TabIndex = 3;
            this.BtnGerarAtestado.Text = "Gerar Atestado";
            this.BtnGerarAtestado.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnEnviarHistorico
            // 
            this.BtnEnviarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarHistorico.Location = new System.Drawing.Point(827, 274);
            this.BtnEnviarHistorico.Name = "BtnEnviarHistorico";
            this.BtnEnviarHistorico.Size = new System.Drawing.Size(162, 68);
            this.BtnEnviarHistorico.TabIndex = 4;
            this.BtnEnviarHistorico.Text = "Enviar ao Paciente";
            this.BtnEnviarHistorico.UseVisualStyleBackColor = true;
            // 
            // HistoricoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnEnviarHistorico);
            this.Controls.Add(this.BtnGerarAtestado);
            this.Controls.Add(this.dataGridViewHistoricoMedico);
            this.Controls.Add(this.PictureBoxHistoryMed);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoricoMedico";
            this.Text = "HistoricoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHistoryMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHistoryMed;
        private System.Windows.Forms.DataGridView dataGridViewHistoricoMedico;
        private System.Windows.Forms.Button BtnGerarAtestado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnEnviarHistorico;
    }
}