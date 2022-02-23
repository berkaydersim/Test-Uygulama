using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Baslıyoruz
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=OZGÜR;Initial Catalog=DboDeneme;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
