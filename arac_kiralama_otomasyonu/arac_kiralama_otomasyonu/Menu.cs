using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Hide();
        }

        private void musteriListeleButton_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.Show();
            this.Hide();
        }

        private void aracKayitButton_Click(object sender, EventArgs e)
        {
            AracKayit aracKayit = new AracKayit();
            aracKayit.Show();
            this.Hide();
        }

        private void aracListeleButton_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
            this.Hide();
        }

        private void sozlesmeButton_Click(object sender, EventArgs e)
        {
            Sozlesme sozlesme = new Sozlesme();
            sozlesme.Show();
            this.Hide();
        }

        private void satislarButton_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.Show();
            this.Hide();
        }

        private void yetkiButton_Click(object sender, EventArgs e)
        {
            Yetkilendirme yetkilendirme = new Yetkilendirme();
            yetkilendirme.Show();
            this.Hide();
        }
    }
}
