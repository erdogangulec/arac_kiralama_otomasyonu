using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class KullaniciSozlesmeListele : Form
    {
        public KullaniciSozlesmeListele()
        {
            InitializeComponent();

            sozlesmeListView.MultiSelect = false;
            sozlesmeListView.FullRowSelect = true;
            sozlesmeListView.View = View.Details;
            sozlesmeListView.GridLines = true;
            sozlesmeListView.Columns.Add("PLAKA", 180);
            sozlesmeListView.Columns.Add("MÜŞTERİ", 180);
            sozlesmeListView.Columns.Add("GÜN SAYISI", 180);
            sozlesmeListView.Columns.Add("ÜCRET", 180);
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            KullaniciMenu kullaniciMenu = new KullaniciMenu();
            kullaniciMenu.Show();
            this.Hide();
        }

        private void Listele()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from sozlesme INNER JOIN musteri ON sozlesme.musteri_id=musteri.musteri_id where musteri_adi='" + adTextBox.Text + "' and musteri_soyadi='" + soyadTextBox.Text + "'", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["arac_plaka"].ToString());
                        item.SubItems.Add(reader["musteri_adi"].ToString() + " " + reader["musteri_soyadi"].ToString());
                        item.SubItems.Add(reader["gun_sayisi"].ToString());
                        item.SubItems.Add(reader["ucret"].ToString());
                        sozlesmeListView.Items.Add(item);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void sozlesmeSorgulabutton_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
