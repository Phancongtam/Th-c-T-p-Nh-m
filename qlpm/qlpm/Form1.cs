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

namespace qlpm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            load();
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            //MessageBox có phương thức Show để hiển thị thông báo(MesageBoxButtons là để cài đặt nút bấm hai nút yes no)
            // Biến DialogResult để lưu lại kết quả trả về của phương thức MesageBox.Show.
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                this.Close();
           }
        }

        //Hàm xử lý ngoại lệ try catch.
        private void ketnoi() {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string truyvan = "SELECT * FROM NHANVIEN";
                SqlCommand com = new SqlCommand(truyvan, con);// 
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                MessageBox.Show("Kết nối thất bại, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
            
            
        }

        //Hàm load để load dữ liệu vào các ô texbox.
        private void load()
        {
            txt_ten.DataBindings.Clear();
            txt_ten.DataBindings.Add("Text", dataGridView1.DataSource, "HOTEN");
            txt_ns.DataBindings.Add("Text", dataGridView1.DataSource, "NS");
            txt_manv.DataBindings.Add("Text", dataGridView1.DataSource, "MANV");
            txt_mangs.DataBindings.Add("Text", dataGridView1.DataSource, "MANGS");
            com_gt.DataBindings.Add("Text", dataGridView1.DataSource, "GT");
            txt_luong.DataBindings.Add("Text", dataGridView1.DataSource, "LUONG");
            txt_mapb.DataBindings.Add("Text", dataGridView1.DataSource, "MAPB");
        }

        string them;
        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                them = "INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) VALUES (N'" + txt_ten.Text + "','" + txt_manv.Text + "',N'" + com_gt.Text + "','" + txt_mapb.Text + "','" + txt_ns.Text + "')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {

                MessageBox.Show("Không thêm được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        string xoa;
        private void but_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                xoa = "DELETE dbo.NHANVIEN WHERE MANV = '" + txt_manv.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Không xóa được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        string sua;
        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                sua = "UPDATE dbo.NHANVIEN SET HOTEN = N'" + txt_ten.Text + "',MANV = '" + txt_manv.Text + "',GT = N'" + com_gt.Text + "',MAPB = '" + txt_mapb.Text + "',NS = '" + txt_ns.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể sửa, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
