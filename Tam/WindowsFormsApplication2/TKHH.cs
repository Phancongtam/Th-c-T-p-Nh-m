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


namespace WindowsFormsApplication2
{
    public partial class TKHH : Form
    {
        public TKHH()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (rd_sr_masp.Checked)
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string search_ma ="select * from sanpham where masp='" + txt_thongtin.Text + "'";
                SqlCommand com_search_ma = new SqlCommand(search_ma, con);
                com_search_ma.ExecuteNonQuery();
                SqlCommand com = new SqlCommand(search_ma, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                con.Close();
                dataGridView1.DataSource = table;

            }

            if (rd_sr_tensp.Checked)
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string search_ten = "select * from sanpham where tensp=N'" + txt_thongtin.Text + "'";
                SqlCommand com_search_ten = new SqlCommand(search_ten, con);
                com_search_ten.ExecuteNonQuery();
                SqlCommand com = new SqlCommand(search_ten, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                con.Close();
                dataGridView1.DataSource = table;

            }
       
            
      

        }
    }
}
