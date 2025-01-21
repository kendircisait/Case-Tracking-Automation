namespace Project_1
{
    partial class DavaDurum
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
            guncelle = new Button();
            dataGridViewDavaDurumu = new DataGridView();
            txtDavaID = new TextBox();
            DavaNo = new Label();
            txtDurum = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaDurumu).BeginInit();
            SuspendLayout();
            // 
            // guncelle
            // 
            guncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guncelle.Location = new Point(450, 45);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(103, 29);
            guncelle.TabIndex = 19;
            guncelle.Text = "Güncelle";
            guncelle.UseVisualStyleBackColor = true;
            guncelle.Click += guncelle_Click;
            // 
            // dataGridViewDavaDurumu
            // 
            dataGridViewDavaDurumu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDavaDurumu.Location = new Point(32, 131);
            dataGridViewDavaDurumu.Name = "dataGridViewDavaDurumu";
            dataGridViewDavaDurumu.RowHeadersWidth = 51;
            dataGridViewDavaDurumu.Size = new Size(670, 249);
            dataGridViewDavaDurumu.TabIndex = 18;
            // 
            // txtDavaID
            // 
            txtDavaID.BackColor = Color.White;
            txtDavaID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtDavaID.Location = new Point(162, 20);
            txtDavaID.Name = "txtDavaID";
            txtDavaID.Size = new Size(174, 30);
            txtDavaID.TabIndex = 17;
            // 
            // DavaNo
            // 
            DavaNo.AutoSize = true;
            DavaNo.BackColor = Color.Transparent;
            DavaNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DavaNo.Location = new Point(32, 23);
            DavaNo.Name = "DavaNo";
            DavaNo.Size = new Size(81, 23);
            DavaNo.TabIndex = 16;
            DavaNo.Text = "Dava No:";
            // 
            // txtDurum
            // 
            txtDurum.BackColor = Color.White;
            txtDurum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtDurum.Location = new Point(162, 71);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(174, 30);
            txtDurum.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(32, 74);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 20;
            label1.Text = "Dava Durum:";
            // 
            // DavaDurum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 392);
            Controls.Add(txtDurum);
            Controls.Add(label1);
            Controls.Add(guncelle);
            Controls.Add(dataGridViewDavaDurumu);
            Controls.Add(txtDavaID);
            Controls.Add(DavaNo);
            Name = "DavaDurum";
            Text = "DavaDurum";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaDurumu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guncelle;
        private DataGridView dataGridViewDavaDurumu;
        private TextBox txtDavaID;
        private Label DavaNo;
        private TextBox txtDurum;
        private Label label1;
    }
}