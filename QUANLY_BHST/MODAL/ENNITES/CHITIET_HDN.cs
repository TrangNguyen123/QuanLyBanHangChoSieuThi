using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class CHITIET_HDN
    {
        private string sohoadonnhap, mavach;
        private int soluong;
        private float dongia, giamgia, thanhtien;
        public CHITIET_HDN() { }
        public string Sohoadonnhap
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

        public string Mavach
        {
            get
            {
                return mavach;
            }

            set
            {
                mavach = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public float Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public float Giamgia
        {
            get
            {
                return giamgia;
            }

            set
            {
                giamgia = value;
            }
        }

        public float Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
        public CHITIET_HDN(string sohoadonnhap, string mavach, int soluong, float giamgia, float thanhtien, float dongia)
        {
            sohoadonnhap = this.sohoadonnhap;
            mavach = this.mavach;
            giamgia = this.giamgia;
            thanhtien = this.thanhtien;
            soluong = this.soluong;
            dongia = this.dongia;


        }
    }
}
