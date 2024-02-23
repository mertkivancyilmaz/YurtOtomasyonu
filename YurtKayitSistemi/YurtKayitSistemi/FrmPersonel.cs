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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet61.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet61.Personel);
            // TODO: Bu kod satırı 'yurtKayitDataSet6.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.personelTableAdapter.Fill(this.yurtKayitDataSet61.Personel);
            MessageBox.Show("Kayıt Eklenti");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",TxtPersonelId.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet61.Personel);
        }


     

         private void BtnGuncelle_Click(object sender, EventArgs e)
            {
                SqlCommand komut2 = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelID=@p3", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtPersonelAdSoyad.Text);
                komut2.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
                komut2.Parameters.AddWithValue("@p3", TxtPersonelId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncellendi");
                this.personelTableAdapter.Fill(this.yurtKayitDataSet61.Personel);
            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string PersonelAdSoyad, PersonelGorev, id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            PersonelAdSoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            PersonelGorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtPersonelId.Text = id;
            TxtPersonelAdSoyad.Text = PersonelAdSoyad;
            TxtPersonelGorev.Text = PersonelGorev;

        }
    }
}
