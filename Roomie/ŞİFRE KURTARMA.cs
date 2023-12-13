using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roomie
{
    public partial class ŞİFRE_KURTARMA : Form
    {
        public ŞİFRE_KURTARMA()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@" Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Tablo_kisiler where YEDEKKOD=@YEDEKKOD";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@YEDEKKOD", yedekod.Text);
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                sifreogren.Text = dr["ŞİFRE"].ToString();
             
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Girdiğiniz Kod Yanlış. Kodu hatırlamıyorsanız Şifre Değiştir Bölümünden yeni şifre oluşturabilirsiniz..");
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "UPDATE Tablo_Kisiler set ŞİFRE=@ŞİFRE where ÖĞRENCİNO=@ÖĞRENCİNO";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@ÖĞRENCİNO", öğrencinoo.Text);
            komut.Parameters.AddWithValue("@ŞİFRE", sifredegis.Text);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            label5.Text= sifredegis.Text;
            sifredegis.Text = "";
            MessageBox.Show("Şifreniz Güncellendi.");
        }
    }
}
