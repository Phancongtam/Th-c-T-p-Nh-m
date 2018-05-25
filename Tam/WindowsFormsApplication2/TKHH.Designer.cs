namespace WindowsFormsApplication2
{
    partial class TKHH
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
            this.txt_thongtin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rd_sr_tensp = new System.Windows.Forms.RadioButton();
            this.rd_sr_masp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_thongtin
            // 
            this.txt_thongtin.Location = new System.Drawing.Point(72, 46);
            this.txt_thongtin.Name = "txt_thongtin";
            this.txt_thongtin.Size = new System.Drawing.Size(422, 20);
            this.txt_thongtin.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // rd_sr_tensp
            // 
            this.rd_sr_tensp.AutoSize = true;
            this.rd_sr_tensp.Location = new System.Drawing.Point(182, 81);
            this.rd_sr_tensp.Name = "rd_sr_tensp";
            this.rd_sr_tensp.Size = new System.Drawing.Size(96, 17);
            this.rd_sr_tensp.TabIndex = 2;
            this.rd_sr_tensp.TabStop = true;
            this.rd_sr_tensp.Text = "Tên Sản Phẩm";
            this.rd_sr_tensp.UseVisualStyleBackColor = true;
            // 
            // rd_sr_masp
            // 
            this.rd_sr_masp.AutoSize = true;
            this.rd_sr_masp.Location = new System.Drawing.Point(72, 81);
            this.rd_sr_masp.Name = "rd_sr_masp";
            this.rd_sr_masp.Size = new System.Drawing.Size(92, 17);
            this.rd_sr_masp.TabIndex = 3;
            this.rd_sr_masp.TabStop = true;
            this.rd_sr_masp.Text = "Mã Sản Phẩm";
            this.rd_sr_masp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TKHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_sr_masp);
            this.Controls.Add(this.rd_sr_tensp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_thongtin);
            this.Name = "TKHH";
            this.Text = "TKHH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_thongtin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rd_sr_tensp;
        private System.Windows.Forms.RadioButton rd_sr_masp;
        private System.Windows.Forms.Button button1;
    }
}