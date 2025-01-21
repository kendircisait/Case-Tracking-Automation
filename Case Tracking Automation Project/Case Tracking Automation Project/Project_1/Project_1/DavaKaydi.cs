using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_1
{
    public partial class DavaKaydi : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public DavaKaydi()
        {
            InitializeComponent();
        }
        private void LoadDavaTurleri()
        {
            // Dava türlerini almak için sorgu
            string query = "SELECT * FROM DavaTuru";


            DataTable davaTuruTable = connector.Baglanti(query);

            // ComboBox'ı dava türleri ile doldurma
            comboBoxDavaTuru.DataSource = davaTuruTable;
            comboBoxDavaTuru.DisplayMember = "DavaTuruAdi"; // Gösterilecek sütun adı
            comboBoxDavaTuru.ValueMember = "DavaTuruID"; // Seçilen öğenin değeri
        }

        private void LoadMahkemeler()
        {
            // Mahkemeleri almak için sorgu
            string query = "SELECT * FROM Mahkeme";
            DataTable mahkemeTable = connector.Baglanti(query);
            comboBoxMahkeme.DataSource = mahkemeTable;
            comboBoxMahkeme.DisplayMember = "MahkemeAdi";
            comboBoxMahkeme.ValueMember = "MahkemeID"; // Seçilen öğenin değeri
        }
        private void LoadAvukat()
        {
            // Avukatları almak için sorgu
            string query = "SELECT * FROM Avukat";

            // Sorguyu çalıştırarak avukatları içeren bir DataTable elde etme
            DataTable avukatTable = connector.Baglanti(query);

            // ComboBox'ı avukatlar ile doldurma
            comboBoxAvukat.DataSource = avukatTable;
            comboBoxAvukat.DisplayMember = "Ad"; // Gösterilecek sütun adı
            comboBoxAvukat.ValueMember = "AvukatID"; // Seçilen değeri saklamak için kullanılan sütun adı
        }
        private void LoadSaat()
        {
            // Saat tablosundan saatleri almak için sorgu
            string query = "SELECT * FROM Saat";

            // Sorguyu çalıştırarak saatleri içeren bir DataTable elde etme
            DataTable saatTable = connector.Baglanti(query);

            // ComboBox'ı saatlerle doldurma
            comboBoxSaat.DataSource = saatTable;
            comboBoxSaat.DisplayMember = "Saat"; // Gösterilecek sütun adı
            comboBoxSaat.ValueMember = "SaatID"; // Seçilen değeri saklamak için kullanılan sütun adı
        }

        public void Listele()
        {

            string query = $@"SELECT Dava.DavaID, Dava.DavaAdi, 
                        Davaci.DavaciAd AS DavaciAdi, Davaci.DavaciSoyad AS DavaciSoyadi, 
                        Davali.DavaliAd AS DavaliAdi, Davali.Soyad AS DavaliSoyadi, 
                        DavaTuru.DavaTuruAdi, Mahkeme.MahkemeAdi, 
                        Avukat.Ad AS AvukatAdi, Avukat.Soyad AS AvukatSoyadi, 
                        Saat.Saat, Dava.AcilmaTarihi, Dava.DurusmaTarihi, Dava.Sonuc
                 FROM Dava
                 LEFT JOIN Davaci ON Dava.DavaciID = Davaci.DavaciID
                 LEFT JOIN Davali ON Dava.DavaliID = Davali.DavaliID
                 LEFT JOIN DavaTuru ON Dava.DavaTuruID = DavaTuru.DavaTuruID
                 LEFT JOIN Mahkeme ON Dava.MahkemeID = Mahkeme.MahkemeID
                 LEFT JOIN Avukat ON Dava.AvukatID = Avukat.AvukatID
                 LEFT JOIN Saat ON Dava.SaatID = Saat.SaatID";

            DataTable dataTable = connector.Baglanti(query);
            dataGridViewDava.DataSource = dataTable;

            // Sütun başlıklarını düzenleme
            dataGridViewDava.Columns["DavaID"].HeaderText = "Dava ID";
            dataGridViewDava.Columns["DavaAdi"].HeaderText = "Dava Adı";
            dataGridViewDava.Columns["DavaciAdi"].HeaderText = "Davacı Adı";
            dataGridViewDava.Columns["DavaciSoyadi"].HeaderText = "Davacı Soyadı";
            dataGridViewDava.Columns["DavaliAdi"].HeaderText = "Davalı Adı";
            dataGridViewDava.Columns["DavaliSoyadi"].HeaderText = "Davalı Soyadı";
            dataGridViewDava.Columns["DavaTuruAdi"].HeaderText = "Dava Türü";
            dataGridViewDava.Columns["MahkemeAdi"].HeaderText = "Mahkeme Adı";
            dataGridViewDava.Columns["AvukatAdi"].HeaderText = "Avukat Adı";
            dataGridViewDava.Columns["AvukatSoyadi"].HeaderText = "Avukat Soyadı";
            dataGridViewDava.Columns["Saat"].HeaderText = "Saat";
            dataGridViewDava.Columns["AcilmaTarihi"].HeaderText = "Açılma Tarihi";
            dataGridViewDava.Columns["DurusmaTarihi"].HeaderText = "Duruşma Tarihi";
            dataGridViewDava.Columns["Sonuc"].HeaderText = "Sonuç";


        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string davaAdi = DavaAdiTextBox.Text;
            DateTime acilmaTarihi = dateTimePickerDurusma.Value;
            DateTime durusmaTarihi = dateTimePickerDurusma.Value;
            int davaciID = Convert.ToInt32(DavaciIDTextBox.Text);
            int davaliID = Convert.ToInt32(DavaliIDTextBox.Text);
            int selectedDavaTuruID = Convert.ToInt32(comboBoxDavaTuru.SelectedValue);
            int selectedAvukatID = Convert.ToInt32(comboBoxAvukat.SelectedValue);
            int selectedMahkemeID = Convert.ToInt32(comboBoxMahkeme.SelectedValue);
            int selectedSaatID = Convert.ToInt32(comboBoxSaat.SelectedValue);
            string sonuc = "sonuçlandırılmadı";


            string insertQuery = "INSERT INTO Dava (DavaAdi, DavaciID, DavaliID, MahkemeID, DavaTuruID, AvukatID, SaatID, AcilmaTarihi, DurusmaTarihi, Sonuc) " +
                     "VALUES (@DavaAdi, @DavaciID, @DavaliID, @MahkemeID, @DavaTuruID, @AvukatID, @SaatID, @AcilmaTarihi, @DurusmaTarihi, @Sonuc)";

            MySqlCommand cmd = new MySqlCommand(insertQuery, connector.myCon);
            cmd.Parameters.AddWithValue("@DavaAdi", davaAdi);
            cmd.Parameters.AddWithValue("@DavaciID", davaciID);
            cmd.Parameters.AddWithValue("@DavaliID", davaliID);
            cmd.Parameters.AddWithValue("@MahkemeID", selectedMahkemeID);
            cmd.Parameters.AddWithValue("@DavaTuruID", selectedDavaTuruID);
            cmd.Parameters.AddWithValue("@AvukatID", selectedAvukatID);
            cmd.Parameters.AddWithValue("@SaatID", selectedSaatID);
            cmd.Parameters.AddWithValue("@AcilmaTarihi", acilmaTarihi.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DurusmaTarihi", durusmaTarihi.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Sonuc", sonuc);

            connector.Ekle(cmd);
            Listele();

        }

        private void DavaKaydi_Load(object sender, EventArgs e)
        {
            LoadDavaTurleri();
            LoadAvukat();
            LoadMahkemeler();
            LoadSaat();
        }
    }
}
