using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void tool_thongtin_Click(object sender, EventArgs e)
        {
            qltk f1 = new qltk();
            f1.Show();
        }

        private void but_kh_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_kh.Instance))
            {
                panel.Controls.Add(user_kh.Instance);
                user_kh.Instance.Dock = DockStyle.Fill;
                user_kh.Instance.BringToFront();
            }
            else
                user_kh.Instance.BringToFront();
        }

        private void but_nv_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_nv.Instance))
            {
                panel.Controls.Add(user_nv.Instance);
                user_nv.Instance.Dock = DockStyle.Fill;
                user_nv.Instance.BringToFront();
            }
            else
                user_nv.Instance.BringToFront();
        }

        private void but_hdb_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_hdb.Instance))
            {
                panel.Controls.Add(user_hdb.Instance);
                user_hdb.Instance.Dock = DockStyle.Fill;
                user_hdb.Instance.BringToFront();
            }
            else
                user_hdb.Instance.BringToFront();
        }

        private void but_hdn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_hdn.Instance))
            {
                panel.Controls.Add(user_hdn.Instance);
                user_hdn.Instance.Dock = DockStyle.Fill;
                user_hdn.Instance.BringToFront();
            }
            else
                user_hdn.Instance.BringToFront();
        }

        private void but_sp_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_sp.Instance))
            {
                panel.Controls.Add(user_sp.Instance);
                user_sp.Instance.Dock = DockStyle.Fill;
                user_sp.Instance.BringToFront();
            }
            else
                user_sp.Instance.BringToFront();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
