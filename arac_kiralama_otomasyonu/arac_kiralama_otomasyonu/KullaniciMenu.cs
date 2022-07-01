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
    public partial class KullaniciMenu : Form
    {
        public KullaniciMenu()
        {
            InitializeComponent();
        }

        private void aracListeleButton_Click(object sender, EventArgs e)
        {
            KullaniciAracListele kullaniciAracListele = new KullaniciAracListele();
            kullaniciAracListele.Show();
            this.Hide();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sozlesmeButton_Click(object sender, EventArgs e)
        {
            KullaniciSozlesmeListele kullaniciSozlesmeListele = new KullaniciSozlesmeListele();
            kullaniciSozlesmeListele.Show();
            this.Hide();
        }
    }
}
