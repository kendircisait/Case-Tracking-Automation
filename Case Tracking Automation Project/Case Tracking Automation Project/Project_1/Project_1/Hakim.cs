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
    public partial class Hakim : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Hakim()
        {
            InitializeComponent();
        }
        public void HakimListele()
        {
            string query = "SELECT * FROM Hakim";
            DataTable dataTable = connector.Baglanti(query);

            // DataGridView'e DataTable'ı bağla
            dataGridViewHakim.DataSource = dataTable;

            // Sütun başlıklarını düzenleme
            dataGridViewHakim.Columns["HakimID"].HeaderText = "Hakim ID";
            dataGridViewHakim.Columns["Ad"].HeaderText = "Ad";
            dataGridViewHakim.Columns["Soyad"].HeaderText = "Soyad";
            dataGridViewHakim.Columns["TelefonNumarasi"].HeaderText = "Telefon";
            dataGridViewHakim.Columns["Eposta"].HeaderText = "E-posta";
        }
        private void ekle_Click(object sender, EventArgs e)
        {

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string eposta = txtEposta.Text;

            string eklemeSorgusu = "INSERT INTO Hakim (Ad, Soyad, TelefonNumarasi, Eposta) VALUES (@Ad, @Soyad, @Telefon, @Eposta)";

            MySqlCommand cmd = new MySqlCommand(eklemeSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            cmd.Parameters.AddWithValue("@Telefon", telefon);
            cmd.Parameters.AddWithValue("@Eposta", eposta);

            connector.Ekle(cmd);

            MessageBox.Show("Hakim başarıyla eklendi!");
            HakimListele(); // Ekleme işlemi sonrasında tabloyu tekrar listele
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int secim = dataGridViewHakim.SelectedRows[0].Index;
            string hakimID = dataGridViewHakim.Rows[secim].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bu Avukatı silmek istediğinizden emin misiniz?", "Avukat Silme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string silmeSorgusu = $"DELETE FROM Hakim WHERE HakimID = {hakimID}";
                connector.Sil(silmeSorgusu);
                MessageBox.Show("Hakim başarıyla silindi!");

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int secim = dataGridViewHakim.SelectedRows[0].Index;
            string hakimID = dataGridViewHakim.Rows[secim].Cells[0].Value.ToString();

            string yeniAd = txtAd.Text;
            string yeniSoyad = txtSoyad.Text;
            string yeniTelefon = txtTelefon.Text;
            string yeniEposta = txtEposta.Text;



            string guncellemeSorgusu = "UPDATE Hakim SET Ad = @YeniAd, Soyad = @YeniSoyad, TelefonNumarasi = @YeniTelefon, Eposta = @YeniEposta WHERE HakimID = @HakimID";

            MySqlCommand cmd = new MySqlCommand(guncellemeSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@YeniAd", yeniAd);
            cmd.Parameters.AddWithValue("@YeniSoyad", yeniSoyad);
            cmd.Parameters.AddWithValue("@YeniTelefon", yeniTelefon);
            cmd.Parameters.AddWithValue("@YeniEposta", yeniEposta);
            cmd.Parameters.AddWithValue("@HakimID", hakimID);

            connector.Guncelle(cmd);
            MessageBox.Show("Hakim başarıyla güncellendi!");
            HakimListele(); // Güncelleme işlemi sonrasında tabloyu tekrar listeliyoruz
        }
       
    }
}
