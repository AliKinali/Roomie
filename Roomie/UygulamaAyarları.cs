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
    public partial class UygulamaAyarları : Form
    {
        public UygulamaAyarları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Green;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Brown;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Orange;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.Violet;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("Arial",10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("ludida Console", 10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("Rockwell", 10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("Times New Roman", 10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("Latin", 10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {
                    control.Font = new Font("Mv Boli", 10); // yeni yazı tipi ve boyutu burada ayarlanıyor
                }
            }
        }
    }
}
