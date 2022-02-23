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

namespace Baslıyoruz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Proje1", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
