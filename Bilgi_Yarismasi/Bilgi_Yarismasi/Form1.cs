using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0;
        int dogru = 0, yanlis=0;

        private void btnA_Click(object sender, EventArgs e)
        {
            label5.Text=btnA.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                lblDogru.Text=dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            soruno++;
            lblSoruNo.Text = soruno.ToString();
            if( soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1835";
                btnB.Text = "1923";
                btnC.Text = "2000";
                btnD.Text = "1453";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye'den hangi ilimiz Ege bölgesinde bulunmaz?";
                btnA.Text = "Balıkesir";
                btnB.Text = "İzmir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                btnA.Text = "Cemal Süreyya";
                btnB.Text = "Atilla İlhan";
                btnC.Text = "Reşat Nuri";
                btnD.Text = "Sait Faik";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
            MessageBox.Show("Doğru: " + dogru +"\n"+" Yanlış: " + yanlis);
        }
    }
}
