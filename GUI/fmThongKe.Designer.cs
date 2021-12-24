
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
            this.labelThongKeKhachHang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartDoanhThuTheoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewTopTourDangKyNhieu = new System.Windows.Forms.DataGridView();
            this.maSoTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTopNhanVienThamGia = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanThamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTopTourDoanhThu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopTourDangKyNhieu)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopNhanVienThamGia)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopTourDoanhThu)).BeginInit();
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
            this.pictureBox1.Image = global::GUI.Properties.Resources.analytics;
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
            this.labelDoanhSoMoi_DoanhThu.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelDoanhSoMoi_DoanhThu.Location = new System.Drawing.Point(0, 93);
            this.labelDoanhSoMoi_DoanhThu.Name = "labelDoanhSoMoi_DoanhThu";
            this.labelDoanhSoMoi_DoanhThu.Size = new System.Drawing.Size(278, 39);
            this.labelDoanhSoMoi_DoanhThu.TabIndex = 7;
            this.labelDoanhSoMoi_DoanhThu.Text = "1";
            this.labelDoanhSoMoi_DoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeDoanhThu
            // 
            this.labelThongKeDoanhThu.CausesValidation = false;
            this.labelThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanhThu.Location = new System.Drawing.Point(5, 54);
            this.labelThongKeDoanhThu.Name = "labelThongKeDoanhThu";
            this.labelThongKeDoanhThu.Size = new System.Drawing.Size(270, 39);
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
            this.panel2.Location = new System.Drawing.Point(402, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 141);
            this.panel2.TabIndex = 4;
            // 
            // labelDoanhSoMoi_Tour
            // 
            this.labelDoanhSoMoi_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_Tour.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelDoanhSoMoi_Tour.Location = new System.Drawing.Point(3, 93);
            this.labelDoanhSoMoi_Tour.Name = "labelDoanhSoMoi_Tour";
            this.labelDoanhSoMoi_Tour.Size = new System.Drawing.Size(272, 39);
            this.labelDoanhSoMoi_Tour.TabIndex = 4;
            this.labelDoanhSoMoi_Tour.Text = "1";
            this.labelDoanhSoMoi_Tour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeTour
            // 
            this.labelThongKeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeTour.Location = new System.Drawing.Point(0, 54);
            this.labelThongKeTour.Name = "labelThongKeTour";
            this.labelThongKeTour.Size = new System.Drawing.Size(278, 39);
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
            this.label5.Location = new System.Drawing.Point(105, 19);
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
            this.panel3.Location = new System.Drawing.Point(758, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 141);
            this.panel3.TabIndex = 4;
            // 
            // labelDoanhSoMoi_Doan
            // 
            this.labelDoanhSoMoi_Doan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoanhSoMoi_Doan.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelDoanhSoMoi_Doan.Location = new System.Drawing.Point(0, 93);
            this.labelDoanhSoMoi_Doan.Name = "labelDoanhSoMoi_Doan";
            this.labelDoanhSoMoi_Doan.Size = new System.Drawing.Size(278, 39);
            this.labelDoanhSoMoi_Doan.TabIndex = 5;
            this.labelDoanhSoMoi_Doan.Text = "1";
            this.labelDoanhSoMoi_Doan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThongKeDoanDuLich
            // 
            this.labelThongKeDoanDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanDuLich.Location = new System.Drawing.Point(0, 54);
            this.labelThongKeDoanDuLich.Name = "labelThongKeDoanDuLich";
            this.labelThongKeDoanDuLich.Size = new System.Drawing.Size(278, 39);
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
            this.panel4.Controls.Add(this.labelThongKeKhachHang);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1086, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 141);
            this.panel4.TabIndex = 4;
            // 
            // labelThongKeKhachHang
            // 
            this.labelThongKeKhachHang.AutoEllipsis = true;
            this.labelThongKeKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeKhachHang.Location = new System.Drawing.Point(0, 54);
            this.labelThongKeKhachHang.Name = "labelThongKeKhachHang";
            this.labelThongKeKhachHang.Size = new System.Drawing.Size(275, 39);
            this.labelThongKeKhachHang.TabIndex = 3;
            this.labelThongKeKhachHang.Text = "1";
            this.labelThongKeKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThongKeKhachHang.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(80, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Khách hàng";
            // 
            // chartDoanhThuTheoThang
            // 
            this.chartDoanhThuTheoThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThuTheoThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThuTheoThang.Legends.Add(legend1);
            this.chartDoanhThuTheoThang.Location = new System.Drawing.Point(50, 330);
            this.chartDoanhThuTheoThang.Name = "chartDoanhThuTheoThang";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "{0:n0}";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.YValuesPerPoint = 4;
            this.chartDoanhThuTheoThang.Series.Add(series1);
            this.chartDoanhThuTheoThang.Size = new System.Drawing.Size(899, 347);
            this.chartDoanhThuTheoThang.TabIndex = 5;
            this.chartDoanhThuTheoThang.Text = "chartDoanhThuTheoThang";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(50, 261);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(899, 54);
            this.panel6.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label11.Location = new System.Drawing.Point(20, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(412, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Biểu đồ doanh thu theo tháng - năm 2021";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridViewTopTourDangKyNhieu
            // 
            this.dataGridViewTopTourDangKyNhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTopTourDangKyNhieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopTourDangKyNhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopTourDangKyNhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoTour,
            this.tenTour,
            this.soLuongDoan,
            this.soLuongKH});
            this.dataGridViewTopTourDangKyNhieu.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTopTourDangKyNhieu.Location = new System.Drawing.Point(50, 752);
            this.dataGridViewTopTourDangKyNhieu.Name = "dataGridViewTopTourDangKyNhieu";
            this.dataGridViewTopTourDangKyNhieu.ReadOnly = true;
            this.dataGridViewTopTourDangKyNhieu.RowHeadersWidth = 51;
            this.dataGridViewTopTourDangKyNhieu.RowTemplate.Height = 24;
            this.dataGridViewTopTourDangKyNhieu.Size = new System.Drawing.Size(627, 189);
            this.dataGridViewTopTourDangKyNhieu.TabIndex = 6;
            // 
            // maSoTour
            // 
            this.maSoTour.DataPropertyName = "maSoTour";
            this.maSoTour.HeaderText = "Mã số tour";
            this.maSoTour.MinimumWidth = 6;
            this.maSoTour.Name = "maSoTour";
            this.maSoTour.ReadOnly = true;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.HeaderText = "Tên tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.ReadOnly = true;
            // 
            // soLuongDoan
            // 
            this.soLuongDoan.DataPropertyName = "soLuongDoan";
            this.soLuongDoan.HeaderText = "Số lượng đoàn";
            this.soLuongDoan.MinimumWidth = 6;
            this.soLuongDoan.Name = "soLuongDoan";
            this.soLuongDoan.ReadOnly = true;
            // 
            // soLuongKH
            // 
            this.soLuongKH.DataPropertyName = "soLuongKH";
            this.soLuongKH.HeaderText = "Số lượng khách";
            this.soLuongKH.MinimumWidth = 6;
            this.soLuongKH.Name = "soLuongKH";
            this.soLuongKH.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(50, 692);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 54);
            this.panel7.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top tour đăng ký nhiều nhất";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(707, 692);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(657, 54);
            this.panel8.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Top nhân viên tham gia nhiều nhất";
            // 
            // dataGridViewTopNhanVienThamGia
            // 
            this.dataGridViewTopNhanVienThamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTopNhanVienThamGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopNhanVienThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopNhanVienThamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien,
            this.soLanThamGia});
            this.dataGridViewTopNhanVienThamGia.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTopNhanVienThamGia.Location = new System.Drawing.Point(707, 752);
            this.dataGridViewTopNhanVienThamGia.Name = "dataGridViewTopNhanVienThamGia";
            this.dataGridViewTopNhanVienThamGia.ReadOnly = true;
            this.dataGridViewTopNhanVienThamGia.RowHeadersWidth = 51;
            this.dataGridViewTopNhanVienThamGia.RowTemplate.Height = 24;
            this.dataGridViewTopNhanVienThamGia.Size = new System.Drawing.Size(657, 189);
            this.dataGridViewTopNhanVienThamGia.TabIndex = 8;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            // 
            // soLanThamGia
            // 
            this.soLanThamGia.DataPropertyName = "soLanThamGia";
            this.soLanThamGia.HeaderText = "Số lần tham gia";
            this.soLanThamGia.MinimumWidth = 6;
            this.soLanThamGia.Name = "soLanThamGia";
            this.soLanThamGia.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(968, 261);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(396, 54);
            this.panel9.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Top tour doanh thu cao nhất";
            // 
            // dataGridViewTopTourDoanhThu
            // 
            this.dataGridViewTopTourDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTopTourDoanhThu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopTourDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopTourDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.doanhThu});
            this.dataGridViewTopTourDoanhThu.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTopTourDoanhThu.Location = new System.Drawing.Point(968, 321);
            this.dataGridViewTopTourDoanhThu.Name = "dataGridViewTopTourDoanhThu";
            this.dataGridViewTopTourDoanhThu.ReadOnly = true;
            this.dataGridViewTopTourDoanhThu.RowHeadersWidth = 51;
            this.dataGridViewTopTourDoanhThu.RowTemplate.Height = 24;
            this.dataGridViewTopTourDoanhThu.Size = new System.Drawing.Size(396, 356);
            this.dataGridViewTopTourDoanhThu.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "maSoTour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã số tour";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tenTour";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên tour";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // doanhThu
            // 
            this.doanhThu.HeaderText = "Doanh thu (đ)";
            this.doanhThu.MinimumWidth = 6;
            this.doanhThu.Name = "doanhThu";
            this.doanhThu.ReadOnly = true;
            // 
            // fmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1394, 953);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridViewTopTourDoanhThu);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridViewTopNhanVienThamGia);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dataGridViewTopTourDangKyNhieu);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chartDoanhThuTheoThang);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "fmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê | Tour App";
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
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopTourDangKyNhieu)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopNhanVienThamGia)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopTourDoanhThu)).EndInit();
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
        private System.Windows.Forms.Label labelThongKeKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuTheoThang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelDoanhSoMoi_DoanhThu;
        private System.Windows.Forms.Label labelDoanhSoMoi_Tour;
        private System.Windows.Forms.Label labelDoanhSoMoi_Doan;
        private System.Windows.Forms.DataGridView dataGridViewTopTourDangKyNhieu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongKH;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTopNhanVienThamGia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewTopTourDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanThamGia;
    }
}