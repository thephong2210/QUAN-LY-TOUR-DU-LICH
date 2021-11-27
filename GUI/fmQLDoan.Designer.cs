
namespace GUI
{
    partial class fmQLDoan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewQuanLyDoan = new System.Windows.Forms.DataGridView();
            this.maDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxChiTiet = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTour = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenDoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.46931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.53069F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 830F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1554, 819);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewQuanLyDoan);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(476, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 815);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonXoa);
            this.panel4.Controls.Add(this.buttonXemChiTiet);
            this.panel4.Controls.Add(this.buttonLamMoi);
            this.panel4.Location = new System.Drawing.Point(10, 674);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 125);
            this.panel4.TabIndex = 28;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonXoa.BackColor = System.Drawing.Color.Red;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(875, 20);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(176, 74);
            this.buttonXoa.TabIndex = 27;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXemChiTiet.BackColor = System.Drawing.Color.SlateGray;
            this.buttonXemChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.buttonXemChiTiet.Location = new System.Drawing.Point(4, 21);
            this.buttonXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(182, 74);
            this.buttonXemChiTiet.TabIndex = 25;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = false;
            this.buttonXemChiTiet.Click += new System.EventHandler(this.buttonXemChiTiet_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1098, 66);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_list_50;
            this.pictureBox1.Location = new System.Drawing.Point(358, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đoàn";
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
            this.dataGridViewQuanLyDoan.Location = new System.Drawing.Point(15, 132);
            this.dataGridViewQuanLyDoan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewQuanLyDoan.MultiSelect = false;
            this.dataGridViewQuanLyDoan.Name = "dataGridViewQuanLyDoan";
            this.dataGridViewQuanLyDoan.ReadOnly = true;
            this.dataGridViewQuanLyDoan.RowHeadersWidth = 55;
            this.dataGridViewQuanLyDoan.RowTemplate.DividerHeight = 1;
            this.dataGridViewQuanLyDoan.RowTemplate.Height = 30;
            this.dataGridViewQuanLyDoan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuanLyDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyDoan.Size = new System.Drawing.Size(1049, 529);
            this.dataGridViewQuanLyDoan.TabIndex = 24;
            this.dataGridViewQuanLyDoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyDoan_CellContentClick);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(155, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 35);
            this.textBox1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(37, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.buttonTaoMoi);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 815);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label2);
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(-3, -2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(477, 66);
            this.panel6.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.pictureBox2.Location = new System.Drawing.Point(83, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thêm mới đoàn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.buttonTaoMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonTaoMoi.ForeColor = System.Drawing.Color.White;
            this.buttonTaoMoi.Location = new System.Drawing.Point(133, 694);
            this.buttonTaoMoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(204, 74);
            this.buttonTaoMoi.TabIndex = 45;
            this.buttonTaoMoi.Text = "Tạo mới";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.buttonTaoMoi_Click);
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.Controls.Add(this.label8);
            this.panel14.Controls.Add(this.textBoxChiTiet);
            this.panel14.Location = new System.Drawing.Point(20, 501);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(433, 164);
            this.panel14.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ghi chú";
            // 
            // textBoxChiTiet
            // 
            this.textBoxChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChiTiet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxChiTiet.Location = new System.Drawing.Point(176, 11);
            this.textBoxChiTiet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxChiTiet.Multiline = true;
            this.textBoxChiTiet.Name = "textBoxChiTiet";
            this.textBoxChiTiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChiTiet.Size = new System.Drawing.Size(242, 138);
            this.textBoxChiTiet.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.panel12.Location = new System.Drawing.Point(20, 409);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(433, 88);
            this.panel12.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày kết thúc";
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(176, 11);
            this.dateTimePickerNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(242, 32);
            this.dateTimePickerNgayKetThuc.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.dateTimePickerNgayBatDau);
            this.panel11.Location = new System.Drawing.Point(20, 315);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(433, 89);
            this.panel11.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayBatDau.CustomFormat = "";
            this.dateTimePickerNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(176, 16);
            this.dateTimePickerNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(242, 32);
            this.dateTimePickerNgayBatDau.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.comboBoxTour);
            this.panel9.Location = new System.Drawing.Point(20, 221);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(433, 89);
            this.panel9.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tour";
            // 
            // comboBoxTour
            // 
            this.comboBoxTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTour.DisplayMember = "maSoTour";
            this.comboBoxTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTour.FormattingEnabled = true;
            this.comboBoxTour.Location = new System.Drawing.Point(176, 14);
            this.comboBoxTour.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxTour.Name = "comboBoxTour";
            this.comboBoxTour.Size = new System.Drawing.Size(242, 33);
            this.comboBoxTour.TabIndex = 2;
            this.comboBoxTour.ValueMember = "maSoTour";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.textBoxTenDoan);
            this.panel8.Location = new System.Drawing.Point(20, 130);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(433, 86);
            this.panel8.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên Đoàn";
            // 
            // textBoxTenDoan
            // 
            this.textBoxTenDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTenDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTenDoan.Location = new System.Drawing.Point(176, 18);
            this.textBoxTenDoan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxTenDoan.Name = "textBoxTenDoan";
            this.textBoxTenDoan.Size = new System.Drawing.Size(242, 35);
            this.textBoxTenDoan.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(576, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(461, 61);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quản lý đoàn du lịch";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.baggage;
            this.pictureBox3.Location = new System.Drawing.Point(528, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1554, 90);
            this.panel7.TabIndex = 19;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(240, 21);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(176, 74);
            this.buttonLamMoi.TabIndex = 26;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // fmQLDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 909);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1576, 965);
            this.Name = "fmQLDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đoàn du lịch | Tour App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChiTiet;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyDoan;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenDoan;
        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTiet;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonXemChiTiet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLamMoi;
    }
}