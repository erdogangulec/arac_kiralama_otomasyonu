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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
            sifreTextBox.PasswordChar = '*';
            sifreTekrarTextBox.PasswordChar = '*';
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            if ((kullaniciAdiTextBox.Text != "") && (sifreTextBox.Text != "") && (sifreTekrarTextBox.Text != ""))
            {
                if (sifreTextBox.Text  == sifreTekrarTextBox.Text )
                {
                    string connetionString = null;
                    SqlConnection cnn;
                    connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";

                    cnn = new SqlConnection(connetionString); 

                    try
                    {
                        cnn.Open();

                        string query = "INSERT INTO kullanici (kullanici_adi, sifre)";
                        query += " VALUES (@kullanici_adi, @sifre)";

                        SqlCommand myCommand = new SqlCommand(query, cnn);
                        myCommand.Parameters.AddWithValue("@kullanici_adi", kullaniciAdiTextBox.Text);
                        myCommand.Parameters.AddWithValue("@sifre", sifreTextBox.Text);
                        myCommand.ExecuteNonQuery();
                        cnn.Close();

                        if(MessageBox.Show("Kullanıcı kaydınız başarıyla oluşturuldu. Giriş ekranına yönlendireleceksiniz.") == DialogResult.OK)
                        {
                            girisForm GirisForm = new girisForm();
                            GirisForm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı bağlantısı kurulamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şifrenizi tekrar kutucuğuna doğru giriniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen istenen bilgileri eksiksiz giriniz");
            }
        }
    }
}
