
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelThongKeDoanhThu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelThongKeTour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelThongKeDoanDuLich = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelThongKeNhanVien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhiemVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewQuanLyDoan = new System.Windows.Forms.DataGridView();
            this.maDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewQuanLyTour = new System.Windows.Forms.DataGridView();
            this.maSoTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHinhDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTour)).BeginInit();
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
            this.panel1.Controls.Add(this.labelThongKeDoanhThu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 141);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelThongKeDoanhThu
            // 
            this.labelThongKeDoanhThu.CausesValidation = false;
            this.labelThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanhThu.Location = new System.Drawing.Point(44, 72);
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
            this.panel2.Controls.Add(this.labelThongKeTour);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(392, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 141);
            this.panel2.TabIndex = 4;
            // 
            // labelThongKeTour
            // 
            this.labelThongKeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeTour.Location = new System.Drawing.Point(89, 72);
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
            this.panel3.Controls.Add(this.labelThongKeDoanDuLich);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(731, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 141);
            this.panel3.TabIndex = 4;
            // 
            // labelThongKeDoanDuLich
            // 
            this.labelThongKeDoanDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeDoanDuLich.Location = new System.Drawing.Point(91, 72);
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
            this.label7.Location = new System.Drawing.Point(70, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đoàn du lịch";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.labelThongKeNhanVien);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1066, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 141);
            this.panel4.TabIndex = 4;
            // 
            // labelThongKeNhanVien
            // 
            this.labelThongKeNhanVien.AutoEllipsis = true;
            this.labelThongKeNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelThongKeNhanVien.Location = new System.Drawing.Point(92, 72);
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
            this.label9.Location = new System.Drawing.Point(82, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhân viên";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(50, 351);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
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
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.AllowUserToResizeRows = false;
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewNhanVien.ColumnHeadersHeight = 40;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien,
            this.nhiemVu});
            this.dataGridViewNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNhanVien.Enabled = false;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(1350, 199);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNhanVien.MultiSelect = false;
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.RowHeadersWidth = 55;
            this.dataGridViewNhanVien.RowTemplate.DividerHeight = 1;
            this.dataGridViewNhanVien.RowTemplate.Height = 30;
            this.dataGridViewNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(0, 0);
            this.dataGridViewNhanVien.TabIndex = 23;
            this.dataGridViewNhanVien.TabStop = false;
            this.dataGridViewNhanVien.Visible = false;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.FillWeight = 64.17112F;
            this.maNhanVien.HeaderText = "Mã số nhân viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.FillWeight = 107.1658F;
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nhiemVu
            // 
            this.nhiemVu.DataPropertyName = "nhiemVu";
            this.nhiemVu.FillWeight = 107.1658F;
            this.nhiemVu.HeaderText = "Nhiệm vụ";
            this.nhiemVu.MinimumWidth = 6;
            this.nhiemVu.Name = "nhiemVu";
            this.nhiemVu.ReadOnly = true;
            this.nhiemVu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nhiemVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewQuanLyDoan
            // 
            this.dataGridViewQuanLyDoan.AllowUserToAddRows = false;
            this.dataGridViewQuanLyDoan.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyDoan.AllowUserToResizeRows = false;
            this.dataGridViewQuanLyDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuanLyDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyDoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewQuanLyDoan.ColumnHeadersHeight = 40;
            this.dataGridViewQuanLyDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoan,
            this.tenDoan,
            this.tenTour,
            this.thoiGianBatDau,
            this.thoiGianKetThuc,
            this.chiTiet});
            this.dataGridViewQuanLyDoan.Location = new System.Drawing.Point(845, 238);
            this.dataGridViewQuanLyDoan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewQuanLyDoan.MultiSelect = false;
            this.dataGridViewQuanLyDoan.Name = "dataGridViewQuanLyDoan";
            this.dataGridViewQuanLyDoan.ReadOnly = true;
            this.dataGridViewQuanLyDoan.RowHeadersWidth = 55;
            this.dataGridViewQuanLyDoan.RowTemplate.DividerHeight = 1;
            this.dataGridViewQuanLyDoan.RowTemplate.Height = 30;
            this.dataGridViewQuanLyDoan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuanLyDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyDoan.Size = new System.Drawing.Size(56, 26);
            this.dataGridViewQuanLyDoan.TabIndex = 25;
            this.dataGridViewQuanLyDoan.Visible = false;
            // 
            // maDoan
            // 
            this.maDoan.DataPropertyName = "ID";
            this.maDoan.HeaderText = "Mã đoàn";
            this.maDoan.MinimumWidth = 6;
            this.maDoan.Name = "maDoan";
            this.maDoan.ReadOnly = true;
            // 
            // tenDoan
            // 
            this.tenDoan.DataPropertyName = "tenDoan";
            this.tenDoan.HeaderText = "Tên đoàn";
            this.tenDoan.MinimumWidth = 6;
            this.tenDoan.Name = "tenDoan";
            this.tenDoan.ReadOnly = true;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.HeaderText = "Tên tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.ReadOnly = true;
            // 
            // thoiGianBatDau
            // 
            this.thoiGianBatDau.DataPropertyName = "thoiGianKhoiHanh";
            this.thoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.thoiGianBatDau.MinimumWidth = 6;
            this.thoiGianBatDau.Name = "thoiGianBatDau";
            this.thoiGianBatDau.ReadOnly = true;
            // 
            // thoiGianKetThuc
            // 
            this.thoiGianKetThuc.DataPropertyName = "thoiGianKetThuc";
            this.thoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.thoiGianKetThuc.MinimumWidth = 6;
            this.thoiGianKetThuc.Name = "thoiGianKetThuc";
            this.thoiGianKetThuc.ReadOnly = true;
            // 
            // chiTiet
            // 
            this.chiTiet.DataPropertyName = "chitiet";
            this.chiTiet.HeaderText = "Ghi chú";
            this.chiTiet.MinimumWidth = 6;
            this.chiTiet.Name = "chiTiet";
            this.chiTiet.ReadOnly = true;
            // 
            // dataGridViewQuanLyTour
            // 
            this.dataGridViewQuanLyTour.AllowUserToAddRows = false;
            this.dataGridViewQuanLyTour.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyTour.AllowUserToResizeRows = false;
            this.dataGridViewQuanLyTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyTour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewQuanLyTour.ColumnHeadersHeight = 40;
            this.dataGridViewQuanLyTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoTour,
            this.tenGoiTour,
            this.tenLoaiHinhDuLich,
            this.tenDiaDiem,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewQuanLyTour.Location = new System.Drawing.Point(506, 238);
            this.dataGridViewQuanLyTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewQuanLyTour.MultiSelect = false;
            this.dataGridViewQuanLyTour.Name = "dataGridViewQuanLyTour";
            this.dataGridViewQuanLyTour.ReadOnly = true;
            this.dataGridViewQuanLyTour.RowHeadersWidth = 55;
            this.dataGridViewQuanLyTour.RowTemplate.DividerHeight = 1;
            this.dataGridViewQuanLyTour.RowTemplate.Height = 30;
            this.dataGridViewQuanLyTour.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuanLyTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyTour.Size = new System.Drawing.Size(51, 26);
            this.dataGridViewQuanLyTour.TabIndex = 26;
            this.dataGridViewQuanLyTour.Visible = false;
            // 
            // maSoTour
            // 
            this.maSoTour.DataPropertyName = "maSoTour";
            this.maSoTour.FillWeight = 64.17112F;
            this.maSoTour.HeaderText = "Mã số tour";
            this.maSoTour.MinimumWidth = 6;
            this.maSoTour.Name = "maSoTour";
            this.maSoTour.ReadOnly = true;
            this.maSoTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenGoiTour
            // 
            this.tenGoiTour.DataPropertyName = "tenGoiTour";
            this.tenGoiTour.FillWeight = 107.1658F;
            this.tenGoiTour.HeaderText = "Tên tour";
            this.tenGoiTour.MinimumWidth = 6;
            this.tenGoiTour.Name = "tenGoiTour";
            this.tenGoiTour.ReadOnly = true;
            this.tenGoiTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenGoiTour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tenLoaiHinhDuLich
            // 
            this.tenLoaiHinhDuLich.DataPropertyName = "tenLoaiHinhDuLich";
            this.tenLoaiHinhDuLich.FillWeight = 107.1658F;
            this.tenLoaiHinhDuLich.HeaderText = "Tên loại hình du lịch";
            this.tenLoaiHinhDuLich.MinimumWidth = 6;
            this.tenLoaiHinhDuLich.Name = "tenLoaiHinhDuLich";
            this.tenLoaiHinhDuLich.ReadOnly = true;
            this.tenLoaiHinhDuLich.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenLoaiHinhDuLich.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tenDiaDiem
            // 
            this.tenDiaDiem.DataPropertyName = "tenDiaDiem";
            this.tenDiaDiem.FillWeight = 107.1658F;
            this.tenDiaDiem.HeaderText = "Tên địa điểm đến";
            this.tenDiaDiem.MinimumWidth = 6;
            this.tenDiaDiem.Name = "tenDiaDiem";
            this.tenDiaDiem.ReadOnly = true;
            this.tenDiaDiem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenDiaDiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "thoiGianBatDau";
            this.dataGridViewTextBoxColumn1.FillWeight = 107.1658F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Thời gian bắt đầu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "thoiGianKetThuc";
            this.dataGridViewTextBoxColumn2.FillWeight = 107.1658F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Thời gian kết thúc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1394, 791);
            this.Controls.Add(this.dataGridViewQuanLyTour);
            this.Controls.Add(this.dataGridViewQuanLyDoan);
            this.Controls.Add(this.dataGridViewNhanVien);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTour)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhiemVu;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTiet;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHinhDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}