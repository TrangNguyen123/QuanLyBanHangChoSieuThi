using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_BHST.VIEW;
namespace QUANLY_BHST
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void MntHangHoa_Click(object sender, EventArgs e)
        {
          
          FR_HANGHOA   d = new FR_HANGHOA();
            d.ShowDialog();
        }

        private void MntHoaDonBan_Click(object sender, EventArgs e)
        {
        
            FR_HOADONBAN d = new FR_HOADONBAN();
            d.ShowDialog();
        }

        private void MntHoaDonNhap_Click(object sender, EventArgs e)
        {
            FR_HOADONNHAP d = new FR_HOADONNHAP();
            d.ShowDialog();
        }

        private void MntCTHoaDonNhap_Click(object sender, EventArgs e)
        {
          
            FR_CHITIET_HDN d = new FR_CHITIET_HDN();
            d.ShowDialog();
        }

        private void MntCTHoaDonBan_Click(object sender, EventArgs e)
        {
            FR_CHITIET_HDB d = new FR_CHITIET_HDB();
            d.ShowDialog();
        }

        private void MntNhanVien_Click(object sender, EventArgs e)
        {
            FR_NHANVIEN d = new FR_NHANVIEN();
            d.ShowDialog();
        }

        private void quảnLýDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MntNhaCungCap_Click(object sender, EventArgs e)
        {
            FR_NHACUNGCAP d = new FR_NHACUNGCAP();
            d.ShowDialog();
        }

        private void MntKhachHang_Click(object sender, EventArgs e)
        {
            FR_KHACHHANG d = new FR_KHACHHANG();
            d.ShowDialog();
        }
    }
}
