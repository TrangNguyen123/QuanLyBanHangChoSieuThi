using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class HOADONBAN
    {
        private string sohoadonban, manhanvien, makhachhang;
        private float tongtien;
        private DateTime ngayban;
        public HOADONBAN() { }
        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        public string Sohoadonban
        {
            get
            {
                return sohoadonban;
            }

            set
            {
                sohoadonban = value;
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

        public float Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public DateTime Ngayban
        {
            get
            {
                return ngayban;
            }

            set
            {
                ngayban = value;
            }
        }
        public HOADONBAN(string sohoadonban, string manhanvien, string makhachhang, float tongtien, DateTime ngayban)
        {
            sohoadonban = this.sohoadonban;
            makhachhang = this.makhachhang;
            manhanvien = this.manhanvien;
            tongtien = this.tongtien;
            ngayban = this.ngayban;
        }
    }
}
