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
    public partial class HDN : Form
    {
        public HDN()
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
                string sql = "SELECT * FROM hoadonnhap";
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
            txt_hdn_ma.DataBindings.Add("Text", dataGridView1.DataSource, "MAHD");
            txt_hdn_mancc.DataBindings.Add("Text", dataGridView1.DataSource, "MANCC");
            txt_hdn_manv.DataBindings.Add("Text", dataGridView1.DataSource, "MANV");
            txt_hdn_ngay.DataBindings.Add("Text", dataGridView1.DataSource, "NGAY");
            txt_hdn_tien.DataBindings.Add("Text", dataGridView1.DataSource, "TONGTIEN");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO hoadonnhap(mahdn ,ngaynhap ,tongtien ,manv ,mancc) VALUES ('" + txt_hdn_ma.Text + "','" + txt_hdn_ngay.Text + "','" + txt_hdn_tien + "','" + txt_hdn_manv.Text + "','" + txt_hdn_mancc.Text + "')";
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

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update hoadonnhap set manv = N'" + txt_hdn_manv.Text + "',mancc = '" + txt_hdn_mancc.Text + "',ngayban = '" + txt_hdn_ngay.Text + ",tongtien='" + txt_hdn_tien.Text + "' where manhdn = '" + txt_hdn_ma.Text + "'";
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

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete hoadonnhap where mahbn='" + txt_hdn_ma.Text + "'";
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