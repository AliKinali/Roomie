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
using static System.Net.Mime.MediaTypeNames;

namespace Roomie
{
    public partial class k : Form
    {
        public k()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DTESCFG\SQLEXPRESS;Initial Catalog=Roomie;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        public string numara;

        private void kisilerBtn_Click(object sender, EventArgs e)
        {
            this.tablo_KisilerTableAdapter1.Fill(this.roomieDataSet.Tablo_Kisiler);
        }

        private void mesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Tablo_Mesaj (MESAJGONDEREN,MESAJALAN,MESAJICERIK) values (@MESAJGONDEREN,@MESAJALAN,@MESAJICERIK)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@MESAJGONDEREN", textGönderen.Text);
                komut.Parameters.AddWithValue("@MESAJALAN", textAlici.Text);
                komut.Parameters.AddWithValue("@MESAJICERIK", textMesaj.Text);
              
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                baglanti.Close();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                this.tablo_MesajTableAdapter1.Fill(this.roomieDataSet.Tablo_Mesaj);
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

        private void göster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tablo_Mesaj", baglanti);
            komutsil.ExecuteNonQuery();
          
            MessageBox.Show("Mesaj Kayıtları Silindi");
            this.tablo_MesajTableAdapter1.Fill(this.roomieDataSet.Tablo_Mesaj);
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
 
        private void k_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'roomieDataSet.Tablo_Kisiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo_KisilerTableAdapter1.Fill(this.roomieDataSet.Tablo_Kisiler);
            // TODO: Bu kod satırı 'roomieDataSet.Tablo_Mesaj' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo_MesajTableAdapter1.Fill(this.roomieDataSet.Tablo_Mesaj);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textGönderen.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAlici.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textMesaj.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
