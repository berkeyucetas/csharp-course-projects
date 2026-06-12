using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible= false;
            txtNmr.Visible= false;  
            pictureBox3.Visible= false;
            pictureBox4.Visible= false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            txtNmr.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            txtNmr.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar fr= new FrmOgrenciNotlar();
            fr.numara= txtNmr.Text;
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr= new FrmOgretmen();
            fr.Show();

        }
    }
}
