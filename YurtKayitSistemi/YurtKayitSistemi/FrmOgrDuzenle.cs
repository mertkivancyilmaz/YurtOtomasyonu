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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string id, ad, soyad, tc, dogumtarihi, ogrTel, blm, mail, odaNo, VeliTel, VeliAdSoyad, VeliAdres;

        private void ComboOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Silme Butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where OgrId=@k1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", TxtOgrId.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            

            //Odanın Aktif Öğrenci Sayısını Azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", ComboOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            Form.ActiveForm.Refresh();
            MessageBox.Show("Silindi");


        }



        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand(cmdText: "update Ogrenci set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon = @p11, OgrVeliAdres = @p12 where OgrID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrId.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTxtBoxTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskTxtDogum.Text);
                komut.Parameters.AddWithValue("@p7", ComboBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtBoxEmail.Text);
                komut.Parameters.AddWithValue("@p9", ComboOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtBoxVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RichVeliAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!!");
            }

        }

        private void TxtOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOgrAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini Öğrenci Listesinde kaydedilen Index verilerini kayıtlı şekilde ekrana hazır olarak getirme
            TxtOgrId.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTxtBoxTC.Text = tc;
            MskOgrTelefon.Text = ogrTel;
            MskTxtDogum.Text = dogumtarihi;
            ComboBolum.Text = blm;
            TxtBoxEmail.Text = mail;
            ComboOdaNo.Text = odaNo;
            TxtBoxVeliAdSoyad.Text = VeliAdSoyad;
            MskVeliTelefon.Text = VeliTel;
            RichVeliAdres.Text = VeliAdres;
            
        }
    }
}
