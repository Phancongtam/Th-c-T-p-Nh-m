using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class tao_tk : Form
    {
        public tao_tk()
        {
            InitializeComponent();
        }

        private void but_taotk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=TAIKHOAN;Integrated Security=True");
                con.Open();
                string them = ("INSERT INTO ACCOUNT(TAIKHOAN, MATKHAU, TENHIENTHI) VALUES(N'" + txt_tao_tk.Text + "', '" + txt_tao_mk.Text + "', N'" + txt_tenhienthi.Text + "')");
                SqlCommand com = new SqlCommand(them, con);
                SqlDataReader data = com.ExecuteReader();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thể tạo tài khoản!", "Thông báo");
            }
        }

        private void txt_tao_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void tao_tk_Load(object sender, EventArgs e)
        {

        }
    }
}
