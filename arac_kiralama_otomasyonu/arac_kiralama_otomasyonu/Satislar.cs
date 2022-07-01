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
    public partial class Satislar : Form
    {
        ArrayList musteriIdList = new ArrayList();
        private string aracPlaka = "";
        public Satislar()
        {
            InitializeComponent();
            Musteriler();
            Plakalar();

            satisListView.MultiSelect = false;
            satisListView.FullRowSelect = true;
            satisListView.View = View.Details;
            satisListView.GridLines = true;
            satisListView.Columns.Add("MÜŞTERİ", 160);
            satisListView.Columns.Add("MARKA", 150);
            satisListView.Columns.Add("MODEL", 150);
            satisListView.Columns.Add("RENK", 150);
            satisListView.Columns.Add("FİYAT", 150);

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

                SqlCommand command = new SqlCommand("Select * from satis INNER JOIN musteri ON satis.musteri_id=musteri.musteri_id", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["musteri_adi"].ToString() + " " + reader["musteri_soyadi"].ToString());
                        item.SubItems.Add(reader["marka"].ToString());
                        item.SubItems.Add(reader["model"].ToString());
                        item.SubItems.Add(reader["renk"].ToString());
                        item.SubItems.Add(reader["fiyat"].ToString());
                        satisListView.Items.Add(item);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
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

                    string query = "INSERT INTO satis (musteri_id, renk, fiyat, marka, model)";
                    query += " VALUES (@musteri_id, @renk, @fiyat, @marka, @model)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    SqlCommand myCommandDelete = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@musteri_id", musteriIdList[Convert.ToInt32(musteriComboBox.Text.Split(' ')[0]) - 1].ToString());
                    myCommand.Parameters.AddWithValue("@renk", renkTextBox.Text);
                    myCommand.Parameters.AddWithValue("@fiyat", fiyatTextBox.Text.Split(',')[0]);
                    myCommand.Parameters.AddWithValue("@marka", markaTextBox.Text);
                    myCommand.Parameters.AddWithValue("@model", modelTextBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    cnn.Open();

                    myCommandDelete.CommandText = "DELETE FROM arac WHERE arac_plaka = @arac_plaka";
                    myCommandDelete.Parameters.AddWithValue("@arac_plaka", aracPlakaComboBox.Text);
                    myCommandDelete.ExecuteNonQuery();

                    cnn.Close();
                    satisListView.Items.Clear();
                    Listele();

                    MessageBox.Show("Satış işlemi başarıyla gerçekleşti !");
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
                        renkTextBox.Text = reader["renk"].ToString();
                        fiyatTextBox.Text = Convert.ToDecimal(reader["fiyat"].ToString()).ToString();
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
    }
}
