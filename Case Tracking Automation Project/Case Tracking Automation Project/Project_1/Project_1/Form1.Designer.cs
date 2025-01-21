namespace Project_1
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GirisYap = new Button();
            sifreTestBox = new TextBox();
            KullaniciaditextBox = new TextBox();
            passwordLabel = new Label();
            adLabel = new Label();
            KayitOl = new Button();
            panel2 = new Panel();
            label1 = new Label();
            Geri = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // GirisYap
            // 
            GirisYap.BackColor = Color.LightGray;
            GirisYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            GirisYap.Location = new Point(253, 186);
            GirisYap.Name = "GirisYap";
            GirisYap.Size = new Size(104, 32);
            GirisYap.TabIndex = 9;
            GirisYap.Text = "Giriş Yap";
            GirisYap.UseVisualStyleBackColor = false;
            GirisYap.Click += GirisYap_Click;
            // 
            // sifreTestBox
            // 
            sifreTestBox.Location = new Point(252, 135);
            sifreTestBox.Name = "sifreTestBox";
            sifreTestBox.PasswordChar = '●';
            sifreTestBox.Size = new Size(174, 27);
            sifreTestBox.TabIndex = 8;
            // 
            // KullaniciaditextBox
            // 
            KullaniciaditextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KullaniciaditextBox.Location = new Point(253, 80);
            KullaniciaditextBox.Name = "KullaniciaditextBox";
            KullaniciaditextBox.Size = new Size(174, 30);
            KullaniciaditextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordLabel.Location = new Point(47, 135);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(48, 23);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Şifre:";
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = Color.Transparent;
            adLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adLabel.Location = new Point(47, 80);
            adLabel.Name = "adLabel";
            adLabel.Size = new Size(107, 23);
            adLabel.TabIndex = 5;
            adLabel.Text = "Kullanıcı Adı:";
            // 
            // KayitOl
            // 
            KayitOl.BackColor = Color.LightGray;
            KayitOl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KayitOl.Location = new Point(253, 224);
            KayitOl.Name = "KayitOl";
            KayitOl.Size = new Size(104, 32);
            KayitOl.TabIndex = 10;
            KayitOl.Text = "Kayıt Ol";
            KayitOl.UseVisualStyleBackColor = false;
            KayitOl.Click += KayitOl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Geri);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 41);
            panel2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 18;
            label1.Text = "Dava Kayıt Uygulaması";
            // 
            // Geri
            // 
            Geri.Location = new Point(972, 7);
            Geri.Name = "Geri";
            Geri.Size = new Size(94, 29);
            Geri.TabIndex = 17;
            Geri.Text = "Geri";
            Geri.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 285);
            Controls.Add(panel2);
            Controls.Add(KayitOl);
            Controls.Add(GirisYap);
            Controls.Add(sifreTestBox);
            Controls.Add(KullaniciaditextBox);
            Controls.Add(passwordLabel);
            Controls.Add(adLabel);
            Name = "Giris";
            Text = "Giriş";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GirisYap;
        private TextBox sifreTestBox;
        private TextBox KullaniciaditextBox;
        private Label passwordLabel;
        private Label adLabel;
        private Button KayitOl;
        private Panel panel2;
        private Label label1;
        private Button Geri;
    }
}
