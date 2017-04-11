﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ENTITIES
{
    public class HOADONNHAP
    {
        private string sohoadonnhap, manhanvien, manhacungcap;
        private DateTime ngaynhap;
        private float tongtienhoadonnhap;
        public HOADONNHAP() { }
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
        public HOADONNHAP(string sohoadonnhap, string manhanvien, string manhacungcap, DateTime ngaynhap, float tongtienhoadonnhap)
        {
            sohoadonnhap = this.sohoadonnhap;
            manhanvien = this.manhanvien;
            manhacungcap = this.manhacungcap;
            ngaynhap = this.ngaynhap;
            tongtienhoadonnhap = this.tongtienhoadonnhap;

        }
    }
}
