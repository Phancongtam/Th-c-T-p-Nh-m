namespace WindowsFormsApplication2
{
    partial class HDN
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_hdn_manv = new System.Windows.Forms.TextBox();
            this.txt_hdn_ngay = new System.Windows.Forms.TextBox();
            this.txt_hdn_mancc = new System.Windows.Forms.TextBox();
            this.txt_hdn_ma = new System.Windows.Forms.TextBox();
            this.txt_hdn_tien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(296, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thành tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 204);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_hdn_manv
            // 
            this.txt_hdn_manv.Location = new System.Drawing.Point(122, 149);
            this.txt_hdn_manv.Name = "txt_hdn_manv";
            this.txt_hdn_manv.Size = new System.Drawing.Size(266, 20);
            this.txt_hdn_manv.TabIndex = 3;
            this.txt_hdn_manv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_hdn_ngay
            // 
            this.txt_hdn_ngay.Location = new System.Drawing.Point(122, 179);
            this.txt_hdn_ngay.Name = "txt_hdn_ngay";
            this.txt_hdn_ngay.Size = new System.Drawing.Size(266, 20);
            this.txt_hdn_ngay.TabIndex = 3;
            // 
            // txt_hdn_mancc
            // 
            this.txt_hdn_mancc.Location = new System.Drawing.Point(488, 149);
            this.txt_hdn_mancc.Name = "txt_hdn_mancc";
            this.txt_hdn_mancc.Size = new System.Drawing.Size(150, 20);
            this.txt_hdn_mancc.TabIndex = 3;
            // 
            // txt_hdn_ma
            // 
            this.txt_hdn_ma.Location = new System.Drawing.Point(122, 122);
            this.txt_hdn_ma.Name = "txt_hdn_ma";
            this.txt_hdn_ma.Size = new System.Drawing.Size(266, 20);
            this.txt_hdn_ma.TabIndex = 3;
            // 
            // txt_hdn_tien
            // 
            this.txt_hdn_tien.Location = new System.Drawing.Point(488, 182);
            this.txt_hdn_tien.Name = "txt_hdn_tien";
            this.txt_hdn_tien.Size = new System.Drawing.Size(150, 20);
            this.txt_hdn_tien.TabIndex = 3;
            // 
            // HDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 414);
            this.Controls.Add(this.txt_hdn_ma);
            this.Controls.Add(this.txt_hdn_tien);
            this.Controls.Add(this.txt_hdn_mancc);
            this.Controls.Add(this.txt_hdn_ngay);
            this.Controls.Add(this.txt_hdn_manv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "HDN";
            this.Text = "HDN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_hdn_manv;
        private System.Windows.Forms.TextBox txt_hdn_ngay;
        private System.Windows.Forms.TextBox txt_hdn_mancc;
        private System.Windows.Forms.TextBox txt_hdn_ma;
        private System.Windows.Forms.TextBox txt_hdn_tien;
    }
}