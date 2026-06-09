using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BY_Airlines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            label4.Visible= false;
            cmbDisHatlarNereden.Visible= false;
            cmbDisHatlarNereye.Visible= false;
            label2.Visible = true;
            label3.Visible = true;
            cmbIcHatlarNereden.Visible = true;
            cmbIcHatlarNereye.Visible = true;
            cmbIcHatlarNereden.Enabled = true;
            cmbIcHatlarNereye.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            cmbIcHatlarNereden.Visible = false;
            cmbIcHatlarNereye.Visible= false;
            label5.Visible = true;
            label4.Visible = true;
            cmbDisHatlarNereden.Visible = true;
            cmbDisHatlarNereye.Visible = true;
            cmbDisHatlarNereden.Enabled = true;
            cmbDisHatlarNereye.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label4.Visible = false;
            lblChange.Visible = false;
            cmbDisHatlarNereden.Enabled = false;
            cmbDisHatlarNereye.Enabled = false;
            cmbIcHatlarNereden.Enabled=false;
            cmbIcHatlarNereye.Enabled=false;
            dateTimePicker1.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                lblChange.Text = cmbIcHatlarNereye.Text;
                cmbIcHatlarNereye.Text = cmbIcHatlarNereden.Text;
                cmbIcHatlarNereden.Text=lblChange.Text;
                
            }
            if (radioButton2.Checked)
            {
                lblChange.Text = cmbDisHatlarNereye.Text;
                cmbDisHatlarNereye.Text = cmbDisHatlarNereden.Text;
                cmbDisHatlarNereden.Text = lblChange.Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked)
            {
                listBox1.Items.Add("Rota: "+ cmbIcHatlarNereden.Text+" - "+ cmbIcHatlarNereye.Text+"        "+ " Uçuş Tarihi: "+ dateTimePicker1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add("Rota: " + cmbDisHatlarNereden.Text + " - " + cmbDisHatlarNereye.Text + "        " + " Uçuş Tarihi: " + dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Hat tercihi yapınız:)");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          listBox1.Items.Clear();
        }
    }
}
