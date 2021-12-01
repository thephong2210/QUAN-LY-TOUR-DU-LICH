
namespace GUI
{
    partial class fmChiTietChiPhi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxChiPhi = new System.Windows.Forms.ListBox();
            this.buttonXoaTatCa = new System.Windows.Forms.Button();
            this.buttonXoaOne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThemDDTQ = new System.Windows.Forms.Button();
            this.textBoxChiPhi = new System.Windows.Forms.TextBox();
            this.buttonDong = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMaSoDoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox1.Location = new System.Drawing.Point(136, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết chi phí";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 51);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.buttonDong);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 398);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.listBoxChiPhi);
            this.panel5.Controls.Add(this.buttonXoaTatCa);
            this.panel5.Controls.Add(this.buttonXoaOne);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.buttonThemDDTQ);
            this.panel5.Controls.Add(this.textBoxChiPhi);
            this.panel5.Location = new System.Drawing.Point(13, 54);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 270);
            this.panel5.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(140, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Định dạng: (tên chi phí);(tổng chi phí)";
            // 
            // listBoxChiPhi
            // 
            this.listBoxChiPhi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.listBoxChiPhi.FormattingEnabled = true;
            this.listBoxChiPhi.ItemHeight = 23;
            this.listBoxChiPhi.Location = new System.Drawing.Point(41, 97);
            this.listBoxChiPhi.Name = "listBoxChiPhi";
            this.listBoxChiPhi.Size = new System.Drawing.Size(455, 119);
            this.listBoxChiPhi.TabIndex = 25;
            // 
            // buttonXoaTatCa
            // 
            this.buttonXoaTatCa.BackColor = System.Drawing.Color.Brown;
            this.buttonXoaTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoaTatCa.ForeColor = System.Drawing.Color.White;
            this.buttonXoaTatCa.Location = new System.Drawing.Point(392, 222);
            this.buttonXoaTatCa.Name = "buttonXoaTatCa";
            this.buttonXoaTatCa.Size = new System.Drawing.Size(104, 32);
            this.buttonXoaTatCa.TabIndex = 24;
            this.buttonXoaTatCa.Text = "Xóa tất cả";
            this.buttonXoaTatCa.UseVisualStyleBackColor = false;
            this.buttonXoaTatCa.Click += new System.EventHandler(this.buttonXoaTatCa_Click);
            // 
            // buttonXoaOne
            // 
            this.buttonXoaOne.BackColor = System.Drawing.Color.Brown;
            this.buttonXoaOne.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoaOne.ForeColor = System.Drawing.Color.White;
            this.buttonXoaOne.Location = new System.Drawing.Point(41, 222);
            this.buttonXoaOne.Name = "buttonXoaOne";
            this.buttonXoaOne.Size = new System.Drawing.Size(97, 32);
            this.buttonXoaOne.TabIndex = 23;
            this.buttonXoaOne.Text = "Xóa";
            this.buttonXoaOne.UseVisualStyleBackColor = false;
            this.buttonXoaOne.Click += new System.EventHandler(this.buttonXoaOne_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chi phí";
            // 
            // buttonThemDDTQ
            // 
            this.buttonThemDDTQ.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonThemDDTQ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonThemDDTQ.ForeColor = System.Drawing.Color.White;
            this.buttonThemDDTQ.Location = new System.Drawing.Point(416, 59);
            this.buttonThemDDTQ.Name = "buttonThemDDTQ";
            this.buttonThemDDTQ.Size = new System.Drawing.Size(80, 32);
            this.buttonThemDDTQ.TabIndex = 21;
            this.buttonThemDDTQ.Text = "Thêm";
            this.buttonThemDDTQ.UseVisualStyleBackColor = false;
            this.buttonThemDDTQ.Click += new System.EventHandler(this.buttonThemDDTQ_Click);
            // 
            // textBoxChiPhi
            // 
            this.textBoxChiPhi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxChiPhi.Location = new System.Drawing.Point(41, 60);
            this.textBoxChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChiPhi.Name = "textBoxChiPhi";
            this.textBoxChiPhi.Size = new System.Drawing.Size(362, 32);
            this.textBoxChiPhi.TabIndex = 20;
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.Gray;
            this.buttonDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonDong.ForeColor = System.Drawing.Color.White;
            this.buttonDong.Location = new System.Drawing.Point(338, 338);
            this.buttonDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(119, 49);
            this.buttonDong.TabIndex = 11;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Orange;
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(98, 338);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(119, 49);
            this.buttonSua.TabIndex = 10;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMaSoDoan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 42);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMaSoDoan
            // 
            this.textBoxMaSoDoan.Enabled = false;
            this.textBoxMaSoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaSoDoan.Location = new System.Drawing.Point(192, 9);
            this.textBoxMaSoDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaSoDoan.Name = "textBoxMaSoDoan";
            this.textBoxMaSoDoan.Size = new System.Drawing.Size(305, 26);
            this.textBoxMaSoDoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số đoàn";
            // 
            // fmChiTietChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(559, 493);
            this.Name = "fmChiTietChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết chi phí | Tour App";
            this.Load += new System.EventHandler(this.fmChiTietChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMaSoDoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxChiPhi;
        private System.Windows.Forms.Button buttonXoaTatCa;
        private System.Windows.Forms.Button buttonXoaOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThemDDTQ;
        private System.Windows.Forms.TextBox textBoxChiPhi;
    }
}