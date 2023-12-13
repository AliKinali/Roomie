using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roomie
{
    public partial class İLETİŞİMBİLGİLERİ : Form
    {
        public İLETİŞİMBİLGİLERİ()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void İLETİŞİMBİLGİLERİ_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Tablo_kisiler where ŞİFRE=@ŞİFRE";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ŞİFRE", textBox1.Text);
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                label7.Text = dr["ÖĞRENCİNO"].ToString();
                label10.Text = dr["AD"].ToString();
                label12.Text = dr["SOYAD"].ToString();
                label13.Text = dr["KULLANICITİPİ"].ToString();
                label11.Text = dr["ÜNİVERSİTE"].ToString();
                label9.Text = dr["BÖLÜM"].ToString();
                pictureBox1.ImageLocation= dr["RESİM"].ToString();
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Yanlış Şifre.. Tekrar Deneyiniz");
            baglanti.Close();
           
        }
    }
}
