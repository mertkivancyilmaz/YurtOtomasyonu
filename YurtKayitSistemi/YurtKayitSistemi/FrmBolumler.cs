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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        //Class Çağırılarak Veritabanı ile Proje bağlantısı
        SqlBaglantim bgl = new SqlBaglantim();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //Sql Komutu oluşturup, BolumAd değerlerini alıyoruz
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                //P1 parametresini tanıtıyoruz
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                //Kayıt ediyoruz
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı");
                //Kayıttan sonra reflesh etkisi yaratmak için veriler tekrar çekilir
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
                throw;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            renk.BackColor = Color.Black;
            string id, bolumad;
            //Secilen'e datagridview'daki seçilen hücrenin satır Index'ini alma
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            //id'ye datagriddeki seçilen satır değerinin 0.hücresindeki değeri string olarak ata
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //bolumad'a datagriddeki seçilen satır değerinin 1.hücresindeki değeri string olarak ata
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            //Yukarıda belirtilen ve atanan değerleri textbox'a koyma
            TxtBolumID.Text = id;
            //Yukarıda belirtilen ve atanan değerleri textbox'a koyma
            TxtBolumAd.Text = bolumad;
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                //komut3'e Bolumlerdeki Bolumad'ı girilen parametre değeri ile değiştirmek için sql komutu kullanılıyor
                SqlCommand komut3 = new SqlCommand("update Bolumler set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
                //
                komut3.Parameters.AddWithValue("@p2", TxtBolumID.Text);
                //Yukarıda istenen parametre txtbolumAd'a girilen parametre @p1'e atanıyor ve yukarı satırda kullanılıyor
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
                MessageBox.Show("Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }
        }
    }
}
