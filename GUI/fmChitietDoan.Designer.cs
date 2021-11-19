
namespace GUI
{
    partial class fmChitietDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._chitietLb = new System.Windows.Forms.Label();
            this._returnDateLb = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this._departDateLb = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this._tourNameLb = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this._tourGroupNameLb = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._tableCell_Three = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this._employeeDeleteBtn = new System.Windows.Forms.Button();
            this._employeeDetailBtn = new System.Windows.Forms.Button();
            this._employeeDgv = new System.Windows.Forms.DataGridView();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tableCell_One = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._customerDeleteBtn = new System.Windows.Forms.Button();
            this._customerDetail = new System.Windows.Forms.Button();
            this._passengerDgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._tableCell_Three.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._employeeDgv)).BeginInit();
            this._tableCell_One.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._passengerDgv)).BeginInit();
            this.SuspendLayout();
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
            this.panel7.Size = new System.Drawing.Size(1139, 54);
            this.panel7.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox3.Location = new System.Drawing.Point(439, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(491, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.MaximumSize = new System.Drawing.Size(180, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "Chi tiết đoàn";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this._chitietLb);
            this.panel13.Controls.Add(this._returnDateLb);
            this.panel13.Controls.Add(this.label24);
            this.panel13.Controls.Add(this._departDateLb);
            this.panel13.Controls.Add(this.label22);
            this.panel13.Controls.Add(this._tourNameLb);
            this.panel13.Controls.Add(this.label20);
            this.panel13.Controls.Add(this._tourGroupNameLb);
            this.panel13.Controls.Add(this.label15);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 54);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.panel13.Size = new System.Drawing.Size(1139, 164);
            this.panel13.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chi tiết:";
            // 
            // _chitietLb
            // 
            this._chitietLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._chitietLb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this._chitietLb.Location = new System.Drawing.Point(114, 96);
            this._chitietLb.Name = "_chitietLb";
            this._chitietLb.Size = new System.Drawing.Size(1013, 68);
            this._chitietLb.TabIndex = 8;
            this._chitietLb.Text = "...";
            // 
            // _returnDateLb
            // 
            this._returnDateLb.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._returnDateLb.Location = new System.Drawing.Point(762, 72);
            this._returnDateLb.Name = "_returnDateLb";
            this._returnDateLb.Size = new System.Drawing.Size(365, 24);
            this._returnDateLb.TabIndex = 7;
            this._returnDateLb.Text = "...";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(617, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 28);
            this.label24.TabIndex = 6;
            this.label24.Text = "Ngày kết thúc:";
            // 
            // _departDateLb
            // 
            this._departDateLb.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._departDateLb.Location = new System.Drawing.Point(762, 21);
            this._departDateLb.Name = "_departDateLb";
            this._departDateLb.Size = new System.Drawing.Size(360, 26);
            this._departDateLb.TabIndex = 5;
            this._departDateLb.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(617, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(139, 28);
            this.label22.TabIndex = 4;
            this.label22.Text = "Ngày bắt đầu:";
            // 
            // _tourNameLb
            // 
            this._tourNameLb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this._tourNameLb.Location = new System.Drawing.Point(114, 60);
            this._tourNameLb.Name = "_tourNameLb";
            this._tourNameLb.Size = new System.Drawing.Size(466, 26);
            this._tourNameLb.TabIndex = 3;
            this._tourNameLb.Text = "...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(14, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 28);
            this.label20.TabIndex = 2;
            this.label20.Text = "Tên tour:";
            // 
            // _tourGroupNameLb
            // 
            this._tourGroupNameLb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this._tourGroupNameLb.Location = new System.Drawing.Point(114, 19);
            this._tourGroupNameLb.Name = "_tourGroupNameLb";
            this._tourGroupNameLb.Size = new System.Drawing.Size(466, 27);
            this._tourGroupNameLb.TabIndex = 1;
            this._tourGroupNameLb.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(12, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tên đoàn:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._tableCell_Three, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._tableCell_One, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 218);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 360);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // _tableCell_Three
            // 
            this._tableCell_Three.Controls.Add(this.flowLayoutPanel3);
            this._tableCell_Three.Controls.Add(this._employeeDgv);
            this._tableCell_Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableCell_Three.Font = new System.Drawing.Font("Constantia", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tableCell_Three.Location = new System.Drawing.Point(572, 2);
            this._tableCell_Three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._tableCell_Three.Name = "_tableCell_Three";
            this._tableCell_Three.Padding = new System.Windows.Forms.Padding(14, 13, 14, 0);
            this._tableCell_Three.Size = new System.Drawing.Size(564, 356);
            this._tableCell_Three.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.flowLayoutPanel3.Controls.Add(this._employeeDeleteBtn);
            this.flowLayoutPanel3.Controls.Add(this._employeeDetailBtn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(14, 310);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(536, 46);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // _employeeDeleteBtn
            // 
            this._employeeDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._employeeDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._employeeDeleteBtn.FlatAppearance.BorderSize = 3;
            this._employeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._employeeDeleteBtn.Font = new System.Drawing.Font("Constantia", 10.25F);
            this._employeeDeleteBtn.ForeColor = System.Drawing.Color.White;
            this._employeeDeleteBtn.Location = new System.Drawing.Point(469, 5);
            this._employeeDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._employeeDeleteBtn.Name = "_employeeDeleteBtn";
            this._employeeDeleteBtn.Size = new System.Drawing.Size(64, 38);
            this._employeeDeleteBtn.TabIndex = 10;
            this._employeeDeleteBtn.Text = "Xóa";
            this._employeeDeleteBtn.UseVisualStyleBackColor = false;
            this._employeeDeleteBtn.Click += new System.EventHandler(this._employeeDeleteBtn_Click);
            // 
            // _employeeDetailBtn
            // 
            this._employeeDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._employeeDetailBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._employeeDetailBtn.FlatAppearance.BorderSize = 3;
            this._employeeDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._employeeDetailBtn.Font = new System.Drawing.Font("Constantia", 10.25F);
            this._employeeDetailBtn.ForeColor = System.Drawing.Color.White;
            this._employeeDetailBtn.Location = new System.Drawing.Point(398, 6);
            this._employeeDetailBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._employeeDetailBtn.Name = "_employeeDetailBtn";
            this._employeeDetailBtn.Size = new System.Drawing.Size(64, 37);
            this._employeeDetailBtn.TabIndex = 11;
            this._employeeDetailBtn.Text = "Edit";
            this._employeeDetailBtn.UseVisualStyleBackColor = false;
            this._employeeDetailBtn.Click += new System.EventHandler(this._employeeDetailBtn_Click);
            // 
            // _employeeDgv
            // 
            this._employeeDgv.AllowUserToAddRows = false;
            this._employeeDgv.AllowUserToDeleteRows = false;
            this._employeeDgv.AllowUserToResizeColumns = false;
            this._employeeDgv.AllowUserToResizeRows = false;
            this._employeeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._employeeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNV,
            this.tenNV});
            this._employeeDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._employeeDgv.Location = new System.Drawing.Point(14, 13);
            this._employeeDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._employeeDgv.Name = "_employeeDgv";
            this._employeeDgv.ReadOnly = true;
            this._employeeDgv.RowHeadersVisible = false;
            this._employeeDgv.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this._employeeDgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this._employeeDgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._employeeDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this._employeeDgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.25F);
            this._employeeDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._employeeDgv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this._employeeDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this._employeeDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._employeeDgv.RowTemplate.Height = 32;
            this._employeeDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._employeeDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._employeeDgv.Size = new System.Drawing.Size(536, 343);
            this._employeeDgv.TabIndex = 9;
            // 
            // IDNV
            // 
            this.IDNV.DataPropertyName = "id";
            this.IDNV.FillWeight = 10F;
            this.IDNV.HeaderText = "ID";
            this.IDNV.MinimumWidth = 8;
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "ten";
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.MinimumWidth = 8;
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            // 
            // _tableCell_One
            // 
            this._tableCell_One.Controls.Add(this.flowLayoutPanel1);
            this._tableCell_One.Controls.Add(this._passengerDgv);
            this._tableCell_One.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableCell_One.Font = new System.Drawing.Font("Constantia", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tableCell_One.Location = new System.Drawing.Point(3, 2);
            this._tableCell_One.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._tableCell_One.Name = "_tableCell_One";
            this._tableCell_One.Padding = new System.Windows.Forms.Padding(14, 13, 14, 0);
            this._tableCell_One.Size = new System.Drawing.Size(563, 356);
            this._tableCell_One.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.flowLayoutPanel1.Controls.Add(this._customerDeleteBtn);
            this.flowLayoutPanel1.Controls.Add(this._customerDetail);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 310);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 46);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // _customerDeleteBtn
            // 
            this._customerDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._customerDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._customerDeleteBtn.FlatAppearance.BorderSize = 3;
            this._customerDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._customerDeleteBtn.Font = new System.Drawing.Font("Constantia", 11.25F);
            this._customerDeleteBtn.ForeColor = System.Drawing.Color.White;
            this._customerDeleteBtn.Location = new System.Drawing.Point(467, 6);
            this._customerDeleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._customerDeleteBtn.Name = "_customerDeleteBtn";
            this._customerDeleteBtn.Size = new System.Drawing.Size(64, 37);
            this._customerDeleteBtn.TabIndex = 6;
            this._customerDeleteBtn.Text = "Xóa";
            this._customerDeleteBtn.UseVisualStyleBackColor = false;
            this._customerDeleteBtn.Click += new System.EventHandler(this._customerDeleteBtn_Click);
            // 
            // _customerDetail
            // 
            this._customerDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._customerDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._customerDetail.FlatAppearance.BorderSize = 3;
            this._customerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._customerDetail.Font = new System.Drawing.Font("Constantia", 10.25F);
            this._customerDetail.ForeColor = System.Drawing.Color.White;
            this._customerDetail.Location = new System.Drawing.Point(395, 6);
            this._customerDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._customerDetail.Name = "_customerDetail";
            this._customerDetail.Size = new System.Drawing.Size(64, 37);
            this._customerDetail.TabIndex = 7;
            this._customerDetail.Text = "Edit";
            this._customerDetail.UseVisualStyleBackColor = false;
            this._customerDetail.Click += new System.EventHandler(this._customerDetail_Click);
            // 
            // _passengerDgv
            // 
            this._passengerDgv.AllowUserToAddRows = false;
            this._passengerDgv.AllowUserToDeleteRows = false;
            this._passengerDgv.AllowUserToResizeColumns = false;
            this._passengerDgv.AllowUserToResizeRows = false;
            this._passengerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._passengerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._passengerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tên});
            this._passengerDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerDgv.Location = new System.Drawing.Point(14, 13);
            this._passengerDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._passengerDgv.Name = "_passengerDgv";
            this._passengerDgv.ReadOnly = true;
            this._passengerDgv.RowHeadersVisible = false;
            this._passengerDgv.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this._passengerDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._passengerDgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._passengerDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this._passengerDgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passengerDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._passengerDgv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this._passengerDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this._passengerDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._passengerDgv.RowTemplate.Height = 32;
            this._passengerDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._passengerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._passengerDgv.Size = new System.Drawing.Size(535, 343);
            this._passengerDgv.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 3;
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Tên
            // 
            this.Tên.DataPropertyName = "ten";
            this.Tên.HeaderText = "Tên Khách Hàng";
            this.Tên.MinimumWidth = 8;
            this.Tên.Name = "Tên";
            this.Tên.ReadOnly = true;
            // 
            // fmChitietDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1157, 625);
            this.Name = "fmChitietDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đoàn | Tour App";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._tableCell_Three.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._employeeDgv)).EndInit();
            this._tableCell_One.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._passengerDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label _returnDateLb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label _departDateLb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label _tourNameLb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label _tourGroupNameLb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _tableCell_Three;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button _employeeDeleteBtn;
        private System.Windows.Forms.Button _employeeDetailBtn;
        private System.Windows.Forms.DataGridView _employeeDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.Panel _tableCell_One;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _customerDeleteBtn;
        private System.Windows.Forms.Button _customerDetail;
        private System.Windows.Forms.DataGridView _passengerDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _chitietLb;
    }
}