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
    public partial class FrmOgrList : Form
    {
        public FrmOgrList()
        {
            InitializeComponent();
        }

        private void FrmOgrList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet3.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet3.Ogrenci);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen değişkenine datagrid'din içindeki 0.hücrenin index'ini tanımlıyoruz
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            //fr'ye frmOgeduzenleyi atıyoruz
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            //fr'deki id'ye seçilen index'in 0.hücresindeki değeri atıyoruz ve aşağıda yazdırıyoruz
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.ogrTel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogumtarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.blm = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odaNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.VeliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.VeliTel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.VeliAdres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet3.Ogrenci);
        }
    }
}
