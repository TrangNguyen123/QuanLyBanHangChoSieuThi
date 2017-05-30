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
    public partial class FR_HOADONNHAP : Form
    {

        HOADONNHAP_C Obj_c = new HOADONNHAP_C();
        HOADONNHAP Obj = new HOADONNHAP();
        int flag = 0;
        public FR_HOADONNHAP()
        {
            InitializeComponent();
        }

        private void FR_HOADONNHAP_Load(object sender, EventArgs e)
        {
            DataTable Obj_tb = new DataTable();
            Obj_tb = Obj_c.Get_Obj();
            dgvHDBan.DataSource = Obj_tb;
            Bingding();
        }
        private void Bingding()
        {
            txtMaHDB.DataBindings.Clear();
            txtMaHDB.DataBindings.Add("Text", dgvHDBan.DataSource, "mahoadon");
            cmbTenNHV.DataBindings.Clear();
            cmbTenNHV.DataBindings.Add("Text", dgvHDBan.DataSource, "tennhanvien");
            cmbNCC.DataBindings.Clear();
            cmbNCC.DataBindings.Add("Text", dgvHDBan.DataSource, "tennhacungcap");
            txttongtien.DataBindings.Clear();
            txttongtien.DataBindings.Add("Text", dgvHDBan.DataSource, "tongtienhoadonnhap");
            dtpngaynhap.DataBindings.Clear();
            dtpngaynhap.DataBindings.Add("Text", dgvHDBan.DataSource, "ngaynhap");
            txtSohoadon.DataBindings.Clear();
            txtSohoadon.DataBindings.Add("Text", dgvHDBan.DataSource, "sohoadonnhap");
        }
        private void Dis_End(bool e)
        {

            txtMaHDB.Enabled = e;
            txtSohoadon.Enabled = e;
            txttongtien.Enabled = e;
            cmbNCC.Enabled = e;
            cmbTenNHV.Enabled = e;
            dtpngaynhap.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnInHoaDon.Enabled = e;

        }
        private void Loat_NCC()
        {
            NHACUNGCAP_C KH = new NHACUNGCAP_C();
            cmbNCC.DataSource = KH.Get_Obj();
            cmbNCC.DisplayMember = "tennhacungcap";
            cmbNCC.ValueMember = "manhacungcap";
        }
        private void Loat_NV()
        {
            NHANVIEN_C NV = new NHANVIEN_C();
            cmbTenNHV.DataSource = NV.Get_Obj();
            cmbTenNHV.DisplayMember = "tennhanvien";
            cmbTenNHV.ValueMember = "manhanvien";
        }
        private void Gan_Obj(HOADONNHAP obj)
        {
            obj.Mahoadon = txtMaHDB.Text.Trim();
            obj.Sohoadonnhap = int.Parse(txtSohoadon.Text.Trim());
            obj.Tongtienhoadonnhap = float.Parse(txttongtien.Text.Trim());
            obj.Manhacungcap = cmbNCC.SelectedValue.ToString();
            obj.Manhanvien = cmbTenNHV.SelectedValue.ToString();
            obj.Ngaynhap = DateTime.Parse(dtpngaynhap.Text.Trim());
        }
        private void Clear_Obj()
        {
            txtMaHDB.Text = "";
            txttongtien.Text = "";
            txtSohoadon.Text = "";
            dtpngaynhap.Text = "";
            Loat_NCC();
            Loat_NV();

        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];

            //xóa kí tự trắng và PM or AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen;
            int mDigit;
            string mTemp = "";
            string[] mNumText;
            // xóa các dấu phẩy nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1;
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + "" + mNumText[mDigit];
                if (mLen == i)//chữ số cuối cùng ko cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỉ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mười không", "");
            mTemp = mTemp.Replace("không mười không", "");

            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mười", "linh");

            //loại bỏ trường hợp x0,x>=2
            mTemp = mTemp.Replace("mười không", "mười");

            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mười", "mười");

            //Fix trường hợp x4,x>=2
            mTemp = mTemp.Replace("mười bốn", "mười tư");

            //fix trường họp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");

            //fix trường hợp x5,x>=2
            mTemp = mTemp.Replace("mười năm", "mười lăm");

            //fix th x1,x>=2
            mTemp = mTemp.Replace("mười một", "mười một");

            //fix trường hơpk x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");

            //bỏ ký tự space
            mTemp = mTemp.Trim();

            //viết hoa kí tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
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
            Loat_NCC();
            Loat_NV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Dis_End(true);
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    if (Obj_c.Del_Obj(txtMaHDB.Text.Trim()))
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
            FR_HOADONNHAP_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_End(false);
            FR_HOADONNHAP_Load(sender, e);
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
            FR_HOADONNHAP_Load(sender, e);
        }

        private void Ckchu_CheckedChanged(object sender, EventArgs e)
        {

            if (Ckchu.Checked)
            {
                LbBangchu.Text = ChuyenSoSangChu(txttongtien.Text).ToString();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nâng cao", "In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        
    }
}
