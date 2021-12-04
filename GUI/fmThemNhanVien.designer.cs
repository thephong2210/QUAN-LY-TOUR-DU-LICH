
namespace GUI
{
    partial class fmThemNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxNhiemVu = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên nhân viên";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(146, 14);
            this.textBoxTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(212, 30);
            this.textBoxTenNhanVien.TabIndex = 1;
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.buttonTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaoMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonTaoMoi.ForeColor = System.Drawing.Color.White;
            this.buttonTaoMoi.Location = new System.Drawing.Point(107, 314);
            this.buttonTaoMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(152, 62);
            this.buttonTaoMoi.TabIndex = 8;
            this.buttonTaoMoi.Text = "Tạo mới";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.buttonTaoMoi_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.textBoxTenNhanVien);
            this.panel8.Location = new System.Drawing.Point(11, 111);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(371, 57);
            this.panel8.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nhiệm vụ";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 433);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.buttonTaoMoi);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 648);
            this.panel4.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(0, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(388, 58);
            this.panel10.TabIndex = 35;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.pictureBox4.Location = new System.Drawing.Point(33, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tạo mới nhân viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBoxNhiemVu);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(11, 200);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(371, 65);
            this.panel9.TabIndex = 34;
            // 
            // textBoxNhiemVu
            // 
            this.textBoxNhiemVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNhiemVu.Location = new System.Drawing.Point(146, 13);
            this.textBoxNhiemVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNhiemVu.Name = "textBoxNhiemVu";
            this.textBoxNhiemVu.Size = new System.Drawing.Size(212, 30);
            this.textBoxNhiemVu.TabIndex = 18;
            // 
            // fmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 433);
            this.Controls.Add(this.panel2);
            this.Name = "fmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên | Tour App";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNhiemVu;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}