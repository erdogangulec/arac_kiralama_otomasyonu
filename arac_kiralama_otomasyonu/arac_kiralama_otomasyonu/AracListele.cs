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
    public partial class AracListele : Form
    {
        private string aracPlaka = "";
        public AracListele()
        {
            InitializeComponent();

            aracListeleListView.MultiSelect = false;
            aracListeleListView.FullRowSelect = true;
            aracListeleListView.View = View.Details;
            aracListeleListView.GridLines = true;

            aracListeleListView.Columns.Add("PLAKA", 160);
            aracListeleListView.Columns.Add("MARKA", 160);
            aracListeleListView.Columns.Add("MODEL", 160);
            aracListeleListView.Columns.Add("YIL", 160);
            aracListeleListView.Columns.Add("KİLOMETRE", 160);
            aracListeleListView.Columns.Add("RENK", 160);
            aracListeleListView.Columns.Add("FİYAT", 170);
            aracListeleListView.Columns.Add("KİRALAMA BEDELİ", 170);
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

                SqlCommand command = new SqlCommand("Select * from arac INNER JOIN arac_modelleri ON arac.model_id=arac_modelleri.model_id INNER JOIN arac_markalari ON arac_modelleri.marka_adi=arac_markalari.marka_adi", cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["arac_plaka"].ToString());
                        item.SubItems.Add(reader["marka_adi"].ToString());
                        item.SubItems.Add(reader["model"].ToString());
                        item.SubItems.Add(reader["yil"].ToString());
                        item.SubItems.Add(reader["kilometre"].ToString());
                        item.SubItems.Add(reader["renk"].ToString());
                        item.SubItems.Add(reader["fiyat"].ToString());
                        item.SubItems.Add(reader["kiralama_bedeli"].ToString());
                        aracListeleListView.Items.Add(item);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı");
            }
        }

        private void aracListeleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aracListeleListView.SelectedIndices.Count > 0)
            {
                var item = aracListeleListView.SelectedItems[0];
                string plaka = item.SubItems[0].Text;

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;"))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT resim FROM arac WHERE arac_plaka = '" + plaka + "'", connection));

                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] data = new Byte[0];
                            data = (Byte[])(dataSet.Tables[0].Rows[0]["resim"]);
                            MemoryStream mem = new MemoryStream(data);
                            pictureBox.Image = Image.FromStream(mem);
                        }
                        else
                        {
                            pictureBox.Image = null;
                            MessageBox.Show("Resim Yok!");
                        }
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }
            }
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void aracSilButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili aracı silmek istediğinize emin misiniz ? ", "Araç Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (aracListeleListView.SelectedIndices.Count > 0)
                {
                    var item = aracListeleListView.SelectedItems[0];
                    aracPlaka = item.SubItems[0].Text;

                    string connetionString = "Data Source=DESKTOP-75NPDKL;Initial Catalog=arac_kiralama;Integrated Security=SSPI;";
                    SqlConnection cnn;

                    cnn = new SqlConnection(connetionString);
                    cnn.Open();

                    try
                    {
                        string silmeSorgusu = "Delete From arac Where arac_plaka=@arac_plaka";
                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, cnn);
                        silKomutu.Parameters.AddWithValue("@arac_plaka", aracPlaka);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi");
                        aracListeleListView.Items.Clear();
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

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
