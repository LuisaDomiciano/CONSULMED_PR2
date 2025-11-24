namespace CONSULMED_PR2
{
    partial class ConsultasMedico
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancelarConsultaMed = new System.Windows.Forms.Button();
            this.BtnRemarcarConsulatMed = new System.Windows.Forms.Button();
            this.BtnRealizadaConsultaMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnCancelarConsultaMed
            // 
            this.BtnCancelarConsultaMed.Location = new System.Drawing.Point(402, 122);
            this.BtnCancelarConsultaMed.Name = "BtnCancelarConsultaMed";
            this.BtnCancelarConsultaMed.Size = new System.Drawing.Size(242, 71);
            this.BtnCancelarConsultaMed.TabIndex = 5;
            this.BtnCancelarConsultaMed.Text = "Cancelar Consulta";
            this.BtnCancelarConsultaMed.UseVisualStyleBackColor = true;
            // 
            // BtnRemarcarConsulatMed
            // 
            this.BtnRemarcarConsulatMed.Location = new System.Drawing.Point(402, 228);
            this.BtnRemarcarConsulatMed.Name = "BtnRemarcarConsulatMed";
            this.BtnRemarcarConsulatMed.Size = new System.Drawing.Size(242, 71);
            this.BtnRemarcarConsulatMed.TabIndex = 6;
            this.BtnRemarcarConsulatMed.Text = "Remarcar Consulta";
            this.BtnRemarcarConsulatMed.UseVisualStyleBackColor = true;
            // 
            // BtnRealizadaConsultaMed
            // 
            this.BtnRealizadaConsultaMed.Location = new System.Drawing.Point(402, 326);
            this.BtnRealizadaConsultaMed.Name = "BtnRealizadaConsultaMed";
            this.BtnRealizadaConsultaMed.Size = new System.Drawing.Size(242, 71);
            this.BtnRealizadaConsultaMed.TabIndex = 7;
            this.BtnRealizadaConsultaMed.Text = "Consulta Realizada";
            this.BtnRealizadaConsultaMed.UseVisualStyleBackColor = true;
            // 
            // ConsultasMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRealizadaConsultaMed);
            this.Controls.Add(this.BtnRemarcarConsulatMed);
            this.Controls.Add(this.BtnCancelarConsultaMed);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultasMedico";
            this.Text = "ConsultasMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancelarConsultaMed;
        private System.Windows.Forms.Button BtnRemarcarConsulatMed;
        private System.Windows.Forms.Button BtnRealizadaConsultaMed;
    }
}