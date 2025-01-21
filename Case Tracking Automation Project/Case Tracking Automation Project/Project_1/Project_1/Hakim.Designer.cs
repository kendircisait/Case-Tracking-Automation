namespace Project_1
{
    partial class Hakim
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
            dataGridViewHakim = new DataGridView();
            sil = new Button();
            guncelle = new Button();
            ekle = new Button();
            txtEposta = new TextBox();
            Eposta = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            Soyad = new Label();
            Ad = new Label();
            txtTelefon = new TextBox();
            sifreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHakim).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHakim
            // 
            dataGridViewHakim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHakim.Location = new Point(389, 51);
            dataGridViewHakim.Name = "dataGridViewHakim";
            dataGridViewHakim.RowHeadersWidth = 51;
            dataGridViewHakim.Size = new Size(544, 269);
            dataGridViewHakim.TabIndex = 63;
            // 
            // sil
            // 
            sil.BackColor = Color.LightGray;
            sil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sil.Location = new Point(129, 288);
            sil.Name = "sil";
            sil.Size = new Size(104, 32);
            sil.TabIndex = 62;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = false;
            // 
            // guncelle
            // 
            guncelle.BackColor = Color.LightGray;
            guncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guncelle.Location = new Point(250, 288);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(104, 32);
            guncelle.TabIndex = 61;
            guncelle.Text = "Güncelle";
            guncelle.UseVisualStyleBackColor = false;
            // 
            // ekle
            // 
            ekle.BackColor = Color.LightGray;
            ekle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekle.Location = new Point(10, 288);
            ekle.Name = "ekle";
            ekle.Size = new Size(104, 32);
            ekle.TabIndex = 60;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(194, 214);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(174, 30);
            txtEposta.TabIndex = 59;
            // 
            // Eposta
            // 
            Eposta.AutoSize = true;
            Eposta.BackColor = Color.Transparent;
            Eposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Eposta.Location = new Point(24, 214);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(72, 23);
            Eposta.TabIndex = 58;
            Eposta.Text = "E-posta:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(194, 106);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(174, 27);
            txtSoyad.TabIndex = 57;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(195, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(174, 30);
            txtAd.TabIndex = 56;
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.BackColor = Color.Transparent;
            Soyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Soyad.Location = new Point(24, 106);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(61, 23);
            Soyad.TabIndex = 55;
            Soyad.Text = "Soyad:";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.BackColor = Color.Transparent;
            Ad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ad.Location = new Point(25, 51);
            Ad.Name = "Ad";
            Ad.Size = new Size(35, 23);
            Ad.TabIndex = 54;
            Ad.Text = "Ad:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(194, 167);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(174, 27);
            txtTelefon.TabIndex = 53;
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.BackColor = Color.Transparent;
            sifreLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(24, 167);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(147, 23);
            sifreLabel.TabIndex = 52;
            sifreLabel.Text = "Telefon Numarası:";
            // 
            // Hakim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 361);
            Controls.Add(dataGridViewHakim);
            Controls.Add(sil);
            Controls.Add(guncelle);
            Controls.Add(ekle);
            Controls.Add(txtEposta);
            Controls.Add(Eposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(Soyad);
            Controls.Add(Ad);
            Controls.Add(txtTelefon);
            Controls.Add(sifreLabel);
            Name = "Hakim";
            Text = "Hakim";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHakim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHakim;
        private Button sil;
        private Button guncelle;
        private Button ekle;
        private TextBox txtEposta;
        private Label Eposta;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label Soyad;
        private Label Ad;
        private TextBox txtTelefon;
        private Label sifreLabel;
    }
}