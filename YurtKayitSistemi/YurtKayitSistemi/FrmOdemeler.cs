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
    public partial class FrmOdemeler : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtOgrID.Text = id;
            TxtKalan.Text = kalan;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            //Kalan Borcu TextBox'ta gösteriyoruz
            TxtKalan.Text = yeniborc.ToString();

            //Yeni tutarı SQL veri tabanına kaydetme
            //Komut tanımına "Borçları Güncellettirme" sorgusunu giriyoruz
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrId=@p2", bgl.baglanti());
            //Parametre @p1'e ID text olarak tanımlandı
            komut.Parameters.AddWithValue("@p2", TxtOgrID.Text);
            //Parametre @p2'ye Kalan text olarak tanımlandı
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            //Tekrardan DataView'ı güncelliyoruz
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy, OdemeMiktar) values(@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtBoxOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
