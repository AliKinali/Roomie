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
    
    public partial class Patoloji : Form
    { 
    
    public Patoloji()
    {
        InitializeComponent();
    }

    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
    SqlCommand komut;
    SqlDataReader dr;

    private void Patoloji_Load(object sender, EventArgs e)
    {
            // TODO: Bu kod satırı 'roomieDataSet.Patoloji' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.patolojiTableAdapter1.Fill(this.roomieDataSet.Patoloji);
            // TODO: Bu kod satırı 'bitirmeProjesiDataSet.Patoloji' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void mesajGonder_Click(object sender, EventArgs e)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into Patoloji(MESAJGONDEREN,MESAJICERIK) values (@MESAJGONDEREN,@MESAJICERIK)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@MESAJGONDEREN", textGönderen.Text);
            komut.Parameters.AddWithValue("@MESAJICERIK", textMesaj.Text);

            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            baglanti.Close();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                this.patolojiTableAdapter1.Fill(this.roomieDataSet.Patoloji);
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
        SqlCommand komutsil = new SqlCommand("Delete From Patoloji", baglanti);
        komutsil.ExecuteNonQuery();

        MessageBox.Show("Mesaj Kayıtları Silindi");
            this.patolojiTableAdapter1.Fill(this.roomieDataSet.Patoloji);
            baglanti.Close();
    }
  
    }
   }
