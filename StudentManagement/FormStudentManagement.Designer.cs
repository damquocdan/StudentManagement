namespace StudentManagement
{
    partial class FormStudentManagement
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taikhoanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangkymonhocClassHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiemThanhPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiemThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 341);
            this.pnlContent.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.chucNangToolStripMenuItem,
            this.danhSachTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.taikhoanToolStripMenuItem1,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            this.trangChuToolStripMenuItem.Click += new System.EventHandler(this.trangChuToolStripMenuItem_Click);
            // 
            // taikhoanToolStripMenuItem1
            // 
            this.taikhoanToolStripMenuItem1.Name = "taikhoanToolStripMenuItem1";
            this.taikhoanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.taikhoanToolStripMenuItem1.Text = "Tài khoản";
            this.taikhoanToolStripMenuItem1.Click += new System.EventHandler(this.taikhoanToolStripMenuItem1_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click_1);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myClassToolStripMenuItem,
            this.sinhVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.giaoVienToolStripMenuItem1,
            this.lopHocToolStripMenuItem});
            this.quanLyToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // myClassToolStripMenuItem
            // 
            this.myClassToolStripMenuItem.Name = "myClassToolStripMenuItem";
            this.myClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myClassToolStripMenuItem.Text = "Lớp học của tôi";
            this.myClassToolStripMenuItem.Click += new System.EventHandler(this.myClassToolStripMenuItem_Click);
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinhVienToolStripMenuItem.Text = "Sinh viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click_1);
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monHocToolStripMenuItem.Text = "Môn học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click_1);
            // 
            // giaoVienToolStripMenuItem1
            // 
            this.giaoVienToolStripMenuItem1.Name = "giaoVienToolStripMenuItem1";
            this.giaoVienToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.giaoVienToolStripMenuItem1.Text = "Giảng viên";
            this.giaoVienToolStripMenuItem1.Click += new System.EventHandler(this.giaoVienToolStripMenuItem1_Click_1);
            // 
            // lopHocToolStripMenuItem
            // 
            this.lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            this.lopHocToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lopHocToolStripMenuItem.Text = "Lớp";
            this.lopHocToolStripMenuItem.Click += new System.EventHandler(this.lopHocToolStripMenuItem_Click_1);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangkymonhocClassHọcToolStripMenuItem,
            this.dangKyToolStripMenuItem,
            this.DiemThanhPhanToolStripMenuItem,
            this.DiemThiToolStripMenuItem,
            this.traCuuDiemToolStripMenuItem});
            this.chucNangToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // dangkymonhocClassHọcToolStripMenuItem
            // 
            this.dangkymonhocClassHọcToolStripMenuItem.Name = "dangkymonhocClassHọcToolStripMenuItem";
            this.dangkymonhocClassHọcToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.dangkymonhocClassHọcToolStripMenuItem.Text = "Đăng ký môn học cho lớp";
            this.dangkymonhocClassHọcToolStripMenuItem.Click += new System.EventHandler(this.dangkymonhocClassHọcToolStripMenuItem_Click);
            // 
            // dangKyToolStripMenuItem
            // 
            this.dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            this.dangKyToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.dangKyToolStripMenuItem.Text = "Đăng ký môn học";
            this.dangKyToolStripMenuItem.Click += new System.EventHandler(this.dangKyToolStripMenuItem_Click_1);
            // 
            // DiemThanhPhanToolStripMenuItem
            // 
            this.DiemThanhPhanToolStripMenuItem.Name = "DiemThanhPhanToolStripMenuItem";
            this.DiemThanhPhanToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.DiemThanhPhanToolStripMenuItem.Text = "Nhập điểm thành phần";
            this.DiemThanhPhanToolStripMenuItem.Click += new System.EventHandler(this.DiemThanhPhanToolStripMenuItem_Click_1);
            // 
            // DiemThiToolStripMenuItem
            // 
            this.DiemThiToolStripMenuItem.Name = "DiemThiToolStripMenuItem";
            this.DiemThiToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.DiemThiToolStripMenuItem.Text = "Nhập điểm thi";
            this.DiemThiToolStripMenuItem.Click += new System.EventHandler(this.DiemThiToolStripMenuItem_Click_1);
            // 
            // traCuuDiemToolStripMenuItem
            // 
            this.traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            this.traCuuDiemToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            this.traCuuDiemToolStripMenuItem.Click += new System.EventHandler(this.traCuuDiemToolStripMenuItem_Click_1);
            // 
            // danhSachTaiKhoanToolStripMenuItem
            // 
            this.danhSachTaiKhoanToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.danhSachTaiKhoanToolStripMenuItem.Name = "danhSachTaiKhoanToolStripMenuItem";
            this.danhSachTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(150, 21);
            this.danhSachTaiKhoanToolStripMenuItem.Text = "Danh sách tài khoản";
            this.danhSachTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.danhSachTaiKhoanToolStripMenuItem_Click);
            // 
            // FormStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormStudentManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lopHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taikhoanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhSachTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangkymonhocClassHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiemThanhPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiemThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myClassToolStripMenuItem;
    }
}
