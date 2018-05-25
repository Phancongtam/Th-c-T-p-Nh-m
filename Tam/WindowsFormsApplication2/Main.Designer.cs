namespace WindowsFormsApplication2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_kh = new System.Windows.Forms.Button();
            this.but_nv = new System.Windows.Forms.Button();
            this.but_hdn = new System.Windows.Forms.Button();
            this.but_hdb = new System.Windows.Forms.Button();
            this.but_sp = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tool_thongtin,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.adminToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tool_thongtin
            // 
            this.tool_thongtin.Name = "tool_thongtin";
            this.tool_thongtin.Size = new System.Drawing.Size(123, 20);
            this.tool_thongtin.Text = "Thông tin tài khoản";
            this.tool_thongtin.Click += new System.EventHandler(this.tool_thongtin_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // but_kh
            // 
            this.but_kh.Location = new System.Drawing.Point(61, 37);
            this.but_kh.Name = "but_kh";
            this.but_kh.Size = new System.Drawing.Size(105, 58);
            this.but_kh.TabIndex = 4;
            this.but_kh.Text = "Khách hàng";
            this.but_kh.UseVisualStyleBackColor = true;
            this.but_kh.Click += new System.EventHandler(this.but_kh_Click);
            // 
            // but_nv
            // 
            this.but_nv.Location = new System.Drawing.Point(203, 37);
            this.but_nv.Name = "but_nv";
            this.but_nv.Size = new System.Drawing.Size(105, 58);
            this.but_nv.TabIndex = 4;
            this.but_nv.Text = "Nhân viên";
            this.but_nv.UseVisualStyleBackColor = true;
            this.but_nv.Click += new System.EventHandler(this.but_nv_Click);
            // 
            // but_hdn
            // 
            this.but_hdn.Location = new System.Drawing.Point(344, 37);
            this.but_hdn.Name = "but_hdn";
            this.but_hdn.Size = new System.Drawing.Size(105, 58);
            this.but_hdn.TabIndex = 4;
            this.but_hdn.Text = "Hóa đơn nhập";
            this.but_hdn.UseVisualStyleBackColor = true;
            this.but_hdn.Click += new System.EventHandler(this.but_hdn_Click);
            // 
            // but_hdb
            // 
            this.but_hdb.Location = new System.Drawing.Point(483, 37);
            this.but_hdb.Name = "but_hdb";
            this.but_hdb.Size = new System.Drawing.Size(105, 58);
            this.but_hdb.TabIndex = 4;
            this.but_hdb.Text = "Hóa đơn bán";
            this.but_hdb.UseVisualStyleBackColor = true;
            this.but_hdb.Click += new System.EventHandler(this.but_hdb_Click);
            // 
            // but_sp
            // 
            this.but_sp.Location = new System.Drawing.Point(632, 37);
            this.but_sp.Name = "but_sp";
            this.but_sp.Size = new System.Drawing.Size(105, 58);
            this.but_sp.TabIndex = 4;
            this.but_sp.Text = "Sản phẩm";
            this.but_sp.UseVisualStyleBackColor = true;
            this.but_sp.Click += new System.EventHandler(this.but_sp_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 110);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(834, 353);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 473);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.but_sp);
            this.Controls.Add(this.but_hdb);
            this.Controls.Add(this.but_hdn);
            this.Controls.Add(this.but_nv);
            this.Controls.Add(this.but_kh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool_thongtin;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button but_kh;
        private System.Windows.Forms.Button but_nv;
        private System.Windows.Forms.Button but_hdn;
        private System.Windows.Forms.Button but_hdb;
        private System.Windows.Forms.Button but_sp;
        private System.Windows.Forms.Panel panel;

    }
}