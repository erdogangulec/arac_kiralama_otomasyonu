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
    public partial class kullanici_admin_giris : Form
    {
        public kullanici_admin_giris()
        {
            InitializeComponent();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            adminGiris adminGiris = new adminGiris();
            adminGiris.Show();
            this.Hide();
        }

        private void kullanicibutton_Click(object sender, EventArgs e)
        {
            girisForm girisForm = new girisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}
