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
    public partial class Form1 : Form
    {
        public event loginsucces loginsucces = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void but_dn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LQRG0C\SQLEXPRESS;Initial Catalog=TAIKHOAN;Integrated Security=True");
            try
            {
                con.Open();
                string sql = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = '" + txt_tk.Text + "' and MATKHAU = '" + txt_mk.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader data = com.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    if (loginsucces != null)
                    {
                        loginsucces(this, new dangnhap { Username = txt_tk.Text, Pass = txt_mk.Text });
                    }
                    Main f2 = new Main();
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kết nổi thất bại!", "Thông báo");
            }
        }

        private void link_taotk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tao_tk f1 = new tao_tk();
            f1.Show();
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
