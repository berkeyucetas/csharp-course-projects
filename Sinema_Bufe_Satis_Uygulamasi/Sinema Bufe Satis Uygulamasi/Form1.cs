using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasadeger = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir=Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            cay = Convert.ToInt16(txtCay.Text);
            su = Convert.ToInt16(txtSu.Text);

            toplam = misir * 4 + cay * 2 + bilet * 8 + su * 1;
            lblTutar.Text= toplam.ToString()+ " TL";

            kasadeger = kasadeger + toplam;
            lblKasa.Text= kasadeger.ToString()+ " TL";
        }
    }
}
