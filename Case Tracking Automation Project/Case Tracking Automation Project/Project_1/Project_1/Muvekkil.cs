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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project_1
{
    public partial class Muvekkil : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Muvekkil()
        {
            InitializeComponent();
        }



        public void Listele()
        {
            // Davalı tablosundan verileri aldım
            string query = "SELECT * FROM Davali";
            // tanımladığım DatabaseConnect sınıfından bağlantı methodunu çağırdım çünkü verileri datagridview da göstericem.
            DataTable dataTable = connector.Baglanti(query);


            dataGridViewDavali.DataSource = dataTable;

            // Oluşan tablonun sütün başlıklarını düzenledim.
            dataGridViewDavali.Columns["DavaliID"].HeaderText = "Davacı Numarası";
            dataGridViewDavali.Columns["DavaliAd"].HeaderText = "Ad";
            dataGridViewDavali.Columns["Soyad"].HeaderText = "Soyad";
            dataGridViewDavali.Columns["TelefonNumarasi"].HeaderText = "Tel";
            dataGridViewDavali.Columns["Eposta"].HeaderText = "E-posta";
            dataGridViewDavali.Columns["Adres"].HeaderText = "Adres";


        }

        public void Listele2()
        {
            // Davacı tablosundan verileri aldım
            string query = "SELECT * FROM Davaci";
            // tanımladığım DatabaseConnect sınıfından bağlantı methodunu çağırdım çünkü verileri datagridview da göstericem.
            DataTable dataTable = connector.Baglanti(query);


            dataGridViewDavaci.DataSource = dataTable;

            // Oluşan tablonun sütün başlıklarını düzenledim.
            dataGridViewDavaci.Columns["DavaciID"].HeaderText = "Davacı Numarası";
            dataGridViewDavaci.Columns["DavaciAd"].HeaderText = "Ad";
            dataGridViewDavaci.Columns["DavaciSoyad"].HeaderText = "Soyad";
            dataGridViewDavaci.Columns["TelefonNumarasi"].HeaderText = "Tel";
            dataGridViewDavaci.Columns["Eposta"].HeaderText = "E-posta";
            dataGridViewDavaci.Columns["Adres"].HeaderText = "Adres";



        }
        private void Ekle_Click(object sender, EventArgs e)
        {

            string MuvekkilAdi = muvekkilAdiTextBox.Text;
            string MuvekkilSoyadi = muvekkilSoyadiTextBox.Text;
            string MuvekkilTelefon = muvekkilTelTextBox.Text;
            string email = muvekkilEmailTextBox.Text;
            string MuvekkilAdresi = MuvekkilAdresTextBox.Text;

            if (DavalıRadioButton.Checked)
            {
                // Davalı tablosuna veri ekliyoruz
                string yenimuvekkilSorgusu = "INSERT INTO Davali (DavaliAd, Soyad, TelefonNumarasi, Eposta, Adres) VALUES (@Ad, @Soyad, @Telefon, @Eposta, @Adres)";
                ;

                MySqlCommand cmd = new MySqlCommand(yenimuvekkilSorgusu, connector.myCon);
                cmd.Parameters.AddWithValue("@Ad", MuvekkilAdi);
                cmd.Parameters.AddWithValue("@Soyad", MuvekkilSoyadi);
                cmd.Parameters.AddWithValue("@Telefon", MuvekkilTelefon);
                cmd.Parameters.AddWithValue("@Eposta", email);
                cmd.Parameters.AddWithValue("@Adres", MuvekkilAdresi);


                connector.Ekle(cmd);
                Listele();
            }
            else if (DavacıRadioButton.Checked)
            {

                // Davacı tablosuna veri ekliyoruz
                string yenimuvekkilSorgusu = "INSERT INTO Davaci (DavaciAd, DavaciSoyad, TelefonNumarasi, Eposta, Adres) VALUES (@Ad, @DavaciSoyad, @Telefon, @Eposta, @Adres)";
                ;

                MySqlCommand cmd = new MySqlCommand(yenimuvekkilSorgusu, connector.myCon);
                cmd.Parameters.AddWithValue("@Ad", MuvekkilAdi);
                cmd.Parameters.AddWithValue("@DavaciSoyad", MuvekkilSoyadi);
                cmd.Parameters.AddWithValue("@Telefon", MuvekkilTelefon);
                cmd.Parameters.AddWithValue("@Eposta", email);
                cmd.Parameters.AddWithValue("@Adres", MuvekkilAdresi);


                connector.Ekle(cmd);
                Listele2();
            }
            else
            {
                MessageBox.Show("Lütfen durum seçiniz!");


                return;
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {


            if (dataGridViewDavaci.SelectedRows.Count > 0)
            {
                int secim = dataGridViewDavaci.SelectedRows[0].Index;
                string muvekkilNo = dataGridViewDavaci.Rows[secim].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Bu Müvekkili silmek istediğinizden emin misiniz?", "Müvekkil Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string silmeSorgusu = $"DELETE FROM Davaci WHERE DavaciID = '{muvekkilNo}'";
                    connector.Sil(silmeSorgusu);
                    MessageBox.Show("Müvekkil başarıyla silindi!");

                }
            }
            else if (dataGridViewDavali.SelectedRows.Count > 0)
            {

                int secim = dataGridViewDavali.SelectedRows[0].Index;
                string muvekkilNo = dataGridViewDavali.Rows[secim].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Bu müvekkili silmek istediğinizden emin misiniz?", "Müvekkil Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string silmeSorgusu = $"DELETE FROM Davali WHERE DavaliID = '{muvekkilNo}'";
                    connector.Sil(silmeSorgusu);
                    MessageBox.Show("Müvekkil başarıyla silindi!");

                }


            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir Müvekkil seçin!");
            }

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewDavaci.SelectedRows.Count > 0)
            {
                int secim = dataGridViewDavaci.SelectedRows[0].Index;
                string muvekkilNo = dataGridViewDavaci.Rows[secim].Cells[0].Value.ToString();

                string yeniMuvekkilAdi = muvekkilAdiTextBox.Text;
                string yeniMuvekkilSoyadi = muvekkilSoyadiTextBox.Text;
                string yeniMuvekkilTelefon = muvekkilTelTextBox.Text;
                string yeniEmail = muvekkilEmailTextBox.Text;
                string yeniMuvekkilAdresi = MuvekkilAdresTextBox.Text;



                // güncelleme sorgusu
                string yenimuvekkilSorgusu = "UPDATE Davaci SET DavaciAd = @YeniAd, DavaciSoyad = @YeniSoyad, TelefonNumarasi = @YeniTelefon, Eposta = @YeniEposta, Adres = @YeniAdres WHERE DavaciID = @DavaciID";
                ;

                MySqlCommand cmd = new MySqlCommand(yenimuvekkilSorgusu, connector.myCon);
                cmd.Parameters.AddWithValue("@YeniAd", yeniMuvekkilAdi);
                cmd.Parameters.AddWithValue("@YeniSoyad", yeniMuvekkilSoyadi);
                cmd.Parameters.AddWithValue("@YeniTelefon", yeniMuvekkilTelefon);
                cmd.Parameters.AddWithValue("@YeniEposta", yeniEmail);
                cmd.Parameters.AddWithValue("@YeniAdres", yeniMuvekkilAdresi);
                cmd.Parameters.AddWithValue("@DavaciID", muvekkilNo);

                connector.Guncelle(cmd);
                MessageBox.Show("Davacı başarıyla güncellendi!");
                Listele2(); // Güncelleme işlemi sonrasında tabloyu tekrar listele
            }
            else if (dataGridViewDavali.SelectedRows.Count > 0)
            {

                int secim = dataGridViewDavali.SelectedRows[0].Index;
                string muvekkilNo = dataGridViewDavali.Rows[secim].Cells[0].Value.ToString();


                // Güncellenecek yeni bilgileri textboxtan al
                string yeniMuvekkilAdi = muvekkilAdiTextBox.Text;
                string yeniMuvekkilSoyadi = muvekkilSoyadiTextBox.Text;
                string yeniMuvekkilTelefon = muvekkilTelTextBox.Text;
                string yeniEmail = muvekkilEmailTextBox.Text;
                string yeniMuvekkilAdresi = MuvekkilAdresTextBox.Text;


                // Güncelleme sorgusu

                // Davacı tablosuna veri ekliyoruz
                string yenimuvekkilSorgusu = "UPDATE Davali SET DavaliAd = @YeniAd, Soyad = @YeniSoyad, TelefonNumarasi = @YeniTelefon, Eposta = @YeniEposta, Adres = @YeniAdres WHERE DavaliID = @DavaliID";
                ;

                MySqlCommand cmd = new MySqlCommand(yenimuvekkilSorgusu, connector.myCon);
                cmd.Parameters.AddWithValue("@YeniAd", yeniMuvekkilAdi);
                cmd.Parameters.AddWithValue("@YeniSoyad", yeniMuvekkilSoyadi);
                cmd.Parameters.AddWithValue("@YeniTelefon", yeniMuvekkilTelefon);
                cmd.Parameters.AddWithValue("@YeniEposta", yeniEmail);
                cmd.Parameters.AddWithValue("@YeniAdres", yeniMuvekkilAdresi);
                cmd.Parameters.AddWithValue("@DavaliID", muvekkilNo);
                connector.Guncelle(cmd);
                MessageBox.Show("Personel başarıyla güncellendi!");
                Listele(); // Güncelleme işlemi sonrasında tabloyu tekrar listele

            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir Müvekkil seçin!");
            }

        }

        private void listeleButton_Click(object sender, EventArgs e)
        {
            Listele();
            Listele2();
        }
    }
}
