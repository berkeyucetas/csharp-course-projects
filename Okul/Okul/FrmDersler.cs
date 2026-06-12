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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdersadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtdersadi.Text);
            MessageBox.Show("Ders Ekleme İşlemi Başarıyla Tamamlanmıştır..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Hata önleme: Eğer ID alanı boşsa işlem yapma ve kullanıcıyı uyar
            if (string.IsNullOrEmpty(txtdersid.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ds.DersSil(byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();
            txtdersid.Clear();
            txtdersadi.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Hata önleme: ID alanı veya Yeni Ders Adı boşsa işlem yapma
            if (string.IsNullOrEmpty(txtdersid.Text) || string.IsNullOrEmpty(txtdersadi.Text))
            {
                MessageBox.Show("Lütfen güncellenecek dersi seçin ve yeni adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ds.DersGuncelle(txtdersadi.Text, byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();
            txtdersid.Clear();
            txtdersadi.Clear();
        }
    }
}
