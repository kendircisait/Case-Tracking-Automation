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
    public partial class Avukat : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Avukat()
        {
            InitializeComponent();
        }
        public void AvukatListele()
        {
            string query = "SELECT * FROM Avukat";
            DataTable dataTable = connector.Baglanti(query);

            dataGridViewAvukat.DataSource = dataTable;

            // Sütun başlıklarını düzenleme
            dataGridViewAvukat.Columns["AvukatID"].HeaderText = "Avukat ID";
            dataGridViewAvukat.Columns["Ad"].HeaderText = "Ad";
            dataGridViewAvukat.Columns["Soyad"].HeaderText = "Soyad";
            dataGridViewAvukat.Columns["TelefonNumarasi"].HeaderText = "Telefon";
            dataGridViewAvukat.Columns["Eposta"].HeaderText = "E-posta";
            dataGridViewAvukat.Columns["UzmanlikAlani"].HeaderText = "Uzmanlık Alanı";
        }
        private void ekle_Click(object sender, EventArgs e)
        {

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string eposta = txtEposta.Text;
            string uzmanlikAlani = comboBoxUzmanlık.SelectedItem.ToString();

            string insertQuery = "INSERT INTO Avukat (Ad, Soyad, TelefonNumarasi, Eposta, UzmanlikAlani) " +
                             "VALUES (@Ad, @Soyad, @Telefon, @Eposta, @UzmanlikAlani)";

            // MySqlCommand nesnesini oluşturma ve parametreleri eklemek
            MySqlCommand cmd = new MySqlCommand(insertQuery, connector.myCon);
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            cmd.Parameters.AddWithValue("@Telefon", telefon);
            cmd.Parameters.AddWithValue("@Eposta", eposta);
            cmd.Parameters.AddWithValue("@UzmanlikAlani", uzmanlikAlani);

            // Veritabanına ekleme işlemini gerçekleştirme
            connector.Ekle(cmd);

            // Başarı mesajı veya loglama ekleyebilirsiniz
            MessageBox.Show("Avukat başarıyla eklendi!");
            AvukatListele();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int secim = dataGridViewAvukat.SelectedRows[0].Index;
            string AvukatNo = dataGridViewAvukat.Rows[secim].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bu Avukatı silmek istediğinizden emin misiniz?", "Avukat Silme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string silmeSorgusu = $"DELETE FROM Avukat WHERE AvukatID = '{AvukatNo}'";
                connector.Sil(silmeSorgusu);
                MessageBox.Show("Avukat başarıyla silindi!");

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int secim = dataGridViewAvukat.SelectedRows[0].Index;
            string avukatNo = dataGridViewAvukat.Rows[secim].Cells[0].Value.ToString();

            string yeniAd = txtAd.Text;
            string yeniSoyad = txtSoyad.Text;
            string yeniTelefon = txtTelefon.Text;
            string yeniEposta = txtEposta.Text;
            string yeniUzmanlikAlani = comboBoxUzmanlık.SelectedItem.ToString();



            // Güncelleme sorgusu
            string guncellemeSorgusu = "UPDATE Avukat SET Ad = @YeniAd, Soyad = @YeniSoyad, TelefonNumarasi = @YeniTelefon, Eposta = @YeniEposta, UzmanlikAlani = @YeniUzmanlikAlani WHERE AvukatID = @AvukatID";

            MySqlCommand cmd = new MySqlCommand(guncellemeSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@YeniAd", yeniAd);
            cmd.Parameters.AddWithValue("@YeniSoyad", yeniSoyad);
            cmd.Parameters.AddWithValue("@YeniTelefon", yeniTelefon);
            cmd.Parameters.AddWithValue("@YeniEposta", yeniEposta);
            cmd.Parameters.AddWithValue("@YeniUzmanlikAlani", yeniUzmanlikAlani);
            cmd.Parameters.AddWithValue("@AvukatID", avukatNo);

            connector.Guncelle(cmd);
            MessageBox.Show("Avukat başarıyla güncellendi!");
            AvukatListele();
        }
    }
}
