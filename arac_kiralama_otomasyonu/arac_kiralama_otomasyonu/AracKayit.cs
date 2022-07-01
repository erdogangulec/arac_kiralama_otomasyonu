using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama_otomasyonu
{
    public partial class AracKayit : Form
    {
        private string modelID = "";
        private string resimPath = "";
        public AracKayit()
        {
            InitializeComponent();
            markaComboBoxItems();
            modelComboBoxItems();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void markaEklebutton_Click(object sender, EventArgs e)
        {
            if (markaEkleTextBox.Text != "")
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";
                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "INSERT INTO arac_markalari (marka_adi)";
                    query += " VALUES (@marka_adi)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@marka_adi", markaEkleTextBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Marka kaydı başarılı !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                }

                markaComboBox.Items.Clear();
                markaComboBoxItems();
                markaEkleTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen marka giriniz");
            }
        }

        private void markaComboBoxItems()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from arac_markalari", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        markaComboBox.Items.Add(reader["marka_adi"]);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }
        private void modelComboBoxItems()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from arac_modelleri", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        modelComboBox.Items.Add(reader["model"]);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void modelEklebutton_Click(object sender, EventArgs e)
        {
            if ((modelEkleTextBox.Text != "") && (markaComboBox.Text != ""))
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";
                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "INSERT INTO arac_modelleri (model, marka_adi)";
                    query += " VALUES (@model, @marka_adi)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@model", modelEkleTextBox.Text);
                    myCommand.Parameters.AddWithValue("@marka_adi", markaComboBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Model kaydı başarılı !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                }

                modelComboBox.Items.Clear();
                modelComboBoxItems();
                modelEkleTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen marka ve model kısmını eksiksiz giriniz");
            }
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            byte[] resim = br.ReadBytes((int)fs.Length);

            br.Close();

            fs.Close();

            if ((aracPlakaTextBox.Text != "") && (yilTextBox.Text != "") && (kmTextBox.Text != "") && (renkTextBox.Text != "") && (fiyatTextBox.Text != "") && (kiralamaBedeliTextBox.Text != "") && (modelComboBox.Text != ""))
            {
                ModelIdBul();
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "INSERT INTO arac (arac_plaka, yil, kilometre, renk, fiyat, kiralama_bedeli, model_id, resim)";
                    query += " VALUES (@arac_plaka, @yil, @kilometre, @renk, @fiyat, @kiralama_bedeli, @model_id, @resim)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@arac_plaka", aracPlakaTextBox.Text);
                    myCommand.Parameters.AddWithValue("@yil", yilTextBox.Text);
                    myCommand.Parameters.AddWithValue("@kilometre", kmTextBox.Text);
                    myCommand.Parameters.AddWithValue("@renk", renkTextBox.Text);
                    myCommand.Parameters.AddWithValue("@fiyat", fiyatTextBox.Text);
                    myCommand.Parameters.AddWithValue("@kiralama_bedeli", kiralamaBedeliTextBox.Text);
                    myCommand.Parameters.AddWithValue("@model_id", modelID);
                    myCommand.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Araç kaydı başarılı !");
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
        private void ModelIdBul()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select model_id from arac_modelleri where model='" + modelComboBox.Text + "'", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        modelID = reader["model_id"].ToString();
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Ekle";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                resimPath = openFileDialog1.FileName.ToString();
            }
        }
    }
}
