using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class HOADONNHAP
    {
        private string mahoadon, manhanvien, manhacungcap;
        private DateTime ngaynhap;
        private float tongtienhoadonnhap;
        private int sohoadonnhap;
        public HOADONNHAP() { }

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

        public string Manhacungcap
        {
            get
            {
                return manhacungcap;
            }

            set
            {
                manhacungcap = value;
            }
        }

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }

        public float Tongtienhoadonnhap
        {
            get
            {
                return tongtienhoadonnhap;
            }

            set
            {
                tongtienhoadonnhap = value;
            }
        }

        public int Sohoadonnhap
        {
            get
            {
                return sohoadonnhap;
            }

            set
            {
                sohoadonnhap = value;
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

        public HOADONNHAP(string mahoadon, string manhanvien, string manhacungcap, DateTime ngaynhap, float tongtienhoadonnhap, int sohoahonnhap)
        {
            mahoadon = this.mahoadon;
            manhanvien = this.manhanvien;
            manhacungcap = this.manhacungcap;
            ngaynhap = this.ngaynhap;
            tongtienhoadonnhap = this.tongtienhoadonnhap;
            sohoadonnhap = this.sohoadonnhap;

        }
    }
}
