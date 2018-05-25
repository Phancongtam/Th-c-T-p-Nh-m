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
    public partial class SP : Form
    {
        public SP()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM sanpham";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                con.Close();
                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                MessageBox.Show("Kết nối thất bại!");
            }

        }
        private void load()
        {
            txt_sp_masp.DataBindings.Add("Text", dataGridView1.DataSource, "MASP");
            txt_sp_maloai.DataBindings.Add("Text", dataGridView1.DataSource, "MALOAI");
            txt_sp_tensp.DataBindings.Add("Text", dataGridView1.DataSource, "TEN");
            txt_sp_gb.DataBindings.Add("Text", dataGridView1.DataSource, "GIA");
            txt_sp_sl.DataBindings.Add("Text", dataGridView1.DataSource, "SOLUONG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO sanpham (masp ,tensp,maloai,giaban ,soluong ) VALUES ('" + txt_sp_masp.Text + "',N'" + txt_sp_tensp.Text + "','" + txt_sp_maloai.Text + "','"+txt_sp_gb.Text+"','"+txt_sp_sl.Text+"')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update sanpham set tensp=N'"+txt_sp_tensp.Text+"',maloai='"+txt_sp_maloai.Text+"',giaban='"+txt_sp_gb.Text+"' ,soluong='"+txt_sp_sl.Text+"' where masp = '" + txt_sp_masp.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete sanpham where mansp='" + txt_sp_masp.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }
    }
}
