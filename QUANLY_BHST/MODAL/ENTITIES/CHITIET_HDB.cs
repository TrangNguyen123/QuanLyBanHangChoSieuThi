using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ENTITIES
{
    public class CHITIET_HDB
    {
        private string sohoadonban, mavach;
        private int soluong;
        private float giamgia, thanhtien, dongia;
        public CHITIET_HDB() { }
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
        public CHITIET_HDB(string sohoadonban, string mavach, int soluong, float giamgia, float thanhtien, float dongia)
        {
            sohoadonban = this.sohoadonban;
            mavach = this.mavach;
            giamgia = this.giamgia;
            thanhtien = this.thanhtien;
            dongia = this.dongia;
            soluong = this.soluong;

        }
    }
}
