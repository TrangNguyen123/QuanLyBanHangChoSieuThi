namespace QUANLY_BHST.VIEW
{
    partial class FR_NHANVIEN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_NHANVIEN));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnboqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChucvu = new System.Windows.Forms.GroupBox();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCongviec = new System.Windows.Forms.Label();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.txtChucvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnboqua,
            this.toolStripSeparator4,
            this.btnLuu});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 307);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(807, 25);
            this.bindingNavigator1.TabIndex = 82;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 22);
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 22);
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 22);
            this.btnXoa.Text = "Xóa Dữ Liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(118, 22);
            this.btnboqua.Text = "Bỏ Qua Thao Tác";
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 22);
            this.btnLuu.Text = "Lưu Dữ Liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhanvien,
            this.tennhanvien,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sodienthoai,
            this.chucvu});
            this.dgvNhanvien.Location = new System.Drawing.Point(7, 176);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(791, 116);
            this.dgvNhanvien.TabIndex = 81;
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.FillWeight = 70F;
            this.manhanvien.HeaderText = "Mã NV";
            this.manhanvien.Name = "manhanvien";
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "tennhanvien";
            this.tennhanvien.FillWeight = 150F;
            this.tennhanvien.HeaderText = "Tên Nhân Viên";
            this.tennhanvien.Name = "tennhanvien";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.FillWeight = 50F;
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.Name = "chucvu";
            // 
            // txtChucvu
            // 
            this.txtChucvu.BackColor = System.Drawing.Color.Transparent;
            this.txtChucvu.Controls.Add(this.cmbGioitinh);
            this.txtChucvu.Controls.Add(this.dtpNgaysinh);
            this.txtChucvu.Controls.Add(this.textBox1);
            this.txtChucvu.Controls.Add(this.label1);
            this.txtChucvu.Controls.Add(this.lblCongviec);
            this.txtChucvu.Controls.Add(this.mskDienthoai);
            this.txtChucvu.Controls.Add(this.txtDiachi);
            this.txtChucvu.Controls.Add(this.txtTennhanvien);
            this.txtChucvu.Controls.Add(this.txtManhanvien);
            this.txtChucvu.Controls.Add(this.lblNgaysinh);
            this.txtChucvu.Controls.Add(this.lblDienthoai);
            this.txtChucvu.Controls.Add(this.lblDiachi);
            this.txtChucvu.Controls.Add(this.lblGioitinh);
            this.txtChucvu.Controls.Add(this.lblTennhanvien);
            this.txtChucvu.Controls.Add(this.lblManhanvien);
            this.txtChucvu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucvu.Location = new System.Drawing.Point(7, 6);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(791, 164);
            this.txtChucvu.TabIndex = 80;
            this.txtChucvu.TabStop = false;
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioitinh.Location = new System.Drawing.Point(98, 120);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(151, 22);
            this.cmbGioitinh.TabIndex = 93;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(349, 47);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(134, 20);
            this.dtpNgaysinh.TabIndex = 92;
            this.dtpNgaysinh.Value = new System.DateTime(2017, 4, 6, 23, 42, 56, 0);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(576, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(253, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "DANH MỤC NHÂN VIÊN\r\n";
            // 
            // lblCongviec
            // 
            this.lblCongviec.AutoSize = true;
            this.lblCongviec.BackColor = System.Drawing.Color.Transparent;
            this.lblCongviec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCongviec.ForeColor = System.Drawing.Color.Black;
            this.lblCongviec.Location = new System.Drawing.Point(510, 90);
            this.lblCongviec.Name = "lblCongviec";
            this.lblCongviec.Size = new System.Drawing.Size(52, 14);
            this.lblCongviec.TabIndex = 89;
            this.lblCongviec.Text = "Chức vụ";
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.BackColor = System.Drawing.Color.White;
            this.mskDienthoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDienthoai.Location = new System.Drawing.Point(349, 88);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(134, 20);
            this.mskDienthoai.TabIndex = 84;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.White;
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiachi.Location = new System.Drawing.Point(576, 50);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(134, 20);
            this.txtDiachi.TabIndex = 82;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.BackColor = System.Drawing.Color.White;
            this.txtTennhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTennhanvien.Location = new System.Drawing.Point(98, 84);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(151, 20);
            this.txtTennhanvien.TabIndex = 81;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.BackColor = System.Drawing.Color.White;
            this.txtManhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManhanvien.Location = new System.Drawing.Point(98, 46);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(151, 20);
            this.txtManhanvien.TabIndex = 80;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaysinh.Location = new System.Drawing.Point(283, 52);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(60, 14);
            this.lblNgaysinh.TabIndex = 79;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienthoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDienthoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienthoai.Location = new System.Drawing.Point(283, 90);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(62, 14);
            this.lblDienthoai.TabIndex = 78;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.ForeColor = System.Drawing.Color.Black;
            this.lblDiachi.Location = new System.Drawing.Point(510, 52);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(43, 14);
            this.lblDiachi.TabIndex = 77;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioitinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioitinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioitinh.Location = new System.Drawing.Point(13, 128);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(53, 14);
            this.lblGioitinh.TabIndex = 76;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblTennhanvien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTennhanvien.ForeColor = System.Drawing.Color.Black;
            this.lblTennhanvien.Location = new System.Drawing.Point(13, 90);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(84, 14);
            this.lblTennhanvien.TabIndex = 75;
            this.lblTennhanvien.Text = "Tên nhân viên";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblManhanvien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblManhanvien.ForeColor = System.Drawing.Color.Black;
            this.lblManhanvien.Location = new System.Drawing.Point(13, 48);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(79, 14);
            this.lblManhanvien.TabIndex = 74;
            this.lblManhanvien.Text = "Mã nhân viên";
            // 
            // FR_NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 332);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtChucvu);
            this.Name = "FR_NHANVIEN";
            this.Text = "FR_NHANVIEN";
            this.Load += new System.EventHandler(this.FR_NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.txtChucvu.ResumeLayout(false);
            this.txtChucvu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnboqua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.GroupBox txtChucvu;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCongviec;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
    }
}