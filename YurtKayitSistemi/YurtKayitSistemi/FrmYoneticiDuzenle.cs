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

namespace YurtKayitSistemi
{
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

        private void FrmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet5.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, sifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtYoneticiId.Text = id;
            TxtKullaniciAdi.Text = ad;
            TxtSifre.Text = sifre;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from Admin where YoneticiId=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtYoneticiId.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiId=@p3", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p3", TxtYoneticiId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellendi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

    }
}
