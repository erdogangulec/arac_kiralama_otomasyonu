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
    public partial class Yetkilendirme : Form
    {
        public Yetkilendirme()
        {
            InitializeComponent();
            Kullanicilar();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void yetkilendirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kullanıcıya admin yetkisi vermek istediğinize emin misiniz ? ", "Yetkilendirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    string query = "UPDATE kullanici SET yetki='admin' WHERE kullanici_adi=@kullanici_adi";

                    SqlCommand myCommand = new SqlCommand(query, cnn);
                    myCommand.Parameters.AddWithValue("@kullanici_adi", kullaniciComboBox.Text);
                    myCommand.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Yetkilendirme başarılı !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                }
            }
        }
        private void Kullanicilar()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("Select * from kullanici", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kullaniciComboBox.Items.Add(reader["kullanici_adi"].ToString());
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }
    }
}
