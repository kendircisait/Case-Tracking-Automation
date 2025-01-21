using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project_1
{
    public partial class Durusma : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Durusma()
        {
            InitializeComponent();
        }

        private void LoadMahkemeler()
        {
            // Mahkemeleri almak için sorgu
            string query = "SELECT * FROM Mahkeme";
            DataTable mahkemeTable = connector.Baglanti(query);
            comboBoxMahkeme.DataSource = mahkemeTable;
            comboBoxMahkeme.DisplayMember = "MahkemeAdi";
            comboBoxMahkeme.ValueMember = "MahkemeID";
        }

        private void LoadHakim()
        {
            // Hakim tablosundan hakimleri alıyoruz
            string query = "SELECT * FROM Hakim";
            DataTable hakimTable = connector.Baglanti(query);

            // ComboBox'ı hakimler ile doldurma
            comboBoxHakim.DataSource = hakimTable;
            comboBoxHakim.DisplayMember = "Ad"; // Gözükecek kolonun adı
            comboBoxHakim.ValueMember = "HakimID"; // Seçilen değeri saklamak için bu değeri tutuyoruz
        }
        public void Listele()
        {
            // Listeleme sorgusu
            string listelemeSorgusu = @"
             SELECT Durusma.DurusmaID, Dava.DavaID, Mahkeme.MahkemeID, Mahkeme.MahkemeAdi, Hakim.HakimID, Durusma.DurusmaTarihi
             FROM Durusma
             INNER JOIN Dava ON Durusma.DavaID = Dava.DavaID
             INNER JOIN Mahkeme ON Durusma.MahkemeID = Mahkeme.MahkemeID
             INNER JOIN Hakim ON Durusma.HakimID = Hakim.HakimID";


            DataTable dataTable = connector.Baglanti(listelemeSorgusu);

            // DataGridView'e DataTable'ı bağlama
            dataGridViewDavaDurumu.DataSource = dataTable;

            // Sütun başlıklarını düzenleme
            dataGridViewDavaDurumu.Columns["DurusmaID"].HeaderText = "Durusma ID";
            dataGridViewDavaDurumu.Columns["DavaID"].HeaderText = "Dava ID";
            dataGridViewDavaDurumu.Columns["MahkemeID"].HeaderText = "Mahkeme ID";
            dataGridViewDavaDurumu.Columns["MahkemeAdi"].HeaderText = "Mahkeme Adı";
            dataGridViewDavaDurumu.Columns["DurusmaTarihi"].HeaderText = "Duruşma Tarihi";
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            // girilen verileri alıyoruz
            int davaNo = Convert.ToInt32(txtDavaNo.Text);
            int mahkemeID = Convert.ToInt32(comboBoxMahkeme.SelectedValue);
            int hakimID = Convert.ToInt32(comboBoxHakim.SelectedValue);
            DateTime durusmaTarihi = dateTimePickerDurusmaTarihi.Value;

            // Ekleme sorgusu yazıyoruz
            string eklemeSorgusu = "INSERT INTO Durusma (DavaID, MahkemeID, HakimID, DurusmaTarihi) " +
                                    "VALUES (@DavaID, @MahkemeID, @HakimID, @DurusmaTarihi)";

            MySqlCommand cmd = new MySqlCommand(eklemeSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@DavaID", davaNo);
            cmd.Parameters.AddWithValue("@MahkemeID", mahkemeID);
            cmd.Parameters.AddWithValue("@HakimID", hakimID);
            cmd.Parameters.AddWithValue("@DurusmaTarihi", durusmaTarihi.ToString("yyyy-MM-dd"));

            // connector ile ekleme işlemi yapıyoruz
            connector.Ekle(cmd);

            MessageBox.Show("Durusma başarıyla eklendi!");
            Listele();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int secim = dataGridViewDavaDurumu.SelectedRows[0].Index;
            string davaNo = dataGridViewDavaDurumu.Rows[secim].Cells[0].Value.ToString();

            string silmeSorgusu = "DELETE FROM Durusma WHERE DavaID = {davaNo}";

            // Silme işlemini connectora parametre olarak gönderiyoruz
            connector.Sil(silmeSorgusu);

            MessageBox.Show("Durusma başarıyla silindi!");
        }

        private void Durusma_Load(object sender, EventArgs e)
        {
            LoadHakim();
            LoadMahkemeler();
        }
    }
}
