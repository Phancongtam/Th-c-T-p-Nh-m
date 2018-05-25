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
    public partial class CTHDB : Form
    {
        public CTHDB()
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
                string sql = "SELECT * FROM ct_hoadonban";
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
            txt_cthdb_ma.DataBindings.Add("Text", dataGridView1.DataSource, "MAHD");
            txt_cthdb_masp.DataBindings.Add("Text", dataGridView1.DataSource, "MASP");
            txt_cthdb_sl.DataBindings.Add("Text", dataGridView1.DataSource, "SOLUONG");
            txt_cthdb_dg.DataBindings.Add("Text", dataGridView1.DataSource, "DONGIA");
            txt_cthdb_tt.DataBindings.Add("Text", dataGridView1.DataSource, "TONGTIEN");

        }

        private void CTHDB_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO ct_hoadonban (mahdb ,masp ,soluong,thanhtien ,dongia ) VALUES ('" + txt_cthdb_ma.Text + "','" + txt_cthdb_masp.Text + "','" + txt_cthdb_sl.Text + "','" + txt_cthdb_tt.Text + "','" + txt_cthdb_dg.Text + "')";
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update ct_hoadonban set  soluong='"+txt_cthdb_sl.Text+"',thanhtien='"+txt_cthdb_tt.Text+"' ,dongia='"+txt_cthdb_dg.Text+"' where manhdb = '" + txt_cthdb_ma.Text + "' and masp='" + txt_cthdb_ma.Text + "'";
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete ct_hoadonban where mahbb='" + txt_cthdb_ma.Text + "' and masp='"+txt_cthdb_masp.Text+"'";
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
