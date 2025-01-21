using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class DavaMenu : Form
    {
        public DavaMenu()
        {
            InitializeComponent();
        }

        private void DavaTakip_Click(object sender, EventArgs e)
        {
            DavaTakip takip = new DavaTakip();
            takip.Show();
        }


        private void CikisYap_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }

        private void Müvekkil_Click(object sender, EventArgs e)
        {
            Muvekkil muvekkil = new Muvekkil();
            muvekkil.Show();

        }

        private void DavaKayit_Click(object sender, EventArgs e)
        {
            DavaKaydi davaKaydi = new DavaKaydi();
            davaKaydi.Show();
        }

        private void Avukat_Click(object sender, EventArgs e)
        {
            Avukat avukat = new Avukat();
            avukat.Show();
        }

        private void Odeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
        }

        private void Hakim_Click(object sender, EventArgs e)
        {
            Hakim hakim = new Hakim();
            hakim.Show();
        }

        private void DavaDurum_Click(object sender, EventArgs e)
        {
            DavaDurum durum = new DavaDurum();
            durum.Show();
        }

        private void Durusma_Click(object sender, EventArgs e)
        {
            Durusma durusma = new Durusma();    
            durusma.Show();
        }
    }
}
