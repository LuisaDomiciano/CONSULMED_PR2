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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasMedico));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancelarConsultaMed = new System.Windows.Forms.Button();
            this.BtnRemarcarConsulatMed = new System.Windows.Forms.Button();
            this.BtnRealizadaConsultaMed = new System.Windows.Forms.Button();
            this.BtnVoltarMed = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(180, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnCancelarConsultaMed
            // 
            this.BtnCancelarConsultaMed.Location = new System.Drawing.Point(302, 99);
            this.BtnCancelarConsultaMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelarConsultaMed.Name = "BtnCancelarConsultaMed";
            this.BtnCancelarConsultaMed.Size = new System.Drawing.Size(182, 58);
            this.BtnCancelarConsultaMed.TabIndex = 5;
            this.BtnCancelarConsultaMed.Text = "Cancelar Consulta";
            this.BtnCancelarConsultaMed.UseVisualStyleBackColor = true;
            // 
            // BtnRemarcarConsulatMed
            // 
            this.BtnRemarcarConsulatMed.Location = new System.Drawing.Point(302, 185);
            this.BtnRemarcarConsulatMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRemarcarConsulatMed.Name = "BtnRemarcarConsulatMed";
            this.BtnRemarcarConsulatMed.Size = new System.Drawing.Size(182, 58);
            this.BtnRemarcarConsulatMed.TabIndex = 6;
            this.BtnRemarcarConsulatMed.Text = "Remarcar Consulta";
            this.BtnRemarcarConsulatMed.UseVisualStyleBackColor = true;
            // 
            // BtnRealizadaConsultaMed
            // 
            this.BtnRealizadaConsultaMed.Location = new System.Drawing.Point(302, 265);
            this.BtnRealizadaConsultaMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRealizadaConsultaMed.Name = "BtnRealizadaConsultaMed";
            this.BtnRealizadaConsultaMed.Size = new System.Drawing.Size(182, 58);
            this.BtnRealizadaConsultaMed.TabIndex = 7;
            this.BtnRealizadaConsultaMed.Text = "Consulta Realizada";
            this.BtnRealizadaConsultaMed.UseVisualStyleBackColor = true;
            // 
            // BtnVoltarMed
            // 
            this.BtnVoltarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarMed.Location = new System.Drawing.Point(12, 319);
            this.BtnVoltarMed.Name = "BtnVoltarMed";
            this.BtnVoltarMed.Size = new System.Drawing.Size(71, 35);
            this.BtnVoltarMed.TabIndex = 12;
            this.BtnVoltarMed.Text = "Voltar";
            this.BtnVoltarMed.UseVisualStyleBackColor = true;
            this.BtnVoltarMed.Click += new System.EventHandler(this.BtnVoltarMed_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultasMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnVoltarMed);
            this.Controls.Add(this.BtnRealizadaConsultaMed);
            this.Controls.Add(this.BtnRemarcarConsulatMed);
            this.Controls.Add(this.BtnCancelarConsultaMed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultasMedico";
            this.Text = "ConsultasMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancelarConsultaMed;
        private System.Windows.Forms.Button BtnRemarcarConsulatMed;
        private System.Windows.Forms.Button BtnRealizadaConsultaMed;
        private System.Windows.Forms.Button BtnVoltarMed;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}