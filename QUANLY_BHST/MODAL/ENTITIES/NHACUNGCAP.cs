using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODAL.ENNITES
{
    public class NHACUNGCAP
    {
        private string manhacungcap, tennhacungcap, diachi, sodienthoai;
        public NHACUNGCAP() { }
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

        public string Tennhacungcap
        {
            get
            {
                return tennhacungcap;
            }

            set
            {
                tennhacungcap = value;
            }
        }
        public NHACUNGCAP(string manhacungcap, string tennhacungcap, string diachi, string sodienthoai)
        {
            manhacungcap = this.manhacungcap;
            tennhacungcap = this.tennhacungcap;
            diachi = this.diachi;
            sodienthoai = this.sodienthoai;
        }
    }
}
