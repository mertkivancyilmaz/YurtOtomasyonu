using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace YurtKayitSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            //Veri Tabanı Bağlantısı
            SqlConnection baglan = new SqlConnection(@"Data Source=KIVO;Initial Catalog=YurtKayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
