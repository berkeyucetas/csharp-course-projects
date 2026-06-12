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
using System.Data.SqlClient;

namespace Okul
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PMRM5TO\SQLEXPRESS;Initial Catalog=okul;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKULUP.ValueMember = "KULUPID";
            cmbKULUP.DisplayMember = "KULUPAD";
            cmbKULUP.DataSource = dt;
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value?.ToString();
                txtAD.Text = row.Cells[1].Value?.ToString();
                txtSOYAD.Text = row.Cells[2].Value?.ToString();
                if (row.Cells[3].Value != null)
                {
                    cmbKULUP.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    string cinsiyet = row.Cells[4].Value.ToString().Trim();
                    if (string.Equals(cinsiyet, "Kız", StringComparison.OrdinalIgnoreCase))
                    {
                        radioBtnKIZ.Checked = true;
                    }
                    else
                    {
                        radioBtnERKEK.Checked = true;
                    }
                }
            }
        }
        string cinsiyet = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (radioBtnERKEK.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else if (radioBtnKIZ.Checked == true)
            {
                cinsiyet = "Kız";
            }
            if (cmbKULUP.SelectedValue == null)
            {
                MessageBox.Show("Lütfen geçerli bir kulüp seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte kulupID = byte.Parse(cmbKULUP.SelectedValue.ToString());

            try
            {
                ds.OgrenciEkle(txtAD.Text, txtSOYAD.Text, kulupID, cinsiyet);
                MessageBox.Show("Öğrenci Kaydı Başarıyla Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtID.Text));
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi..");
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            if (radioBtnERKEK.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else if (radioBtnKIZ.Checked == true)
            {
                cinsiyet = "Kız";
            }
            if (cmbKULUP.SelectedValue == null)
            {
                MessageBox.Show("Lütfen geçerli bir kulüp seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte kulupID = byte.Parse(cmbKULUP.SelectedValue.ToString());
            int ogrenciID = int.Parse(txtID.Text);
            ds.OgrenciGuncelle(txtAD.Text, txtSOYAD.Text, kulupID, cinsiyet, ogrenciID);
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void radioBtnKIZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnKIZ.Checked == true)
            {
                cinsiyet = "Kız";
            }
        }

        private void radioBtnERKEK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnERKEK.Checked == true)
            {
                cinsiyet = "Erkek";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.OgrenciGetir(txtAra.Text);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.OgrenciListesi();
            dt.DefaultView.RowFilter = "OGRAD LIKE '" + txtAra.Text + "%'";
            dataGridView1.DataSource = dt;
        }
    }
}
