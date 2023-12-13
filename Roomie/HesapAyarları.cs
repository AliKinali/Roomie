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

namespace Roomie
{
    public partial class HesapAyarları : Form
    {
        public HesapAyarları()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@" Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "UPDATE Tablo_Kisiler set AD=@AD,SOYAD=@SOYAD,ŞİFRE=@ŞİFRE,RESİM=@RESİM where ÖĞRENCİNO=@ÖĞRENCİNO";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@AD", textBox1.Text);
            komut.Parameters.AddWithValue("@SOYAD", textBox2.Text);
            komut.Parameters.AddWithValue("@ŞİFRE", textBox4.Text);
            komut.Parameters.AddWithValue("@ÖĞRENCİNO", label6.Text);
            komut.Parameters.AddWithValue("@RESİM", pictureBox1.ImageLocation);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Kullanıcı Bilgileriniz Güncellendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Tablo_kisiler where ÖĞRENCİNO=@ÖĞRENCİNO";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ÖĞRENCİNO", textBox3.Text);
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                label6.Text = dr["ÖĞRENCİNO"].ToString();
                textBox1.Text = dr["AD"].ToString();
                textBox2.Text = dr["SOYAD"].ToString();
                textBox4.Text = dr["ŞİFRE"].ToString();
                pictureBox1.ImageLocation = dr["RESİM"].ToString();
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label6.Text = "";
            pictureBox1.ImageLocation = "";
            textBox5.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;
        }
    }
}
