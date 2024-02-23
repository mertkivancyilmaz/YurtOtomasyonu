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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet4.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet4.Giderler);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //FrmGiderGuncelle'deki tanımladığımız nesneleri çağırmak için yeni nesne tanımlıyoruz.
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            //Önceden tanımladığımız nesneyi (datagridde tıklanan satırın 0.hücresindeki index'i secilen'e atıyoruz)
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            //FrmGiderGuncelle'deki elektrik nesnesindeki bilgiye bilgi getirmek için (datagridde seçilen satırda, yukarıda hafızaya alınan index değerini kullanarak ve 1.hücredeki değeri FrmGiderGuncelledeki sayfaya getirtiyoruz)
            frg.id       = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su       = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.gida     = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.diger    = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }
}
