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

namespace BitirmeProjesi
{
    public partial class Osmanli_Tarihi : Form
    {
        public Osmanli_Tarihi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;
        private void mesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into OsmanlıTarihi(MESAJGONDEREN,MESAJICERIK) values (@MESAJGONDEREN,@MESAJICERIK)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@MESAJGONDEREN", textGönderen.Text);
                komut.Parameters.AddWithValue("@MESAJICERIK", textMesaj.Text);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                baglanti.Close();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                this.osmanlıTarihiTableAdapter1.Fill(this.roomieDataSet.OsmanlıTarihi);
                textMesaj.Text = "";
                gönderildi.Show();
                baglanti.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show("Mesaj iletilmedi, Girdiğiniz bilgilere ait kullanıcı bulunumadı");
                gönderilmedi.Show();

            }

        }

        private void VerileriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From OsmanlıTarihi", baglanti);
            komutsil.ExecuteNonQuery();

            MessageBox.Show("Mesaj Kayıtları Silindi");
            this.osmanlıTarihiTableAdapter1.Fill(this.roomieDataSet.OsmanlıTarihi);
            baglanti.Close();
        }

        private void Osmanli_Tarihi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'roomieDataSet.OsmanlıTarihi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.osmanlıTarihiTableAdapter1.Fill(this.roomieDataSet.OsmanlıTarihi);
            // TODO: Bu kod satırı 'bitirmeProjesiDataSet.OsmanlıTarihi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }
    }
}
