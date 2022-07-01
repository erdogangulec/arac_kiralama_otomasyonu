using System;
using System.Collections;
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
    public partial class Sozlesme : Form
    {
        ArrayList musteriIdList = new ArrayList();
        private string aracPlaka = "";
        private decimal kiralamaBedeli = 0;
        public Sozlesme()
        {
            InitializeComponent();
            Musteriler();
            Plakalar();

            for (int i = 1; i < 31; i++)
            {
                gunSayisiComboBox.Items.Add(i);
            }
            gunSayisiComboBox.SelectedIndex = 0;

            sozlesmeListView.MultiSelect = false;
            sozlesmeListView.FullRowSelect = true;
            sozlesmeListView.View = View.Details;
            sozlesmeListView.GridLines = true;
            sozlesmeListView.Columns.Add("PLAKA", 180);
            sozlesmeListView.Columns.Add("MÜŞTERİ", 180);
            sozlesmeListView.Columns.Add("GÜN SAYISI", 180);
            sozlesmeListView.Columns.Add("ÜCRET", 180);
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

                SqlCommand command = new SqlCommand("Select * from sozlesme INNER JOIN musteri ON sozlesme.musteri_id=musteri.musteri_id", cnn);
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
        private void kayitbutton_Click(object sender, EventArgs e)
        {
            if ((aracPlakaComboBox.Text != "") && (musteriComboBox.Text != ""))
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "INSERT INTO sozlesme (musteri_id, arac_plaka, gun_sayisi, ucret)";
                    query += " VALUES (@musteri_id, @arac_plaka, @gun_sayisi, @ucret)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@musteri_id", musteriIdList[Convert.ToInt32(musteriComboBox.Text.Split(' ')[0]) - 1].ToString());
                    myCommand.Parameters.AddWithValue("@arac_plaka", aracPlakaComboBox.Text);
                    myCommand.Parameters.AddWithValue("@gun_sayisi", gunSayisiComboBox.Text);
                    myCommand.Parameters.AddWithValue("@ucret", kiralamaBedeliTextBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Sözleşme başarıyla oluşturuldu !");
                    sozlesmeListView.Items.Clear();
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen formu eksiksiz doldurunuz");
            }
        }

        private void Musteriler()
        {
            int siralamaNo = 1;
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
                        musteriComboBox.Items.Add(siralamaNo + " " + reader["musteri_adi"] + " " + reader["musteri_soyadi"]);
                        musteriIdList.Add(reader["musteri_id"].ToString());
                        siralamaNo++;
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void Plakalar()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from arac", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aracPlakaComboBox.Items.Add(reader["arac_plaka"].ToString());
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void aracPlakaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aracPlaka = aracPlakaComboBox.Text;
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from arac INNER JOIN arac_modelleri ON arac.model_id=arac_modelleri.model_id INNER JOIN arac_markalari ON arac_modelleri.marka_adi=arac_markalari.marka_adi where arac_plaka='" + aracPlaka + "'", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        markaTextBox.Text = reader["marka_adi"].ToString();
                        modelTextBox.Text = reader["model"].ToString();
                        kiralamaBedeli = Convert.ToDecimal(reader["kiralama_bedeli"].ToString());
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }

            kiralamaBedeliTextBox.Text = (Convert.ToInt32(kiralamaBedeli) * Convert.ToInt32(gunSayisiComboBox.Text)).ToString();

        }

        private void gunSayisiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiralamaBedeliTextBox.Text = (Convert.ToInt32(kiralamaBedeli) * Convert.ToInt32(gunSayisiComboBox.Text)).ToString();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
