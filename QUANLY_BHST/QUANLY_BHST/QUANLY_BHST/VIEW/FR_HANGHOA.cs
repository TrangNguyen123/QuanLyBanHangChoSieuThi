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
    public partial class FR_HANGHOA : Form
    {
        HANGHOA_C Obj_c = new HANGHOA_C();
        HANGHOA Obj = new HANGHOA();
        int flag = 0;
        DataTable Obj_tb = new DataTable();
        public FR_HANGHOA()
        {
            InitializeComponent();
        }

        private void HANGHOA_F_Load(object sender, EventArgs e)
        {
            Obj_tb = Obj_c.Get_Obj();
            dgvHanghoa.DataSource = Obj_tb;
            Bingding();
        }
        private void Bingding()
        {
            txtMavach.DataBindings.Clear();
            txtMavach.DataBindings.Add("Text", dgvHanghoa.DataSource, "mavach");
            txtTenhanghoa.DataBindings.Clear();
            txtTenhanghoa.DataBindings.Add("Text", dgvHanghoa.DataSource, "tenhanghoa");
            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("Text", dgvHanghoa.DataSource, "soluong");
            txtDongiaban.DataBindings.Clear();
            txtDongiaban.DataBindings.Add("Text", dgvHanghoa.DataSource, "dongiaban");
            txtDongianhap.DataBindings.Clear();
            txtDongianhap.DataBindings.Add("Text", dgvHanghoa.DataSource, "dongianhap");
            cmbNhacungcap.DataBindings.Clear();
            cmbNhacungcap.DataBindings.Add("Text", dgvHanghoa.DataSource, "tennhacungcap");
        }
        private void Dis_End(bool e)
        {

            txtMavach.Enabled = e;
            txtTenhanghoa.Enabled = e;
            txtSoluong.Enabled = e;
            txtDongiaban.Enabled = e;
            txtDongianhap.Enabled = e;
            cmbNhacungcap.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            bntTimkiem.Enabled = !e;
            //           tSBtnThoat.Enabled = !e;               
        }
        private void Loat_Nhacungcap()
        {
            NHACUNGCAP_C NCC = new NHACUNGCAP_C();
            cmbNhacungcap.DataSource = NCC.Get_Obj();
            cmbNhacungcap.DisplayMember = "tennhacungcap";
            cmbNhacungcap.ValueMember = "manhacungcap";
        }

        private void Gan_Obj(HANGHOA obj)
        {
            obj.Mavach = txtMavach.Text.Trim();
            obj.Tenhanghoa = txtTenhanghoa.Text.Trim();
            obj.Soluong = int.Parse(txtSoluong.Text.Trim());
            obj.Dongiaban = float.Parse(txtDongiaban.Text.Trim());
            obj.Dongianhap = float.Parse(txtDongianhap.Text.Trim());
            obj.Manhacungcap = cmbNhacungcap.SelectedValue.ToString();
        }
        private void Clear_Obj()
        {
            txtMavach.Text = "";
            txtSoluong.Text = "";
            txtTenhanghoa.Text = "";
            txtDongiaban.Text = "";
            txtDongianhap.Text = "";
            Loat_Nhacungcap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_End(true);
            Clear_Obj();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(true);
            Loat_Nhacungcap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    if (Obj_c.Del_Obj(txtMavach.Text.Trim()))
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
            HANGHOA_F_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            HANGHOA_F_Load(sender, e);
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
            HANGHOA_F_Load(sender, e);
        }

        private void bntTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == " ")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    if (Obj_c.Seacrh_Obj(txtTimkiem.Text.Trim()))
                    {
                        MessageBox.Show("Có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }

