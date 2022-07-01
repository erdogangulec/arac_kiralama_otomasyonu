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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            if ((adTextBox.Text != "") && (soyadTextBox.Text != "") && (yasTextBox.Text != "") && (telefonTextBox.Text != "") && (sehirTextBox.Text != "") && (adresTextBox.Text != ""))
            {
                string connetionString;
                connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "INSERT INTO musteri (musteri_adi, musteri_soyadi, musteri_yas, sehir, telefon, adres)";
                    query += " VALUES (@musteri_adi, @musteri_soyadi, @musteri_yas, @sehir,@telefon, @adres)";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@musteri_adi", adTextBox.Text);
                    myCommand.Parameters.AddWithValue("@musteri_soyadi", soyadTextBox.Text);
                    myCommand.Parameters.AddWithValue("@musteri_yas", yasTextBox.Text);
                    myCommand.Parameters.AddWithValue("@sehir", sehirTextBox.Text);
                    myCommand.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
                    myCommand.Parameters.AddWithValue("@adres", adresTextBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Müşteri kaydı başarılı !");
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
    }
}
