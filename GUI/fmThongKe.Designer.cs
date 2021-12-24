
namespace GUI
{
    partial class fmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDoanhSoMoi_DoanhThu = new System.Windows.Forms.Label();
            this.labelThongKeDoanhThu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDoanhSoMoi_Tour = new System.Windows.Forms.Label();
            this.labelThongKeTour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDoanhSoMoi_Doan = new System.Windows.Forms.Label();
            this.labelThongKeDoanDuLich = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDoanhSoMoi_NhanVien = new System.Windows.Forms.Label();
            this.labelThongKeNhanVien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1439, 54);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::GUI.Properties.Resources.touricon;
            this.pictureBox1.Image = global::GUI.Properties.Resources.travel;
            this.pictureBox1.Location = new System.Drawing.Point(561, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(624, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doanh thu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labelDoanhSoMoi_DoanhThu);
            this.panel1.Controls.Add(this.labelThongKeDoanhThu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 141);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelDoanhSoMoi_DoanhThu
            // 
            this.labelDoanhSoMoi_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_DoanhThu.ForeColor = System.Drawing.Color.Lime;
            this.labelDoanhSoMoi_DoanhThu.Location = new System.Drawing.Point(60, 93);
            this.labelDoanhSoMoi_DoanhThu.Name = "labelDoanhSoMoi_DoanhThu";
            this.labelDoanhSoMoi_DoanhThu.Size = new System.Drawing.Size(150, 39);
            this.labelDoanhSoMoi_DoanhThu.TabIndex = 7;
            this.labelDoanhSoMoi_DoanhThu.Text = "1";
            this.labelDoanhSoMoi_DoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeDoanhThu
            // 
            this.labelThongKeDoanhThu.CausesValidation = false;
            this.labelThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanhThu.Location = new System.Drawing.Point(43, 54);
            this.labelThongKeDoanhThu.Name = "labelThongKeDoanhThu";
            this.labelThongKeDoanhThu.Size = new System.Drawing.Size(200, 39);
            this.labelThongKeDoanhThu.TabIndex = 3;
            this.labelThongKeDoanhThu.Text = "1.000000 đ";
            this.labelThongKeDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThongKeDoanhThu.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.labelDoanhSoMoi_Tour);
            this.panel2.Controls.Add(this.labelThongKeTour);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(392, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 141);
            this.panel2.TabIndex = 4;
            // 
            // labelDoanhSoMoi_Tour
            // 
            this.labelDoanhSoMoi_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_Tour.ForeColor = System.Drawing.Color.Lime;
            this.labelDoanhSoMoi_Tour.Location = new System.Drawing.Point(85, 93);
            this.labelDoanhSoMoi_Tour.Name = "labelDoanhSoMoi_Tour";
            this.labelDoanhSoMoi_Tour.Size = new System.Drawing.Size(100, 39);
            this.labelDoanhSoMoi_Tour.TabIndex = 4;
            this.labelDoanhSoMoi_Tour.Text = "1";
            this.labelDoanhSoMoi_Tour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeTour
            // 
            this.labelThongKeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeTour.Location = new System.Drawing.Point(83, 54);
            this.labelThongKeTour.Name = "labelThongKeTour";
            this.labelThongKeTour.Size = new System.Drawing.Size(100, 39);
            this.labelThongKeTour.TabIndex = 3;
            this.labelThongKeTour.Text = "1";
            this.labelThongKeTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThongKeTour.Click += new System.EventHandler(this.labelThongKeTour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(110, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tour";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.labelDoanhSoMoi_Doan);
            this.panel3.Controls.Add(this.labelThongKeDoanDuLich);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(731, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 141);
            this.panel3.TabIndex = 4;
            // 
            // labelDoanhSoMoi_Doan
            // 
            this.labelDoanhSoMoi_Doan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_Doan.ForeColor = System.Drawing.Color.Lime;
            this.labelDoanhSoMoi_Doan.Location = new System.Drawing.Point(93, 93);
            this.labelDoanhSoMoi_Doan.Name = "labelDoanhSoMoi_Doan";
            this.labelDoanhSoMoi_Doan.Size = new System.Drawing.Size(100, 39);
            this.labelDoanhSoMoi_Doan.TabIndex = 5;
            this.labelDoanhSoMoi_Doan.Text = "1";
            this.labelDoanhSoMoi_Doan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeDoanDuLich
            // 
            this.labelThongKeDoanDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanDuLich.Location = new System.Drawing.Point(91, 54);
            this.labelThongKeDoanDuLich.Name = "labelThongKeDoanDuLich";
            this.labelThongKeDoanDuLich.Size = new System.Drawing.Size(100, 39);
            this.labelThongKeDoanDuLich.TabIndex = 3;
            this.labelThongKeDoanDuLich.Text = "1";
            this.labelThongKeDoanDuLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(79, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đoàn du lịch";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.labelDoanhSoMoi_NhanVien);
            this.panel4.Controls.Add(this.labelThongKeNhanVien);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1066, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 141);
            this.panel4.TabIndex = 4;
            // 
            // labelDoanhSoMoi_NhanVien
            // 
            this.labelDoanhSoMoi_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_NhanVien.ForeColor = System.Drawing.Color.Lime;
            this.labelDoanhSoMoi_NhanVien.Location = new System.Drawing.Point(94, 93);
            this.labelDoanhSoMoi_NhanVien.Name = "labelDoanhSoMoi_NhanVien";
            this.labelDoanhSoMoi_NhanVien.Size = new System.Drawing.Size(100, 39);
            this.labelDoanhSoMoi_NhanVien.TabIndex = 6;
            this.labelDoanhSoMoi_NhanVien.Text = "1";
            this.labelDoanhSoMoi_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeNhanVien
            // 
            this.labelThongKeNhanVien.AutoEllipsis = true;
            this.labelThongKeNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeNhanVien.Location = new System.Drawing.Point(92, 54);
            this.labelThongKeNhanVien.Name = "labelThongKeNhanVien";
            this.labelThongKeNhanVien.Size = new System.Drawing.Size(100, 39);
            this.labelThongKeNhanVien.TabIndex = 3;
            this.labelThongKeNhanVien.Text = "1";
            this.labelThongKeNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThongKeNhanVien.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(84, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhân viên";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 351);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(620, 382);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(50, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(620, 63);
            this.panel6.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label11.Location = new System.Drawing.Point(20, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Biều đồ doanh thu theo tháng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(731, 282);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(613, 63);
            this.panel7.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(20, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel8.Location = new System.Drawing.Point(731, 351);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(613, 382);
            this.panel8.TabIndex = 6;
            // 
            // fmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1394, 791);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "fmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmThongKe";
            this.Load += new System.EventHandler(this.fmThongKe_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelThongKeDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelThongKeTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelThongKeDoanDuLich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelThongKeNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelDoanhSoMoi_DoanhThu;
        private System.Windows.Forms.Label labelDoanhSoMoi_Tour;
        private System.Windows.Forms.Label labelDoanhSoMoi_Doan;
        private System.Windows.Forms.Label labelDoanhSoMoi_NhanVien;
    }
}