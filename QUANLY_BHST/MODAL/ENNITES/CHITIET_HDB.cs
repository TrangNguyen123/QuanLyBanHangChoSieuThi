using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class CHITIET_HDB
    {
        private string mahoadon, mavach;
        private int soluong;
        private float giamgia, thanhtien, dongiaban;
        public CHITIET_HDB() { }

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

        public float Dongiaban
        {
            get
            {
                return dongiaban;
            }

            set
            {
                dongiaban = value;
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

        public CHITIET_HDB(string mahoadon, string mavach, int soluong, float giamgia, float thanhtien, float dongiaban)
        {
            mahoadon = this.mahoadon;
            mavach = this.mavach;
            giamgia = this.giamgia;
            thanhtien = this.thanhtien;
            dongiaban = this.dongiaban;
            soluong = this.soluong;

        }
    }
}
