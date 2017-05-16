using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL;
using MODAL.ENNITES;

namespace QUANLY_BHST.VIEW
{
    public partial class FR_KHACHHANG : Form
    {
        KHACHHANG_C Obj_c = new KHACHHANG_C();
        KHACHHANG Obj = new KHACHHANG();
        int flag=0;
        public FR_KHACHHANG()
        {
            InitializeComponent();
        }

        private void FR_KHACHHANG_Load(object sender, EventArgs e)
        {
            DataTable Obj_tb = new DataTable();
            Obj_tb = Obj_c.Get_Obj();
            dgvKhachhang.DataSource = Obj_tb;
            Bingding();
        }
        private void Bingding()
        {
            txtMakhachhang.DataBindings.Clear();
            txtMakhachhang.DataBindings.Add("Text", dgvKhachhang.DataSource, "makhachhang");
            txtTenkhachhang.DataBindings.Clear();
            txtTenkhachhang.DataBindings.Add("Text", dgvKhachhang.DataSource, "tenkhachhang");
            mskDienthoai.DataBindings.Clear();
            mskDienthoai.DataBindings.Add("Text", dgvKhachhang.DataSource, "sodienthoai");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvKhachhang.DataSource, "diachi");

        }
        private void Dis_End(bool e)
        {

            txtMakhachhang.Enabled = e;
            txtTenkhachhang.Enabled = e;
            mskDienthoai.Enabled = e;

            mskDienthoai.Enabled = e;
            txtDiachi.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;

        }
        private void Gan_Obj(KHACHHANG obj)
        {
            obj.Makhachhang = txtMakhachhang.Text.Trim();
            obj.Tenkhachhang = txtTenkhachhang.Text.Trim();
            obj.Diachi = txtDiachi.Text.Trim();
            obj.Sodienthoai = mskDienthoai.Text.Trim();
        }
        private void Clear_Obj()
        {
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
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
                    if (Obj_c.Del_Obj(txtMakhachhang.Text.Trim()))
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
            FR_KHACHHANG_Load(sender, e);
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
            FR_KHACHHANG_Load(sender, e);

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            FR_KHACHHANG_Load(sender, e);

        }
    }
}
