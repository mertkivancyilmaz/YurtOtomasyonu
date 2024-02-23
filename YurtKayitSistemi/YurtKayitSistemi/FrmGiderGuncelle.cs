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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }


        public string elektrik, su, dogalgaz, internet, gida, diger, personel, id;

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderId.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalgaz.Text = dogalgaz;
            TxtInternet.Text = internet;
            TxtGida.Text = gida;
            TxtDiger.Text = diger;
            TxtPersonel.Text = personel;
        }

        private void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1, Su=@p2, Dogalgaz=@p3, Internet=@p4, Gida=@p5, Personel=@p6, Diger=@p7 where OdemeID=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.Parameters.AddWithValue("@p8", TxtGiderId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }
    }
}
