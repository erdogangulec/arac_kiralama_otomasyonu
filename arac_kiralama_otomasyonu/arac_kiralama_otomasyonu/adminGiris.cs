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
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
            sifreTextBox.PasswordChar = '*';
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            if ((kullaniciAdiTextBox.Text != "") && (sifreTextBox.Text != ""))
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                cnn = new SqlConnection(connetionString);

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand("Select * from kullanici where kullanici_adi=@kullanici_adi and sifre=@sifre and yetki='admin'", cnn);
                    command.Parameters.AddWithValue("@kullanici_adi", kullaniciAdiTextBox.Text);
                    command.Parameters.AddWithValue("@sifre", sifreTextBox.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (MessageBox.Show("Giriş işlemi başarılı !") == DialogResult.OK)
                            {
                                Menu menu = new Menu();
                                menu.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı ya da şifre girdiniz/Admin girişi yetkiniz bulunmamaktadır");
                        }
                    }

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen istenen bilgileri eksiksiz giriniz");
            }
        }
    }
}
