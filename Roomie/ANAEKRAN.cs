using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roomie
{
    public partial class ANAEKRAN : Form
    {
        public ANAEKRAN()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OQP1AD4\SQLEXPRESS;Initial Catalog=BitirmeProjesi;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            k K = new k();
            K.Show();
            
        }

        private void grupBtn_Click(object sender, EventArgs e)
        {
            GRUPLAR gruplar = new GRUPLAR();
            gruplar.Show();
            this.Hide();    
        }

        private void ANAEKRAN_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sifredegisBtn_Click(object sender, EventArgs e)
        {

        }

        private void iletisimBtn_Click(object sender, EventArgs e)
        {
            İLETİŞİMBİLGİLERİ iletisimbilgileri = new İLETİŞİMBİLGİLERİ();
            iletisimbilgileri.Show();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesapBtn_Click(object sender, EventArgs e)
        {
            HesapAyarları hesapayarları = new HesapAyarları();
            hesapayarları.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_3(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_4(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UygulamaAyarları uygulamaAyarları = new UygulamaAyarları();
            uygulamaAyarları.Show();
            
        }
    }
}
