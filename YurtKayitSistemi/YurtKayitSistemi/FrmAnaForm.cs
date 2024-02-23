using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void şifreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr = new FrmYoneticiDuzenle();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet11.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter1.Fill(this.yurtKayitDataSet11.Ogrenci);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/1/";
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://160.75.86.29:8088/stream/5/";
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/3/";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKyt fr = new FrmOgrKyt();
            fr.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrList fr = new FrmOgrList();
            fr.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrList fr = new FrmOgrList();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void borçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr = new FrmGider();
            fr.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            fr.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik fr = new FrmGelirIstatistik();
            fr.Show();
        }

        private void personelleriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.Show();
        }

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter1.Fill(this.yurtKayitDataSet11.Ogrenci);
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkımızdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program\n[1]Mert Kıvanç Yılmaz / [2]Özgür Kıran\nTarafından C# ve MsSQL Kullanılarak Geliştirilmiştir\n\n2021 Şubat\n\n[1]165050010\n[2]155050014\n\n" +
                "Bu Projede Bir Öğrenci Yurdunun İşletme Otomasyonu Yapımı Amaçlanmıştır.", "Öğenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radyolarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
