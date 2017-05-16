using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class HOADONBAN
    {
        private string mahoadon, manhanvien, makhachhang;
        private float tongtien;
        private DateTime ngayban;
        private int sohoadonban;
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

        public int Sohoadonban
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

        public string Mahoadon
        {
            get
            {
                return mahoadon;
            }

            set
            {
                this.mahoadon = value;
            }
        }

        public HOADONBAN(string mahoadon, string manhanvien, string makhachhang, float tongtien, DateTime ngayban, int sohoadonban)
        {
            mahoadon = this.mahoadon;
            makhachhang = this.makhachhang;
            manhanvien = this.manhanvien;
            tongtien = this.tongtien;
            ngayban = this.ngayban;
            sohoadonban = this.sohoadonban;
        }
    }
}
