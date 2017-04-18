using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODAL.ENNITES;
using MODAL.FUNSIONS;
using System.Data;

namespace CONTROL
{
  public  class NHANVIEN_C
    {
        NHANVIEN_M obj_m = new NHANVIEN_M();
        public DataTable Get_Obj()
        {
            return obj_m.Get_Obj();
        }
        public bool Add_Obj(NHANVIEN Obj)
        {
            return obj_m.Add_Obj(Obj);
        }
        public bool Up_Obj(NHANVIEN Obj)
        {
            return obj_m.Up_Obj(Obj);
        }
        public bool Del_Obj(string Obj)
        {
            return obj_m.Del_Obj(Obj);
        }
    }

}

