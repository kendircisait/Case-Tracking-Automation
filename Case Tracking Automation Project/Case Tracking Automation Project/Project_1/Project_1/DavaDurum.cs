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
    public partial class DavaDurum : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public DavaDurum()
        {
            InitializeComponent();
        }
        private void DavaDurumuListele()
        {
            string query = "SELECT * FROM DavaDurumu";
            DataTable dataTable = connector.Baglanti(query);
 
            dataGridViewDavaDurumu.DataSource = dataTable;
            dataGridViewDavaDurumu.Columns["DurumID"].HeaderText = "Durum ID";
            dataGridViewDavaDurumu.Columns["DavaID"].HeaderText = "Dava No";
            dataGridViewDavaDurumu.Columns["Durum"].HeaderText = "Durum";
    

        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            int davaID = Convert.ToInt32(txtDavaID.Text);
            string yeniDurum = txtDurum.Text;

            // davadurum tablosuna ekliyoruz
            string eklemeSorgusu = "INSERT INTO DavaDurumu (DavaID, Durum) VALUES (@DavaID, @Durum)";

            MySqlCommand cmd1 = new MySqlCommand(eklemeSorgusu, connector.myCon);
            cmd1.Parameters.AddWithValue("@DavaID", davaID);
            cmd1.Parameters.AddWithValue("@Durum", yeniDurum);

            
            connector.Ekle(cmd1);
            // burda Dava nın sonucunu güncelliyoruz
            string guncellemeSorgusu = "UPDATE Dava SET sonuc = @YeniDurum WHERE DavaID = @DavaID";
            MySqlCommand cmd = new MySqlCommand(guncellemeSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@YeniDurum", "YeniDurum");
            cmd.Parameters.AddWithValue("@DavaID", davaID);

            connector.Guncelle(cmd);
            MessageBox.Show("Dava Durumu başarıyla güncellendi!");
            DavaDurumuListele();
        }
    }
}
