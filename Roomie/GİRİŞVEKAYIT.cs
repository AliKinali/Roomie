using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roomie
{
    public partial class GİRİŞVEKAYIT : Form
    {
        public GİRİŞVEKAYIT()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "Z", "K", "P", "R", "Y", "I", "Q", "E", "O" };  //Güvenlik kodundaki sembol ve sayıların değerini giriyoruz
            string[] sembol2 = { "*", "+", "-", "_", "?", "<", ">", "$", "#", "=" };
            string[] sembol3 = { "a", "z", "k", "p", "r", "y", "i", "q", "r", "o" };

            Random r = new Random();   // Rastgele değer çekmesi için Random sınıfını kullanıyoruz
            int s1, s2, s3, s4, s5;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, sembol3.Length);
            s4 = r.Next(0, 10);
            s5 = r.Next(0, 10);


            lblguvenlikod.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString() + s5.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Tablo_Kisiler(AD,SOYAD,ÖĞRENCİNO,ŞİFRE,KULLANICITİPİ,ÜNİVERSİTE,BÖLÜM,RESİM,YEDEKKOD) values (@AD,@SOYAD,@ÖĞRENCİNO,@ŞİFRE,@KULLANICITİPİ,@ÜNİVERSİTE,@BÖLÜM,@RESİM,@YEDEKKOD)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@AD", textAd.Text);
                komut.Parameters.AddWithValue("@SOYAD", textSoyad.Text);
                komut.Parameters.AddWithValue("@ÖĞRENCİNO", textÖğrenciNo.Text);
                komut.Parameters.AddWithValue("@ŞİFRE", textSifre.Text);
                komut.Parameters.AddWithValue("@KULLANICITİPİ", textKullaniciTipi.Text);
                komut.Parameters.AddWithValue("@ÜNİVERSİTE", üniversite.Text);
                komut.Parameters.AddWithValue("@BÖLÜM", bölüm.Text);
                komut.Parameters.AddWithValue("@RESİM", textBox3.Text);
                komut.Parameters.AddWithValue("@YEDEKKOD", yedekkod.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
                textAd.Text = "";
                textSoyad.Text = "";
                textÖğrenciNo.Text = "";
                textSifre.Text = "";
                textKullaniciTipi.Text = "";
                üniversite.Text = "";
                bölüm.Text = "";
                yedekkod.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox4.Text == lblguvenlikod.Text)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Tablo_Kisiler where ÖĞRENCİNO=@P1 AND ŞİFRE=@P2", baglanti);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.Parameters.AddWithValue("@P2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    ANAEKRAN anaekran = new ANAEKRAN();
                    anaekran.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Giris Basarisiz");
                }
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Resimdeki karakterleri yanlış girdiniz, Tekrar Deneyiniz...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox3.Text = openFileDialog1.FileName;
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "Z", "K", "P", "R", "Y", "I", "Q", "E", "O" };  //Güvenlik kodundaki sembol ve sayıların değerini giriyoruz
            string[] sembol2 = { "*", "+", "-", "_", "?", "<", ">", "$", "#", "=" };
            string[] sembol3 = { "a", "z", "k", "p", "r", "y", "i", "q", "r", "o" };

            Random r = new Random();   // Rastgele değer çekmesi için Random sınıfını kullanıyoruz
            int s1, s2, s3, s4, s5;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, sembol3.Length);
            s4 = r.Next(0, 10);
            s5 = r.Next(0, 10);


            lblguvenlikod.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString() + s5.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ŞİFRE_KURTARMA şİFRE_KURTARMA   = new ŞİFRE_KURTARMA();
            şİFRE_KURTARMA.Show();
        }
    }
}
