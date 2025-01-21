using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project_1
{
    public partial class KayitOl : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public KayitOl()
        {
            InitializeComponent();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            string kullaniciad = KullaniciaditextBox.Text;
            string sifre = sifreTextBox.Text;
            string ad = adtextBox.Text;
            string soyad = soyadtextBox.Text;
            string email = mailtextBox.Text;
            

            string ekleSorgusu = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, Email) " +
                                 "VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Email)";

            MySqlCommand cmd = new MySqlCommand(ekleSorgusu, connector.myCon);
            cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciad);
            cmd.Parameters.AddWithValue("@Sifre", sifre);
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);      
            cmd.Parameters.AddWithValue("@Email", email);
            

            connector.Ekle(cmd);

            MessageBox.Show("Kullanıcı başarıyla eklendi!");
            Giris giris = new Giris();
            giris.Show();
        }
    }
}
