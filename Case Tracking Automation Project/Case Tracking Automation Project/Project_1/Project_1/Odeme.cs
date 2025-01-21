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
    public partial class Odeme : Form
    {
        DatabaseConnect connector = new DatabaseConnect();
        public Odeme()
        {
            InitializeComponent();
        }
        private void radioKrediKarti_CheckedChanged(object sender, EventArgs e)
        {

            labelKartNumarasi.Visible = true;
            kartNoTextBox.Visible = true;
            labelCVV.Visible = true;
            cvvTextBox.Visible = true;
            labelAy.Visible = true;
            kartSonKullanmaAyTextBox.Visible = true;
            labelYil.Visible = true;
            label7.Visible = true;
            kartSonKullanmaYilTextBox.Visible = true;

        }
        //kapıda ödeme seçildiyse kart bilgileri içeren labelları gösterme
        private void radioNakit_CheckedChanged(object sender, EventArgs e)
        {

            labelKartNumarasi.Visible = false;
            kartNoTextBox.Visible = false;
            labelCVV.Visible = false;
            cvvTextBox.Visible = false;
            label7.Visible = false;
            labelAy.Visible = false;
            kartSonKullanmaAyTextBox.Visible = false;
            labelYil.Visible = false;
            kartSonKullanmaYilTextBox.Visible = false;

        }
        private void OdemeYap_Click(object sender, EventArgs e)
        {
            int davaID = Convert.ToInt32(davaIDTextBox.Text);
            int avukatID = Convert.ToInt32(avukatIDTextBox.Text);
            DateTime tarih = dateTimePickerTarih.Value;
            string odemeSekli = "";
            if (radioKrediKarti.Checked)
            {
                odemeSekli = "Kart";
                int cvv = Convert.ToInt32(cvvTextBox.Text);
                int kartSonKullanmaAy = Convert.ToInt32(kartSonKullanmaAyTextBox.Text);
                int kartSonKullanmaYil = Convert.ToInt32(kartSonKullanmaYilTextBox.Text);
                string kartNo = kartNoTextBox.Text;

                string insertQuery1 = "INSERT INTO Odeme (DavaID, AvukatID, Tarih, CVV, KartSonKullanmaAy, KartSonKullanmaYil, KartNo, OdemeSekli) " +
                                  "VALUES (@DavaID, @AvukatID, @Tarih, @CVV, @KartSonKullanmaAy, @KartSonKullanmaYil, @KartNo, @OdemeSekli)";

                MySqlCommand cmd1 = new MySqlCommand(insertQuery1, connector.myCon);
                // Parametreleri ekleyerek SQL sorgusunu hazırla
                cmd1.Parameters.AddWithValue("@DavaID", davaID);
                cmd1.Parameters.AddWithValue("@AvukatID", avukatID);
                cmd1.Parameters.AddWithValue("@Tarih", tarih);
                cmd1.Parameters.AddWithValue("@CVV", cvv);
                cmd1.Parameters.AddWithValue("@KartSonKullanmaAy", kartSonKullanmaAy);
                cmd1.Parameters.AddWithValue("@KartSonKullanmaYil", kartSonKullanmaYil);
                cmd1.Parameters.AddWithValue("@KartNo", kartNo);
                cmd1.Parameters.AddWithValue("@OdemeSekli", odemeSekli);

                connector.Ekle(cmd1);

                MessageBox.Show("Ödeme başarıyla Yapıldı.");
            }
            else if (radioNakitOdeme.Checked)
            {
                odemeSekli = "Nakit";
               
                string insertQuery = "INSERT INTO Odeme (DavaID, AvukatID, Tarih, OdemeSekli) VALUES (@DavaID, @AvukatID, @Tarih, @OdemeSekli)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, connector.myCon);
                // Parametreleri ekleyerek SQL sorgusunu hazırla
                cmd.Parameters.AddWithValue("@DavaID", davaID);
                cmd.Parameters.AddWithValue("@AvukatID", avukatID);
                cmd.Parameters.AddWithValue("@Tarih", tarih);
                cmd.Parameters.AddWithValue("@OdemeSekli", odemeSekli);

                connector.Ekle(cmd);

                MessageBox.Show("Ödeme başarıyla Yapıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme şekli seçin.");
                return; // Ödeme şekli seçilmemişse işlemi sonlandır
            }

            
            



        }
    }
}
