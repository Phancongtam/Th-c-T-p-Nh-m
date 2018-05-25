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
    public partial class CTHDN : Form
    {
        public CTHDN()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM ct_hoadonnhap";
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
            txt_cthdn_ma.DataBindings.Add("Text", dataGridView1.DataSource, "MAHD");
            txt_cthdn_masp.DataBindings.Add("Text", dataGridView1.DataSource, "MASP");
            txt_cthdn_sl.DataBindings.Add("Text", dataGridView1.DataSource, "SOLUONG");
            txt_cthdn_dg.DataBindings.Add("Text", dataGridView1.DataSource, "DONGIA");
            txt_cthdn_tt.DataBindings.Add("Text", dataGridView1.DataSource, "TONGTIEN");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO ct_hoadonnhap (mahdn ,masp ,soluong,thanhtien ,dongia ) VALUES ('" + txt_cthdn_ma.Text + "','" + txt_cthdn_masp.Text + "','" + txt_cthdn_sl.Text + "','" + txt_cthdn_tt.Text + "','" + txt_cthdn_dg.Text + "')";
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

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update ct_hoadonnhap set  soluong='" + txt_cthdn_sl.Text + "',thanhtien='" + txt_cthdn_tt.Text + "' ,dongia='" + txt_cthdn_dg.Text + "' where manhdn = '" + txt_cthdn_ma.Text + "' and masp='" + txt_cthdn_ma.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete ct_hoadonnhap where mahbb='" + txt_cthdn_ma.Text + "' and masp='"+txt_cthdn_masp.Text+"'";
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
