using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class CHITIET_HDN
    {
        private string mahoadon, mavach;
        private int soluong;
        private float dongianhap, giamgia, thanhtien;
        public CHITIET_HDN() { }

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

        public float Dongianhap
        {
            get
            {
                return dongianhap;
            }

            set
            {
                dongianhap = value;
            }
        }

        public CHITIET_HDN(string mahoadon, string mavach, int soluong, float giamgia, float thanhtien, float dongianhap)
        {
            mahoadon = this.mahoadon;
            mavach = this.mavach;
            giamgia = this.giamgia;
            thanhtien = this.thanhtien;
            soluong = this.soluong;
            dongianhap = this.dongianhap;


        }
    }
}
