using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;

namespace Project_1
{
    public partial class Giris : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Giris()
        {
            InitializeComponent();
        }

        public bool KullaniciGirisDogrula(string kullaniciAdi, string sifre)
        {
            string query = $"SELECT * FROM Kullanicilar WHERE KullaniciAdi = '{kullaniciAdi}' AND Sifre = '{sifre}'";
            DataTable result = connector.Baglanti(query);

            // E�er d�nen sat�r varsa kullan�c� bilgileri do�rudur
            return result.Rows.Count > 0;
        }
        private void GirisYap_Click(object sender, EventArgs e)
        {
            string girdikullaniciAdi = KullaniciaditextBox.Text;
            string sifre = sifreTestBox.Text;

            bool dogrulama = KullaniciGirisDogrula(girdikullaniciAdi, sifre);

            if (dogrulama)
            {
                MessageBox.Show("Giri� ba�ar�l�!");
                DavaMenu menu = new DavaMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre yanl��!");
            }
        }

        private void KayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
        }
    }
}
