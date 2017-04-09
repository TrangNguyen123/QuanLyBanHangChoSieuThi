using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class KHACHHANG
    {
        private string makhachhang, tenkhachhang, diachi, sodienthoai;
        public KHACHHANG() { }
        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Makhachhang
        {
            get
            {
                return makhachhang;
            }

            set
            {
                makhachhang = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return tenkhachhang;
            }

            set
            {
                tenkhachhang = value;
            }
        }
        public KHACHHANG(string makhachhang, string tenkhachhang, string diachi, string sodienthoai)
        {
            makhachhang = this.makhachhang;
            tenkhachhang = this.tenkhachhang;
            diachi = this.diachi;
            sodienthoai = this.sodienthoai;
        }
    }
}
