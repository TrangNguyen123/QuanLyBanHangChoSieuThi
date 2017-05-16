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
    public partial class FR_CHITIET_HDB : Form
    {
        CT_HOADONBAN_C Obj_c = new CT_HOADONBAN_C();
        CHITIET_HDB Obj = new CHITIET_HDB();
        int flag = 0;
        DataTable Obj_tb = new DataTable();
        public FR_CHITIET_HDB()
        {
            InitializeComponent();
        }

        private void FR_CHITIET_HDB_Load(object sender, EventArgs e)
        {
            Obj_tb = Obj_c.Get_Obj();
            dgvCT_HDBAN.DataSource = Obj_tb;
            Bingding();
        } 
     
        private void Bingding()
        {
            cmbMaHD.DataBindings.Clear();
            cmbMaHD.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "mahoadon");
            cmbTenHH.DataBindings.Clear();
            cmbTenHH.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "tenhanghoa");
            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "soluong");
            cmbDongia.DataBindings.Clear();
            cmbDongia.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "dongiaban");
            txtgiamgia.DataBindings.Clear();
            txtgiamgia.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "giamgia");
            Lbthanhtien.DataBindings.Clear();
            Lbthanhtien.DataBindings.Add("Text", dgvCT_HDBAN.DataSource, "thanhtien");
        }
        private void Dis_End(bool e)
        {

            cmbMaHD.Enabled = e;
            cmbTenHH.Enabled = e;
            txtSoluong.Enabled = e;
            cmbDongia.Enabled = e;
            txtgiamgia.Enabled = e;
            Lbthanhtien.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;                      
        }
        private void Loat_MaHD()
        {
            HOADONBAN_C NCC = new HOADONBAN_C();
            cmbMaHD.DataSource = NCC.Get_Obj();
            cmbMaHD.DisplayMember = "mahoadon";
            cmbMaHD.ValueMember = "mahoadon";
        }
        private void Loat_TenHH()
        {
            HANGHOA_C NCC = new HANGHOA_C();
            cmbTenHH.DataSource = NCC.Get_Obj();
            cmbTenHH.DisplayMember = "tenhanghoa";
            cmbTenHH.ValueMember = "mavach";
        }
        private void Loat_Dongiaban()
        {
            HANGHOA_C NCC = new HANGHOA_C();
            cmbDongia.DataSource = NCC.Get_Obj();
            cmbDongia.DisplayMember = "dongiaban";
            cmbDongia.ValueMember = "mavach";
        }
        private void Gan_Obj(CHITIET_HDB obj)
        {

            obj.Mavach = cmbTenHH.SelectedValue.ToString();
            obj.Soluong = int.Parse(txtSoluong.Text.Trim());
            obj.Dongiaban =float.Parse(cmbDongia.Text.Trim ());
            obj.Giamgia = float.Parse(txtgiamgia.Text.Trim());
            obj.Mahoadon = cmbMaHD.SelectedValue.ToString();
            obj.Thanhtien = float.Parse(Lbthanhtien.Text.Trim());
        }
        private void Clear_Obj()
        {
            Lbthanhtien.Text = "";
            txtSoluong.Text = "";
            txtgiamgia.Text = "";
            Loat_MaHD();
            Loat_TenHH();
            Loat_Dongiaban();
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
            Loat_MaHD();
            Loat_TenHH();
            Loat_Dongiaban();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    if (Obj_c.Del_Obj(cmbMaHD.Text.Trim(),cmbTenHH.Text.Trim()))
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
            FR_CHITIET_HDB_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            FR_CHITIET_HDB_Load(sender, e);
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
            FR_CHITIET_HDB_Load(sender, e);
        }

        private void ckthanhtien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckthanhtien.Checked)
            { 
               Lbthanhtien.Text = ((int.Parse(txtSoluong.Text) * float.Parse(txtgiamgia.Text) * float.Parse(cmbDongia.Text)).ToString());
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDongia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
