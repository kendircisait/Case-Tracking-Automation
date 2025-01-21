using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project_1
{
    public partial class DavaTakip : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public DavaTakip()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            int davaNo = Convert.ToInt32(DavaNotextBox.Text);

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
                 LEFT JOIN Saat ON Dava.SaatID = Saat.SaatID
                 WHERE Dava.DavaID = {davaNo}";

            DataTable dataTable = connector.Baglanti(query);
            dataGridViewDavaTakip.DataSource = dataTable;

            // Sütun başlıklarını düzenleme
            dataGridViewDavaTakip.Columns["DavaID"].HeaderText = "Dava ID";
            dataGridViewDavaTakip.Columns["DavaAdi"].HeaderText = "Dava Adı";
            dataGridViewDavaTakip.Columns["DavaciAdi"].HeaderText = "Davacı Adı";
            dataGridViewDavaTakip.Columns["DavaciSoyadi"].HeaderText = "Davacı Soyadı";
            dataGridViewDavaTakip.Columns["DavaliAdi"].HeaderText = "Davalı Adı";
            dataGridViewDavaTakip.Columns["DavaliSoyadi"].HeaderText = "Davalı Soyadı";
            dataGridViewDavaTakip.Columns["DavaTuruAdi"].HeaderText = "Dava Türü";
            dataGridViewDavaTakip.Columns["MahkemeAdi"].HeaderText = "Mahkeme Adı";
            dataGridViewDavaTakip.Columns["AvukatAdi"].HeaderText = "Avukat Adı";
            dataGridViewDavaTakip.Columns["AvukatSoyadi"].HeaderText = "Avukat Soyadı";
            dataGridViewDavaTakip.Columns["Saat"].HeaderText = "Saat";
            dataGridViewDavaTakip.Columns["AcilmaTarihi"].HeaderText = "Açılma Tarihi";
            dataGridViewDavaTakip.Columns["DurusmaTarihi"].HeaderText = "Duruşma Tarihi";
            dataGridViewDavaTakip.Columns["Sonuc"].HeaderText = "Sonuç";


        }
        private void Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
