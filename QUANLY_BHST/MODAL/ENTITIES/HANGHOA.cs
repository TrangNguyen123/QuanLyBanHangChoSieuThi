using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
  public  class HANGHOA
    {
        private string mavach, tenhanghoa, manhacungcap;
        private int soluong;
        private float dongiaban, dongianhap;

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

        public string Tenhanghoa
        {
            get
            {
                return tenhanghoa;
            }

            set
            {
                tenhanghoa = value;
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
        public HANGHOA()
        {

        }
        public HANGHOA(string mavach, string tenhanghoa, int soluong, float dongiaban, float dongianhap, string manhacungcap)
        {
            mavach = this.mavach;
            tenhanghoa = this.tenhanghoa;
            soluong = this.soluong;
            dongiaban = this.dongiaban;
            dongianhap = this.dongianhap;
            manhacungcap = this.manhacungcap;
        }
    }
}
