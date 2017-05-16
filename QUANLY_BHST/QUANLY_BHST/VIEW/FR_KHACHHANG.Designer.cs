namespace QUANLY_BHST.VIEW
{
    partial class FR_KHACHHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_KHACHHANG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.labTenhanghoa = new System.Windows.Forms.Label();
            this.labMaNcc = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.labDongianhap = new System.Windows.Forms.Label();
            this.labDongiaban = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnboqua = new System.Windows.Forms.ToolStripButton();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskDienthoai);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.txtMakhachhang);
            this.groupBox1.Controls.Add(this.labTenhanghoa);
            this.groupBox1.Controls.Add(this.labMaNcc);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.labDongianhap);
            this.groupBox1.Controls.Add(this.labDongiaban);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 141);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.BackColor = System.Drawing.Color.White;
            this.mskDienthoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDienthoai.Location = new System.Drawing.Point(502, 94);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(116, 20);
            this.mskDienthoai.TabIndex = 85;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(248, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 22);
            this.label15.TabIndex = 49;
            this.label15.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(133, 97);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(172, 20);
            this.txtTenkhachhang.TabIndex = 1;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(133, 57);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(172, 20);
            this.txtMakhachhang.TabIndex = 1;
            // 
            // labTenhanghoa
            // 
            this.labTenhanghoa.AutoSize = true;
            this.labTenhanghoa.Location = new System.Drawing.Point(20, 101);
            this.labTenhanghoa.Name = "labTenhanghoa";
            this.labTenhanghoa.Size = new System.Drawing.Size(94, 14);
            this.labTenhanghoa.TabIndex = 0;
            this.labTenhanghoa.Text = "Tên Khách Hàng";
            // 
            // labMaNcc
            // 
            this.labMaNcc.AutoSize = true;
            this.labMaNcc.Location = new System.Drawing.Point(20, 60);
            this.labMaNcc.Name = "labMaNcc";
            this.labMaNcc.Size = new System.Drawing.Size(89, 14);
            this.labMaNcc.TabIndex = 0;
            this.labMaNcc.Text = "Mã Khách Hàng";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(502, 53);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(172, 20);
            this.txtDiachi.TabIndex = 1;
            // 
            // labDongianhap
            // 
            this.labDongianhap.AutoSize = true;
            this.labDongianhap.Location = new System.Drawing.Point(395, 57);
            this.labDongianhap.Name = "labDongianhap";
            this.labDongianhap.Size = new System.Drawing.Size(45, 14);
            this.labDongianhap.TabIndex = 0;
            this.labDongianhap.Text = "Địa Chỉ";
            // 
            // labDongiaban
            // 
            this.labDongiaban.AutoSize = true;
            this.labDongiaban.Location = new System.Drawing.Point(395, 100);
            this.labDongiaban.Name = "labDongiaban";
            this.labDongiaban.Size = new System.Drawing.Size(82, 14);
            this.labDongiaban.TabIndex = 0;
            this.labDongiaban.Text = "Số Điện Thoại";
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
            this.toolStripSeparator4,
            this.btnLuu,
            this.btnboqua});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 279);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(751, 25);
            this.bindingNavigator1.TabIndex = 26;
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
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(118, 22);
            this.btnboqua.Text = "Bỏ Qua Thao Tác";
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhachhang,
            this.tenkhachhang,
            this.sodienthoai,
            this.diachi});
            this.dgvKhachhang.Location = new System.Drawing.Point(12, 150);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.Size = new System.Drawing.Size(733, 116);
            this.dgvKhachhang.TabIndex = 25;
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "makhachhang";
            this.makhachhang.FillWeight = 70F;
            this.makhachhang.HeaderText = "Mã Khách Hàng";
            this.makhachhang.Name = "makhachhang";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "tenkhachhang";
            this.tenkhachhang.FillWeight = 150F;
            this.tenkhachhang.HeaderText = "Tên Khách Hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // FR_KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvKhachhang);
            this.Name = "FR_KHACHHANG";
            this.Text = "FR_KHACHHANG";
            this.Load += new System.EventHandler(this.FR_KHACHHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.Label labTenhanghoa;
        private System.Windows.Forms.Label labMaNcc;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label labDongianhap;
        private System.Windows.Forms.Label labDongiaban;
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
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}