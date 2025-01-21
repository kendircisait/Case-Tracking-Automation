namespace Project_1
{
    partial class KayitOl
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
            sifreTextBox = new TextBox();
            KullaniciaditextBox = new TextBox();
            sifreLabel = new Label();
            kullaniciadLabel = new Label();
            soyadtextBox = new TextBox();
            adtextBox = new TextBox();
            Soyad = new Label();
            Ad = new Label();
            mailtextBox = new TextBox();
            Eposta = new Label();
            kayit = new Button();
            SuspendLayout();
            // 
            // sifreTextBox
            // 
            sifreTextBox.Location = new Point(282, 109);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PasswordChar = '●';
            sifreTextBox.Size = new Size(174, 27);
            sifreTextBox.TabIndex = 12;
            // 
            // KullaniciaditextBox
            // 
            KullaniciaditextBox.BackColor = Color.White;
            KullaniciaditextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KullaniciaditextBox.Location = new Point(283, 54);
            KullaniciaditextBox.Name = "KullaniciaditextBox";
            KullaniciaditextBox.Size = new Size(174, 30);
            KullaniciaditextBox.TabIndex = 11;
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.BackColor = Color.Transparent;
            sifreLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(77, 109);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(48, 23);
            sifreLabel.TabIndex = 10;
            sifreLabel.Text = "Şifre:";
            // 
            // kullaniciadLabel
            // 
            kullaniciadLabel.AutoSize = true;
            kullaniciadLabel.BackColor = Color.Transparent;
            kullaniciadLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciadLabel.Location = new Point(77, 54);
            kullaniciadLabel.Name = "kullaniciadLabel";
            kullaniciadLabel.Size = new Size(107, 23);
            kullaniciadLabel.TabIndex = 9;
            kullaniciadLabel.Text = "Kullanıcı Adı:";
            // 
            // soyadtextBox
            // 
            soyadtextBox.Location = new Point(282, 221);
            soyadtextBox.Name = "soyadtextBox";
            soyadtextBox.Size = new Size(174, 27);
            soyadtextBox.TabIndex = 16;
            // 
            // adtextBox
            // 
            adtextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adtextBox.Location = new Point(283, 166);
            adtextBox.Name = "adtextBox";
            adtextBox.Size = new Size(174, 30);
            adtextBox.TabIndex = 15;
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.BackColor = Color.Transparent;
            Soyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Soyad.Location = new Point(77, 221);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(57, 23);
            Soyad.TabIndex = 14;
            Soyad.Text = "Soyad";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.BackColor = Color.Transparent;
            Ad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ad.Location = new Point(77, 166);
            Ad.Name = "Ad";
            Ad.Size = new Size(35, 23);
            Ad.TabIndex = 13;
            Ad.Text = "Ad:";
            // 
            // mailtextBox
            // 
            mailtextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mailtextBox.Location = new Point(282, 274);
            mailtextBox.Name = "mailtextBox";
            mailtextBox.Size = new Size(174, 30);
            mailtextBox.TabIndex = 19;
            // 
            // Eposta
            // 
            Eposta.AutoSize = true;
            Eposta.BackColor = Color.Transparent;
            Eposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Eposta.Location = new Point(76, 274);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(68, 23);
            Eposta.TabIndex = 17;
            Eposta.Text = "E-posta";
            // 
            // kayit
            // 
            kayit.BackColor = Color.LightGray;
            kayit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayit.Location = new Point(201, 346);
            kayit.Name = "kayit";
            kayit.Size = new Size(104, 32);
            kayit.TabIndex = 20;
            kayit.Text = "Kayıt Ol";
            kayit.UseVisualStyleBackColor = false;
            kayit.Click += kayit_Click;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 437);
            Controls.Add(kayit);
            Controls.Add(mailtextBox);
            Controls.Add(Eposta);
            Controls.Add(soyadtextBox);
            Controls.Add(adtextBox);
            Controls.Add(Soyad);
            Controls.Add(Ad);
            Controls.Add(sifreTextBox);
            Controls.Add(KullaniciaditextBox);
            Controls.Add(sifreLabel);
            Controls.Add(kullaniciadLabel);
            Name = "KayitOl";
            Text = "KayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sifreTextBox;
        private TextBox KullaniciaditextBox;
        private Label sifreLabel;
        private Label kullaniciadLabel;
        private TextBox soyadtextBox;
        private TextBox adtextBox;
        private Label Soyad;
        private Label Ad;
        private TextBox mailtextBox;
        private Label Eposta;
        private Button kayit;
    }
}