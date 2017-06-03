namespace QUANLY_BHST
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MntHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MntCTHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MntHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MntCTHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MntKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MntNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HuongdanchitietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem,
            this.quảnLýDanhSáchToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MntHangHoa,
            this.MntHoaDonBan,
            this.MntHoaDonNhap});
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản Lý";
            // 
            // MntHangHoa
            // 
            this.MntHangHoa.Name = "MntHangHoa";
            this.MntHangHoa.Size = new System.Drawing.Size(153, 22);
            this.MntHangHoa.Text = "Hàng Hóa";
            this.MntHangHoa.Click += new System.EventHandler(this.MntHangHoa_Click);
            // 
            // MntHoaDonBan
            // 
            this.MntHoaDonBan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MntCTHoaDonBan});
            this.MntHoaDonBan.Name = "MntHoaDonBan";
            this.MntHoaDonBan.Size = new System.Drawing.Size(153, 22);
            this.MntHoaDonBan.Text = "Hóa Đơn Bán";
            this.MntHoaDonBan.Click += new System.EventHandler(this.MntHoaDonBan_Click);
            // 
            // MntCTHoaDonBan
            // 
            this.MntCTHoaDonBan.Name = "MntCTHoaDonBan";
            this.MntCTHoaDonBan.Size = new System.Drawing.Size(188, 22);
            this.MntCTHoaDonBan.Text = "Chi Tiết Hóa Đơn Bán";
            this.MntCTHoaDonBan.Click += new System.EventHandler(this.MntCTHoaDonBan_Click);
            // 
            // MntHoaDonNhap
            // 
            this.MntHoaDonNhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MntCTHoaDonNhap});
            this.MntHoaDonNhap.Name = "MntHoaDonNhap";
            this.MntHoaDonNhap.Size = new System.Drawing.Size(153, 22);
            this.MntHoaDonNhap.Text = "Hóa Đơn Nhập";
            this.MntHoaDonNhap.Click += new System.EventHandler(this.MntHoaDonNhap_Click);
            // 
            // MntCTHoaDonNhap
            // 
            this.MntCTHoaDonNhap.Name = "MntCTHoaDonNhap";
            this.MntCTHoaDonNhap.Size = new System.Drawing.Size(197, 22);
            this.MntCTHoaDonNhap.Text = "Chi Tiết Hóa Đơn Nhấp";
            this.MntCTHoaDonNhap.Click += new System.EventHandler(this.MntCTHoaDonNhap_Click);
            // 
            // quảnLýDanhSáchToolStripMenuItem
            // 
            this.quảnLýDanhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MntNhanVien,
            this.MntKhachHang,
            this.MntNhaCungCap});
            this.quảnLýDanhSáchToolStripMenuItem.Name = "quảnLýDanhSáchToolStripMenuItem";
            this.quảnLýDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.quảnLýDanhSáchToolStripMenuItem.Text = " Danh Sách";
            // 
            // MntNhanVien
            // 
            this.MntNhanVien.Name = "MntNhanVien";
            this.MntNhanVien.Size = new System.Drawing.Size(152, 22);
            this.MntNhanVien.Text = "Nhân Viên";
            this.MntNhanVien.Click += new System.EventHandler(this.MntNhanVien_Click);
            // 
            // MntKhachHang
            // 
            this.MntKhachHang.Name = "MntKhachHang";
            this.MntKhachHang.Size = new System.Drawing.Size(152, 22);
            this.MntKhachHang.Text = "Khách Hàng";
            this.MntKhachHang.Click += new System.EventHandler(this.MntKhachHang_Click);
            // 
            // MntNhaCungCap
            // 
            this.MntNhaCungCap.Name = "MntNhaCungCap";
            this.MntNhaCungCap.Size = new System.Drawing.Size(152, 22);
            this.MntNhaCungCap.Text = "Nhà Cung Cấp";
            this.MntNhaCungCap.Click += new System.EventHandler(this.MntNhaCungCap_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HuongdanchitietToolStripMenuItem,
            this.phiênBảnToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // HuongdanchitietToolStripMenuItem
            // 
            this.HuongdanchitietToolStripMenuItem.Name = "HuongdanchitietToolStripMenuItem";
            this.HuongdanchitietToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.HuongdanchitietToolStripMenuItem.Text = "Hường Dẫn Chi Tiết";
            this.HuongdanchitietToolStripMenuItem.Click += new System.EventHandler(this.HuongdanchitietToolStripMenuItem_Click);
            // 
            // phiênBảnToolStripMenuItem
            // 
            this.phiênBảnToolStripMenuItem.Name = "phiênBảnToolStripMenuItem";
            this.phiênBảnToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.phiênBảnToolStripMenuItem.Text = "Phiên Bản";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 409);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntHangHoa;
        private System.Windows.Forms.ToolStripMenuItem MntHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem MntCTHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem MntHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem MntCTHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MntKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MntNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuongdanchitietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiênBảnToolStripMenuItem;
    }
}