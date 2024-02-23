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

namespace YurtKayitSistemi
{
    public partial class FrmOgrKyt : Form
    {
        public FrmOgrKyt()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları

            //Tablonun içerisindeki nesne veya kategoriye ulaşmak için sorgulama
            SqlCommand Komut0 = new SqlCommand("Select BolumAd from Bolumler", bgl.baglanti());
            //Sorguyu okuma
            SqlDataReader oku0 = Komut0.ExecuteReader();
            while (oku0.Read())
            {
                //0. Index'teki sorgu elemanlarını çağırıp ComboBolum isimle araca elemanları yazdırma 
                ComboBolum.Items.Add(oku0[0].ToString());
            }
            bgl.baglanti().Close();
            //----------------------------------------------------------------------------------------
            //Boş Odaları Listeleme Komutları

            //Tablomuzdan dolu olmayan odaları combobox'a sıralıyoruz
            SqlCommand Komut1 = new SqlCommand("Select OdaNo from Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            //oku1 adından okunan değerleri atıyoruz
            SqlDataReader oku1 = Komut1.ExecuteReader();
            while (oku1.Read())
            {
                //Okunan değerleri listeye ekliyoruz
                ComboOdaNo.Items.Add(oku1[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void TxtOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }


        private void ComboBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxOda_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Öğrenci Kayıt Bilgilerini Kaydetme

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTxtBoxTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskTxtDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", ComboBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtBoxEmail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", ComboOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtBoxVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", RichVeliAdres.Text);
                //Sorgular üzerinde değişiklikleri gerçekleştirme
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Ogrenci ID'yi label'e çekme
                SqlCommand komutkaydet1 = new SqlCommand("select OgrID from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komutkaydet1.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2= new SqlCommand("insert into Borclar(OgrID,OgrAd,OgrSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, Kayıt Başarısız");
            }

            //Öğrenci Oda Kontenjanı Arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", ComboOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void TxtBoxVeliAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=KIVANC-OMEN;Initial Catalog=YurtKayit;Integrated Security=True