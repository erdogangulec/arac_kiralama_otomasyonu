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
    public partial class MusteriListele : Form
    {
        private string musteriID = "";
        public MusteriListele()
        {
            InitializeComponent();

            musteriListeleListView.MultiSelect = false;
            musteriListeleListView.FullRowSelect = true;
            musteriListeleListView.View = View.Details;
            musteriListeleListView.GridLines = true;
            musteriListeleListView.Columns.Add("AD", 160);
            musteriListeleListView.Columns.Add("SOYAD", 180);
            musteriListeleListView.Columns.Add("YAŞ", 180);
            musteriListeleListView.Columns.Add("ŞEHİR", 180);
            musteriListeleListView.Columns.Add("TELEFON", 180);
            musteriListeleListView.Columns.Add("ADRES", 200);
            Listele();
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

                SqlCommand command = new SqlCommand("Select * from musteri", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["musteri_adi"].ToString());
                        item.SubItems.Add(reader["musteri_soyadi"].ToString());
                        item.SubItems.Add(reader["musteri_yas"].ToString());
                        item.SubItems.Add(reader["sehir"].ToString());
                        item.SubItems.Add(reader["telefon"].ToString());
                        item.SubItems.Add(reader["adres"].ToString());
                        musteriListeleListView.Items.Add(item);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }
        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void MusteriIdBul()
        {
            var item = musteriListeleListView.SelectedItems[0];
            string musteriAdi = item.SubItems[0].Text;
            string musteriSoyadi = item.SubItems[1].Text;
            string musteriTelefon = item.SubItems[4].Text;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select musteri_id from musteri where musteri_adi='" + musteriAdi + "' and musteri_soyadi='" + musteriSoyadi + "' and telefon='" + musteriTelefon + "'", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        musteriID = reader["musteri_id"].ToString();
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz ? ", "Araç Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (musteriListeleListView.SelectedIndices.Count > 0)
                {
                    MusteriIdBul();
                    string connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";
                    SqlConnection cnn;

                    cnn = new SqlConnection(connetionString);
                    cnn.Open();

                    try
                    {
                        string silmeSorgusuSatis = "Delete From satis Where musteri_id=@musteri_id";
                        string silmeSorgusuSozlesme = "Delete From sozlesme Where musteri_id=@musteri_id";
                        string silmeSorgusu = "Delete From musteri Where musteri_id=@musteri_id";
                        SqlCommand silKomutuSatis = new SqlCommand(silmeSorgusuSatis, cnn);
                        silKomutuSatis.Parameters.AddWithValue("@musteri_id", Convert.ToInt32(musteriID));
                        SqlCommand silKomutuSozlesme = new SqlCommand(silmeSorgusuSozlesme, cnn);
                        silKomutuSozlesme.Parameters.AddWithValue("@musteri_id", Convert.ToInt32(musteriID));
                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, cnn);
                        silKomutu.Parameters.AddWithValue("@musteri_id", Convert.ToInt32(musteriID));
                        silKomutuSatis.ExecuteNonQuery();
                        silKomutuSozlesme.ExecuteNonQuery();
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi");
                        musteriListeleListView.Items.Clear();
                        Listele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                    }
                    cnn.Close();
                }
            }
        }
    }
}
