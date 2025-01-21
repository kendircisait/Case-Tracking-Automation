namespace Project_1
{
    partial class Odeme
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
            avukatIDTextBox = new TextBox();
            davaIDTextBox = new TextBox();
            Soyad = new Label();
            Ad = new Label();
            groupBox3 = new GroupBox();
            OdemeYap = new Button();
            labelYil = new Label();
            kartSonKullanmaYilTextBox = new TextBox();
            radioNakitOdeme = new RadioButton();
            labelAy = new Label();
            radioKrediKarti = new RadioButton();
            kartSonKullanmaAyTextBox = new TextBox();
            label12 = new Label();
            label7 = new Label();
            kartNoTextBox = new TextBox();
            cvvTextBox = new TextBox();
            labelKartNumarasi = new Label();
            labelCVV = new Label();
            groupBox1 = new GroupBox();
            dateTimePickerTarih = new DateTimePicker();
            label2 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // avukatIDTextBox
            // 
            avukatIDTextBox.Location = new Point(170, 132);
            avukatIDTextBox.Name = "avukatIDTextBox";
            avukatIDTextBox.Size = new Size(174, 27);
            avukatIDTextBox.TabIndex = 41;
            // 
            // davaIDTextBox
            // 
            davaIDTextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            davaIDTextBox.Location = new Point(172, 55);
            davaIDTextBox.Name = "davaIDTextBox";
            davaIDTextBox.Size = new Size(174, 30);
            davaIDTextBox.TabIndex = 40;
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.BackColor = Color.Transparent;
            Soyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Soyad.Location = new Point(35, 136);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(96, 23);
            Soyad.TabIndex = 39;
            Soyad.Text = "Avukat No:";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.BackColor = Color.Transparent;
            Ad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ad.Location = new Point(36, 59);
            Ad.Name = "Ad";
            Ad.Size = new Size(81, 23);
            Ad.TabIndex = 38;
            Ad.Text = "Dava No:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(OdemeYap);
            groupBox3.Controls.Add(labelYil);
            groupBox3.Controls.Add(kartSonKullanmaYilTextBox);
            groupBox3.Controls.Add(radioNakitOdeme);
            groupBox3.Controls.Add(labelAy);
            groupBox3.Controls.Add(radioKrediKarti);
            groupBox3.Controls.Add(kartSonKullanmaAyTextBox);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(kartNoTextBox);
            groupBox3.Controls.Add(cvvTextBox);
            groupBox3.Controls.Add(labelKartNumarasi);
            groupBox3.Controls.Add(labelCVV);
            groupBox3.Location = new Point(417, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(489, 329);
            groupBox3.TabIndex = 49;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Bilgileri";
            // 
            // OdemeYap
            // 
            OdemeYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            OdemeYap.Location = new Point(35, 251);
            OdemeYap.Name = "OdemeYap";
            OdemeYap.Size = new Size(94, 29);
            OdemeYap.TabIndex = 13;
            OdemeYap.Text = "Ödeme Yap";
            OdemeYap.UseVisualStyleBackColor = true;
            OdemeYap.Click += OdemeYap_Click;
            // 
            // labelYil
            // 
            labelYil.AutoSize = true;
            labelYil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelYil.Location = new Point(343, 213);
            labelYil.Name = "labelYil";
            labelYil.Size = new Size(28, 23);
            labelYil.TabIndex = 12;
            labelYil.Text = "Yıl";
            // 
            // kartSonKullanmaYilTextBox
            // 
            kartSonKullanmaYilTextBox.Location = new Point(343, 239);
            kartSonKullanmaYilTextBox.Name = "kartSonKullanmaYilTextBox";
            kartSonKullanmaYilTextBox.Size = new Size(65, 27);
            kartSonKullanmaYilTextBox.TabIndex = 11;
            // 
            // radioNakitOdeme
            // 
            radioNakitOdeme.AutoSize = true;
            radioNakitOdeme.Location = new Point(23, 114);
            radioNakitOdeme.Name = "radioNakitOdeme";
            radioNakitOdeme.Size = new Size(65, 24);
            radioNakitOdeme.TabIndex = 3;
            radioNakitOdeme.TabStop = true;
            radioNakitOdeme.Text = "Nakit";
            radioNakitOdeme.UseVisualStyleBackColor = true;
            radioNakitOdeme.CheckedChanged += radioNakit_CheckedChanged;
            // 
            // labelAy
            // 
            labelAy.AutoSize = true;
            labelAy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelAy.Location = new Point(257, 213);
            labelAy.Name = "labelAy";
            labelAy.Size = new Size(30, 23);
            labelAy.TabIndex = 10;
            labelAy.Text = "Ay";
            // 
            // radioKrediKarti
            // 
            radioKrediKarti.AutoSize = true;
            radioKrediKarti.Location = new Point(23, 80);
            radioKrediKarti.Name = "radioKrediKarti";
            radioKrediKarti.Size = new Size(178, 24);
            radioKrediKarti.TabIndex = 2;
            radioKrediKarti.TabStop = true;
            radioKrediKarti.Text = "Banka veya Kredi Kartı";
            radioKrediKarti.UseVisualStyleBackColor = true;
            radioKrediKarti.CheckedChanged += radioKrediKarti_CheckedChanged;
            // 
            // kartSonKullanmaAyTextBox
            // 
            kartSonKullanmaAyTextBox.Location = new Point(257, 239);
            kartSonKullanmaAyTextBox.Name = "kartSonKullanmaAyTextBox";
            kartSonKullanmaAyTextBox.Size = new Size(65, 27);
            kartSonKullanmaAyTextBox.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 39);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 0;
            label12.Text = "Ödeme Seçenekleri:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(254, 183);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 8;
            label7.Text = "Son Kullanma Tarihi";
            // 
            // kartNoTextBox
            // 
            kartNoTextBox.Location = new Point(254, 73);
            kartNoTextBox.Name = "kartNoTextBox";
            kartNoTextBox.Size = new Size(171, 27);
            kartNoTextBox.TabIndex = 5;
            // 
            // cvvTextBox
            // 
            cvvTextBox.Location = new Point(254, 142);
            cvvTextBox.Name = "cvvTextBox";
            cvvTextBox.Size = new Size(125, 27);
            cvvTextBox.TabIndex = 7;
            // 
            // labelKartNumarasi
            // 
            labelKartNumarasi.AutoSize = true;
            labelKartNumarasi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelKartNumarasi.Location = new Point(254, 39);
            labelKartNumarasi.Name = "labelKartNumarasi";
            labelKartNumarasi.Size = new Size(123, 23);
            labelKartNumarasi.TabIndex = 4;
            labelKartNumarasi.Text = "Kart Numarası:";
            // 
            // labelCVV
            // 
            labelCVV.AutoSize = true;
            labelCVV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelCVV.Location = new Point(254, 116);
            labelCVV.Name = "labelCVV";
            labelCVV.Size = new Size(43, 23);
            labelCVV.TabIndex = 6;
            labelCVV.Text = "CVV";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(dateTimePickerTarih);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(avukatIDTextBox);
            groupBox1.Controls.Add(davaIDTextBox);
            groupBox1.Controls.Add(Soyad);
            groupBox1.Controls.Add(Ad);
            groupBox1.Location = new Point(25, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 329);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borç Bilgisi:";
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Location = new Point(170, 213);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(175, 27);
            dateTimePickerTarih.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(38, 213);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 52;
            label2.Text = "Tarih:";
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 374);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Odeme";
            Text = "Odeme";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox avukatIDTextBox;
        private TextBox davaIDTextBox;
        private Label Soyad;
        private Label Ad;
        private GroupBox groupBox3;
        private Button OdemeYap;
        private Label labelYil;
        private TextBox kartSonKullanmaYilTextBox;
        private RadioButton radioNakitOdeme;
        private Label labelAy;
        private RadioButton radioKrediKarti;
        private TextBox kartSonKullanmaAyTextBox;
        private Label label12;
        private Label label7;
        private TextBox kartNoTextBox;
        private TextBox cvvTextBox;
        private Label labelKartNumarasi;
        private Label labelCVV;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dateTimePickerTarih;
    }
}