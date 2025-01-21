namespace Project_1
{
    partial class Durusma
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
            ekle = new Button();
            Eposta = new Label();
            txtDavaNo = new TextBox();
            Ad = new Label();
            dataGridViewDavaDurumu = new DataGridView();
            comboBoxMahkeme = new ComboBox();
            label6 = new Label();
            comboBoxHakim = new ComboBox();
            dateTimePickerDurusmaTarihi = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaDurumu).BeginInit();
            SuspendLayout();
            // 
            // sil
            // 
            sil.BackColor = Color.LightGray;
            sil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sil.Location = new Point(182, 287);
            sil.Name = "sil";
            sil.Size = new Size(104, 32);
            sil.TabIndex = 72;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = false;
            sil.Click += sil_Click;
            // 
            // ekle
            // 
            ekle.BackColor = Color.LightGray;
            ekle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekle.Location = new Point(50, 287);
            ekle.Name = "ekle";
            ekle.Size = new Size(104, 32);
            ekle.TabIndex = 71;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // Eposta
            // 
            Eposta.AutoSize = true;
            Eposta.BackColor = Color.Transparent;
            Eposta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Eposta.Location = new Point(49, 161);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(64, 23);
            Eposta.TabIndex = 69;
            Eposta.Text = "Hakim:";
            // 
            // txtDavaNo
            // 
            txtDavaNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtDavaNo.Location = new Point(219, 50);
            txtDavaNo.Name = "txtDavaNo";
            txtDavaNo.Size = new Size(174, 30);
            txtDavaNo.TabIndex = 67;
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.BackColor = Color.Transparent;
            Ad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ad.Location = new Point(49, 50);
            Ad.Name = "Ad";
            Ad.Size = new Size(81, 23);
            Ad.TabIndex = 65;
            Ad.Text = "Dava No:";
            // 
            // dataGridViewDavaDurumu
            // 
            dataGridViewDavaDurumu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDavaDurumu.Location = new Point(431, 50);
            dataGridViewDavaDurumu.Name = "dataGridViewDavaDurumu";
            dataGridViewDavaDurumu.RowHeadersWidth = 51;
            dataGridViewDavaDurumu.Size = new Size(589, 297);
            dataGridViewDavaDurumu.TabIndex = 73;
            // 
            // comboBoxMahkeme
            // 
            comboBoxMahkeme.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBoxMahkeme.FormattingEnabled = true;
            comboBoxMahkeme.Location = new Point(219, 109);
            comboBoxMahkeme.Name = "comboBoxMahkeme";
            comboBoxMahkeme.Size = new Size(174, 31);
            comboBoxMahkeme.TabIndex = 75;
            comboBoxMahkeme.Text = "Mahkeme Seçin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(50, 109);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 74;
            label6.Text = "Mahkeme:";
            // 
            // comboBoxHakim
            // 
            comboBoxHakim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBoxHakim.FormattingEnabled = true;
            comboBoxHakim.Location = new Point(219, 161);
            comboBoxHakim.Name = "comboBoxHakim";
            comboBoxHakim.Size = new Size(174, 31);
            comboBoxHakim.TabIndex = 76;
            comboBoxHakim.Text = "Hakim Seçin";
            // 
            // dateTimePickerDurusmaTarihi
            // 
            dateTimePickerDurusmaTarihi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerDurusmaTarihi.Location = new Point(220, 210);
            dateTimePickerDurusmaTarihi.Name = "dateTimePickerDurusmaTarihi";
            dateTimePickerDurusmaTarihi.Size = new Size(174, 30);
            dateTimePickerDurusmaTarihi.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(51, 216);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 77;
            label4.Text = "DuruşmaTarihi:";
            // 
            // Durusma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 381);
            Controls.Add(dateTimePickerDurusmaTarihi);
            Controls.Add(label4);
            Controls.Add(comboBoxHakim);
            Controls.Add(comboBoxMahkeme);
            Controls.Add(label6);
            Controls.Add(dataGridViewDavaDurumu);
            Controls.Add(sil);
            Controls.Add(ekle);
            Controls.Add(Eposta);
            Controls.Add(txtDavaNo);
            Controls.Add(Ad);
            Name = "Durusma";
            Text = "Durusma";
            Load += Durusma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaDurumu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sil;
        private Button ekle;
        private Label Eposta;
        private TextBox txtDavaNo;
        private Label Ad;
        private DataGridView dataGridViewDavaDurumu;
        private ComboBox comboBoxMahkeme;
        private Label label6;
        private ComboBox comboBoxHakim;
        private DateTimePicker dateTimePickerDurusmaTarihi;
        private Label label4;
    }
}