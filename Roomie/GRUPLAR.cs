using BitirmeProjesi;
using Roomie.BitirmeProjesiDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomie
{
    public partial class GRUPLAR : Form
    {
        public GRUPLAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematik_1Grubu matematik_1Grubu = new Matematik_1Grubu();
            matematik_1Grubu.Show();
            
        }

        private void GRUPLAR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PROGRAMLAMA1 programlama1 = new PROGRAMLAMA1();
            programlama1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Muhendislik_Giris muhendislik_giris=new Muhendislik_Giris();
            muhendislik_giris.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fizik_1 fizik_1 = new Fizik_1();
            fizik_1.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fizyoloji fizyoloji = new Fizyoloji();
            fizyoloji.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Matematik_2 matematik_2 = new Matematik_2();
            matematik_2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edebiyat_Tarihi edebiyat_Tarihi = new Edebiyat_Tarihi();
            edebiyat_Tarihi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Osmanli_Tarihi osmanlitarihi = new Osmanli_Tarihi();
            osmanlitarihi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Programlama2 programlama2 = new Programlama2();
            programlama2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Numerik_Analiz numerik_Analiz = new Numerik_Analiz();
            numerik_Analiz.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Dis_Hekimliginde_Arac_Gerec dis_Hekimliginde_Arac_Gerec = new Dis_Hekimliginde_Arac_Gerec();
            dis_Hekimliginde_Arac_Gerec.Show();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AnadoluUygarliklari anadoluUygarliklari = new AnadoluUygarliklari();
            anadoluUygarliklari.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ortodonti ortodonti = new Ortodonti();
            ortodonti.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Java_Programlama java_Programlama = new Java_Programlama();
            java_Programlama.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Monografya monografya = new Monografya();
            monografya.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Osmanli_Turkcesi osmanli_Turkcesi = new Osmanli_Turkcesi();
            osmanli_Turkcesi.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Patoloji patoloji = new Patoloji();
            patoloji.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Serveti_Funun_Edebiyati serveti_Funun_Edebiyati = new Serveti_Funun_Edebiyati();
            serveti_Funun_Edebiyati.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Tanzimat_Edebiyati tanzimat = new Tanzimat_Edebiyati();
            tanzimat.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Yazilim_Mimarisi_Ve_Tasarimi yazilim_Mimarisi_Ve_Tasarimi = new Yazilim_Mimarisi_Ve_Tasarimi();
            yazilim_Mimarisi_Ve_Tasarimi.Show();
        }

        private void girişVeKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GİRİŞVEKAYIT frm = new GİRİŞVEKAYIT();
            frm.Show();
            
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ANAEKRAN frm = new ANAEKRAN();
            frm.Show();
            this.Hide();
        }

        private void hesapAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAyarları frm = new HesapAyarları();
            frm.Show();
           
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İLETİŞİMBİLGİLERİ iletişim = new İLETİŞİMBİLGİLERİ();
            iletişim.Show();
          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void küçükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            groupBox3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            groupBox4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            groupBox5.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Regular);
            groupBox3.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Regular);
            groupBox4.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Regular);
            groupBox5.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Regular);
        }

        private void büyükToolStripMenuItem_Click(object sender, EventArgs e)
        {

            groupBox2.Font = new Font("Microsoft Sans Serif", (float)10.75, FontStyle.Regular);
            groupBox3.Font = new Font("Microsoft Sans Serif", (float)10.75, FontStyle.Regular);
            groupBox4.Font = new Font("Microsoft Sans Serif", (float)10.75, FontStyle.Regular);
            groupBox5.Font = new Font("Microsoft Sans Serif", (float)10.75, FontStyle.Regular); 
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Red;
            groupBox3.ForeColor = Color.Red;
            groupBox4.ForeColor = Color.Red;
            groupBox5.ForeColor = Color.Red;

            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Red;
            button3.ForeColor = Color.Red;
            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Red;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            groupBox4.ForeColor = Color.Black;
            groupBox5.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Green;
            groupBox3.ForeColor = Color.Green;
            groupBox4.ForeColor = Color.Green;
            groupBox5.ForeColor = Color.Green;
            button1.ForeColor = Color.Green;
            button2.ForeColor = Color.Green;
            button3.ForeColor = Color.Green;
            button4.ForeColor = Color.Green;
            button5.ForeColor = Color.Green;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }
    }
}
