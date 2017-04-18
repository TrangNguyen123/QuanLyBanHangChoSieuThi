using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODAL.ENNITES;
using CONTROL;

namespace QUANLY_BHST.VIEW
{
    public partial class FR_NHANVIEN : Form
    {
        NHANVIEN_C Obj_c = new NHANVIEN_C();
        NHANVIEN Obj = new NHANVIEN();
        int flag = 0;
        public FR_NHANVIEN()
        {
            InitializeComponent();
        }

        private void FR_NHANVIEN_Load(object sender, EventArgs e)
        {

            DataTable Obj_tb = new DataTable();
            Obj_tb = Obj_c.Get_Obj();
            dgvNhanvien.DataSource = Obj_tb;
            Bingding();

        }

        private void Bingding()
        {
            txtManhanvien.DataBindings.Clear();
            txtManhanvien.DataBindings.Add("Text", dgvNhanvien.DataSource, "manhanvien");
            txtTennhanvien.DataBindings.Clear();
            txtTennhanvien.DataBindings.Add("Text", dgvNhanvien.DataSource, "tennhanvien");
            cmbGioitinh.DataBindings.Clear();
            cmbGioitinh.DataBindings.Add("Text", dgvNhanvien.DataSource, "gioitinh");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvNhanvien.DataSource, "ngaysinh");
            mskDienthoai.DataBindings.Clear();
            mskDienthoai.DataBindings.Add("Text", dgvNhanvien.DataSource, "sodienthoai");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvNhanvien.DataSource, "diachi");
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dgvNhanvien.DataSource, "chucvu");

        }
        private void Dis_End(bool e)
        {

            txtManhanvien.Enabled = e;
            txtTennhanvien.Enabled = e;
            mskDienthoai.Enabled = e;
            cmbGioitinh.Enabled = e;
            dtpNgaysinh.Enabled = e;
            txtDiachi.Enabled = e;
            textBox1.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;

        }
        private void Gan_Obj(NHANVIEN obj)
        {
            obj.Manhanvien = txtManhanvien.Text.Trim();
            obj.Tennhanvien = txtTennhanvien.Text.Trim();
            if (cmbGioitinh.SelectedIndex == 0)
            {
                obj.Gioitinh = "Nam";
            }
            else
                obj.Gioitinh = "Nữ";

            obj.Ngaysinh = DateTime.Parse(dtpNgaysinh.Text.Trim());
            obj.Diachi = txtDiachi.Text.Trim();
            obj.Sodienthoai = mskDienthoai.Text.Trim();
            obj.Chucvu = textBox1.Text.Trim();
        }

        private void Clear_Obj()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            dtpNgaysinh.Value = DateTime.Now.Date;
            cmbGioitinh.Text = "";
            textBox1.Text = "";
            mskDienthoai.Text = "";
            txtDiachi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            flag = 0;
            Clear_Obj();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            Dis_End(true);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    if (Obj_c.Del_Obj(txtManhanvien.Text.Trim()))
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                return;
            FR_NHANVIEN_Load(sender, e);
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            FR_NHANVIEN_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            Gan_Obj(Obj);
            if (flag == 0)
            {
                try
                {
                    if (Obj_c.Add_Obj(Obj))
                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                try
                {
                    if (Obj_c.Up_Obj(Obj))
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //   SV_Ctr.UpdData(SV_dt);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }
            FR_NHANVIEN_Load(sender, e);
        }
    }
}
