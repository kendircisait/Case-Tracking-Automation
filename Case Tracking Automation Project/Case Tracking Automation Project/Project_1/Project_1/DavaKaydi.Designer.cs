namespace Project_1
{
    partial class DavaKaydi
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
            DavaliIDTextBox = new TextBox();
            DavaciIDTextBox = new TextBox();
            passwordLabel = new Label();
            adLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxDavaTuru = new ComboBox();
            comboBoxAvukat = new ComboBox();
            dateTimePickerDurusma = new DateTimePicker();
            Ekle = new Button();
            dataGridViewDava = new DataGridView();
            dateTimePickerAcilma = new DateTimePicker();
            label5 = new Label();
            comboBoxMahkeme = new ComboBox();
            label6 = new Label();
            DavaAdiTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxSaat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDava).BeginInit();
            SuspendLayout();
            // 
            // DavaliIDTextBox
            // 
            DavaliIDTextBox.Location = new Point(191, 86);
            DavaliIDTextBox.Name = "DavaliIDTextBox";
            DavaliIDTextBox.Size = new Size(174, 27);
            DavaliIDTextBox.TabIndex = 12;
            // 
            // DavaciIDTextBox
            // 
            DavaciIDTextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DavaciIDTextBox.Location = new Point(192, 31);
            DavaciIDTextBox.Name = "DavaciIDTextBox";
            DavaciIDTextBox.Size = new Size(174, 30);
            DavaciIDTextBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordLabel.Location = new Point(50, 86);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(89, 23);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Davalı No:";
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = Color.Transparent;
            adLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adLabel.Location = new Point(50, 31);
            adLabel.Name = "adLabel";
            adLabel.Size = new Size(93, 23);
            adLabel.TabIndex = 9;
            adLabel.Text = "Davacı No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(51, 252);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 14;
            label1.Text = "Avukat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(51, 197);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 13;
            label2.Text = "Dava Türü:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(190, 495);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 30);
            textBox3.TabIndex = 20;
            textBox3.Text = "Sonuçlanmadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 495);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 18;
            label3.Text = "Dava Sonucu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(51, 348);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 17;
            label4.Text = "DuruşmaTarih:";
            // 
            // comboBoxDavaTuru
            // 
            comboBoxDavaTuru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBoxDavaTuru.FormattingEnabled = true;
            comboBoxDavaTuru.Location = new Point(193, 197);
            comboBoxDavaTuru.Name = "comboBoxDavaTuru";
            comboBoxDavaTuru.Size = new Size(174, 31);
            comboBoxDavaTuru.TabIndex = 21;
            comboBoxDavaTuru.Text = "Dava Türü Seçin";
            // 
            // comboBoxAvukat
            // 
            comboBoxAvukat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBoxAvukat.FormattingEnabled = true;
            comboBoxAvukat.Location = new Point(191, 252);
            comboBoxAvukat.Name = "comboBoxAvukat";
            comboBoxAvukat.Size = new Size(174, 31);
            comboBoxAvukat.TabIndex = 22;
            comboBoxAvukat.Text = "Avukat Seçin";
            // 
            // dateTimePickerDurusma
            // 
            dateTimePickerDurusma.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerDurusma.Location = new Point(193, 344);
            dateTimePickerDurusma.Name = "dateTimePickerDurusma";
            dateTimePickerDurusma.Size = new Size(174, 30);
            dateTimePickerDurusma.TabIndex = 23;
            // 
            // Ekle
            // 
            Ekle.BackColor = Color.LightGray;
            Ekle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ekle.Location = new Point(126, 548);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(104, 32);
            Ekle.TabIndex = 24;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = false;
            Ekle.Click += Ekle_Click;
            // 
            // dataGridViewDava
            // 
            dataGridViewDava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDava.Location = new Point(405, 12);
            dataGridViewDava.Name = "dataGridViewDava";
            dataGridViewDava.RowHeadersWidth = 51;
            dataGridViewDava.Size = new Size(722, 585);
            dataGridViewDava.TabIndex = 26;
            // 
            // dateTimePickerAcilma
            // 
            dateTimePickerAcilma.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerAcilma.Location = new Point(191, 390);
            dateTimePickerAcilma.Name = "dateTimePickerAcilma";
            dateTimePickerAcilma.Size = new Size(176, 30);
            dateTimePickerAcilma.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(51, 393);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 28;
            label5.Text = "AçılmaTarihi";
            // 
            // comboBoxMahkeme
            // 
            comboBoxMahkeme.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBoxMahkeme.FormattingEnabled = true;
            comboBoxMahkeme.Location = new Point(191, 298);
            comboBoxMahkeme.Name = "comboBoxMahkeme";
            comboBoxMahkeme.Size = new Size(174, 31);
            comboBoxMahkeme.TabIndex = 30;
            comboBoxMahkeme.Text = "Mahkeme Seçin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(51, 298);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 29;
            label6.Text = "Mahkeme:";
            // 
            // DavaAdiTextBox
            // 
            DavaAdiTextBox.Location = new Point(192, 137);
            DavaAdiTextBox.Name = "DavaAdiTextBox";
            DavaAdiTextBox.Size = new Size(174, 27);
            DavaAdiTextBox.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(51, 137);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 31;
            label7.Text = "Dava Adı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(53, 443);
            label8.Name = "label8";
            label8.Size = new Size(43, 23);
            label8.TabIndex = 33;
            label8.Text = "Saat";
            // 
            // comboBoxSaat
            // 
            comboBoxSaat.FormattingEnabled = true;
            comboBoxSaat.Location = new Point(193, 443);
            comboBoxSaat.Name = "comboBoxSaat";
            comboBoxSaat.Size = new Size(176, 28);
            comboBoxSaat.TabIndex = 34;
            // 
            // DavaKaydi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 622);
            Controls.Add(comboBoxSaat);
            Controls.Add(label8);
            Controls.Add(DavaAdiTextBox);
            Controls.Add(label7);
            Controls.Add(comboBoxMahkeme);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePickerAcilma);
            Controls.Add(dataGridViewDava);
            Controls.Add(Ekle);
            Controls.Add(dateTimePickerDurusma);
            Controls.Add(comboBoxAvukat);
            Controls.Add(comboBoxDavaTuru);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(DavaliIDTextBox);
            Controls.Add(DavaciIDTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(adLabel);
            Name = "DavaKaydi";
            Text = "DavaKaydi";
            Load += DavaKaydi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DavaliIDTextBox;
        private TextBox DavaciIDTextBox;
        private Label passwordLabel;
        private Label adLabel;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDavaTuru;
        private ComboBox comboBoxAvukat;
        private DateTimePicker dateTimePickerDurusma;
        private Button Ekle;
        private DataGridView dataGridViewDava;
        private DateTimePicker dateTimePickerAcilma;
        private Label label5;
        private ComboBox comboBoxMahkeme;
        private Label label6;
        private TextBox DavaAdiTextBox;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxSaat;
    }
}