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
using MODAL.FUNSIONS;
using CONTROL;

namespace QUANLY_BHST.VIEW
{
    public partial class FR_NHACUNGCAP : Form
    {
        NHACUNGCAP_C Obj_c = new NHACUNGCAP_C();
        NHACUNGCAP Obj = new NHACUNGCAP();
        int flag = 0;
        public FR_NHACUNGCAP()
        {
            InitializeComponent();
        }

        private void FR_NHACUNGCAP_Load(object sender, EventArgs e)
        {
            DataTable Obj_tb = new DataTable();
            Obj_tb = Obj_c.Get_Obj();
            dgvNhacungcap.DataSource = Obj_tb;
            Bingding();

        }
        private void Bingding()
        {
            txtManhacungcap.DataBindings.Clear();
            txtManhacungcap.DataBindings.Add("Text", dgvNhacungcap.DataSource, "manhacungcap");
            txtTennhacungcap.DataBindings.Clear();
            txtTennhacungcap.DataBindings.Add("Text", dgvNhacungcap.DataSource, "tennhacungcap");
            mskDienthoai.DataBindings.Clear();
            mskDienthoai.DataBindings.Add("Text", dgvNhacungcap.DataSource, "sodienthoai");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvNhacungcap.DataSource, "diachi");

        }
        private void Dis_End(bool e)
        {

            txtManhacungcap.Enabled = e;
            txtTennhacungcap.Enabled = e;
            mskDienthoai.Enabled = e;
            txtDiachi.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;



        }
        private void Gan_Obj(NHACUNGCAP obj)
        {
            obj.Manhacungcap = txtManhacungcap.Text.Trim();
            obj.Tennhacungcap = txtTennhacungcap.Text.Trim();
            obj.Diachi = txtDiachi.Text.Trim();
            obj.Sodienthoai = mskDienthoai.Text.Trim();
        }
        private void Clear_Obj()
        {
            txtManhacungcap.Text = "";
            txtTennhacungcap.Text = "";
            mskDienthoai.Text = "";
            txtDiachi.Text = "";

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


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    if (Obj_c.Del_Obj(txtManhacungcap.Text.Trim()))
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
            FR_NHACUNGCAP_Load(sender, e);
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            FR_NHACUNGCAP_Load(sender, e);
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
            FR_NHACUNGCAP_Load(sender, e);
        }
    }
}
