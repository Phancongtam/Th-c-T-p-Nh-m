using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class user_nv : UserControl
    {
        public user_nv()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private static user_nv _instance;
        public static user_nv Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_nv();
                return _instance;
            }
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM nhanvien";
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
            txt_nv_ma.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txt_nv_dc.DataBindings.Add("Text", dataGridView1.DataSource, "diachi");
            txt_nv_dt.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
            txt_nv_gt.DataBindings.Add("Text", dataGridView1.DataSource, "gioitinh");
            txt_nv_ns.DataBindings.Add("Text", dataGridView1.DataSource, "ns");
            txt_nv_ten.DataBindings.Add("Text", dataGridView1.DataSource, "tennv");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO nhanvien(manv ,tennv,diachi ,gioitinh ,ns ,sdt ) VALUES ('" + txt_nv_ma.Text + "',N'" + txt_nv_ten.Text + "',N'" + txt_nv_dc.Text + "',N'" + txt_nv_gt.Text + "','" + txt_nv_ns.Text + "','" + txt_nv_ns.Text + "','" + txt_nv_dt.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update nhanvien set tennv=N'" + txt_nv_ten.Text + "',diachi=N'" + txt_nv_dc + "' ,gioitinh=N'" + txt_nv_gt + "' ,ns='" + txt_nv_ns.Text + "' ,sdt='" + txt_nv_dt.Text + "' where manv = '" + txt_nv_ma.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửathành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete nhanvien where manv='" + txt_nv_ma.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửathành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }
    }
}
