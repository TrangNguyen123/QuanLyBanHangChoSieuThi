using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES

{
    public class NHANVIEN
    {
        private string manhanvien, tennhanvien, gioitinh, chucvu, sodienthoai, diachi;
        private DateTime ngaysinh;
        public NHANVIEN() { }
        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

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
        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
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

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
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

        public string Tennhanvien
        {
            get
            {
                return tennhanvien;
            }

            set
            {
                tennhanvien = value;
            }
        }
        public NHANVIEN(string manhanvien, string tennhanvien, string gioitinh, string sodienthoai, string chucvu, string diachi, DateTime ngaysinh)
        {
            manhanvien = this.manhanvien;
            tennhanvien = this.tennhanvien;
            gioitinh = this.gioitinh;
            chucvu = this.chucvu;
            sodienthoai = this.sodienthoai;
            diachi = this.diachi;
            ngaysinh = this.ngaysinh;

        }
    }
}
