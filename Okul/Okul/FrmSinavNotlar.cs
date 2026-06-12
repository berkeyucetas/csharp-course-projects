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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOGRNO.Text));
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOGRNO.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtS1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtS2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtS3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPROJE.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtORT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDRM.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int s1, s2, s3, proje;
        double ort;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            string durum;
            s1=Convert.ToInt16(txtS1.Text);
            s2 = Convert.ToInt16(txtS2.Text);
            s3 = Convert.ToInt16(txtS3.Text);
            proje = Convert.ToInt16(txtPROJE.Text);
            ort = (s1 + s2 + s3 + proje) / 4;
            txtORT.Text =ort.ToString();
            if(ort>=50)
            {
                txtDRM.Text = "True";
            }

            else
            {
                txtDRM.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDRM.Text = "";
            txtORT.Text = "";
            txtPROJE.Text = "";
            txtS1.Text = "";
            txtS2.Text = "";
            txtS3.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDERSAD.SelectedValue.ToString()), int.Parse(txtOGRNO.Text), byte.Parse(txtS1.Text), byte.Parse(txtS2.Text), byte.Parse(txtS3.Text), byte.Parse(txtPROJE.Text), decimal.Parse(txtORT.Text), bool.Parse(txtDRM.Text), notid);
            MessageBox.Show("Ders Güncelleme İşlemi Başarıyla Tamamlanmıştır..");
        }
    }
}
