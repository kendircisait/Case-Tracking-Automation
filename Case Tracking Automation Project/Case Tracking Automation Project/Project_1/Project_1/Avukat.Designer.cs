namespace Project_1
{
    partial class Avukat
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
            dataGridViewAvukat = new DataGridView();
            label1 = new Label();
            comboBoxUzmanlık = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvukat).BeginInit();
            SuspendLayout();
            // 
            // sil
            // 
            sil.BackColor = Color.LightGray;
            sil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sil.Location = new Point(146, 318);
            sil.Name = "sil";
            sil.Size = new Size(104, 32);
            sil.TabIndex = 48;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = false;
            sil.Click += sil_Click;
            // 
            // guncelle
            // 
            guncelle.BackColor = Color.LightGray;
            guncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guncelle.Location = new Point(267, 318);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(104, 32);
            guncelle.TabIndex = 47;
            guncelle.Text = "Güncelle";
            guncelle.UseVisualStyleBackColor = false;
            guncelle.Click += guncelle_Click;
            // 
            // ekle
            // 
            ekle.BackColor = Color.LightGray;
            ekle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekle.Location = new Point(27, 318);
            ekle.Name = "ekle";
            ekle.Size = new Size(104, 32);
            ekle.TabIndex = 44;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(206, 189);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(174, 30);
            txtEposta.TabIndex = 43;
            // 
            // Eposta
            // 
            Eposta.AutoSize = true;
            Eposta.BackColor = Color.Transparent;
            Eposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Eposta.Location = new Point(36, 189);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(72, 23);
            Eposta.TabIndex = 42;
            Eposta.Text = "E-posta:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(206, 81);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(174, 27);
            txtSoyad.TabIndex = 41;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(207, 26);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(174, 30);
            txtAd.TabIndex = 40;
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.BackColor = Color.Transparent;
            Soyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Soyad.Location = new Point(36, 81);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(61, 23);
            Soyad.TabIndex = 39;
            Soyad.Text = "Soyad:";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.BackColor = Color.Transparent;
            Ad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ad.Location = new Point(36, 26);
            Ad.Name = "Ad";
            Ad.Size = new Size(35, 23);
            Ad.TabIndex = 38;
            Ad.Text = "Ad:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(206, 142);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(174, 27);
            txtTelefon.TabIndex = 37;
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.BackColor = Color.Transparent;
            sifreLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(36, 142);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(147, 23);
            sifreLabel.TabIndex = 36;
            sifreLabel.Text = "Telefon Numarası:";
            // 
            // dataGridViewAvukat
            // 
            dataGridViewAvukat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvukat.Location = new Point(401, 26);
            dataGridViewAvukat.Name = "dataGridViewAvukat";
            dataGridViewAvukat.RowHeadersWidth = 51;
            dataGridViewAvukat.Size = new Size(521, 349);
            dataGridViewAvukat.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(37, 241);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 50;
            label1.Text = "Uzmanlık Alanı:";
            // 
            // comboBoxUzmanlık
            // 
            comboBoxUzmanlık.FormattingEnabled = true;
            comboBoxUzmanlık.Items.AddRange(new object[] { "Aile Hukuku", "Ceza Hukuku", "İş Hukuku", "Ticaret Hukuku", "Miras Hukuku", "Gayrimenkul Hukuku", "İcra ve İflas Hukuku", "Tüketici Hukuku", "Vergi Hukuku", "Uluslararası Hukuk", "Fikri Mülkiyet Hukuku", "Hukuki Danışmanlık", "Sağlık Hukuku", "Bankacılık ve Finans Hukuku", "Spor Hukuku" });
            comboBoxUzmanlık.Location = new Point(206, 241);
            comboBoxUzmanlık.Name = "comboBoxUzmanlık";
            comboBoxUzmanlık.Size = new Size(174, 28);
            comboBoxUzmanlık.TabIndex = 51;
            // 
            // Avukat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 415);
            Controls.Add(comboBoxUzmanlık);
            Controls.Add(label1);
            Controls.Add(dataGridViewAvukat);
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
            Name = "Avukat";
            Text = "Avukat";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvukat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dataGridViewAvukat;
        private Label label1;
        private ComboBox comboBoxUzmanlık;
    }
}