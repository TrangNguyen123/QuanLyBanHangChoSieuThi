using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODAL.ENNITES;
using MODAL.FUNSIONS;
namespace CONTROL
{
  public  class CT_HOADONNHAP_C
    {

        CT_HOADONNHAP_M obj_m = new CT_HOADONNHAP_M();
        public DataTable Get_Obj()
        {
            return obj_m.Get_Obj();
        }
        public bool Add_Obj(CHITIET_HDN Obj)
        {
            return obj_m.Add_Obj(Obj);
        }
        public bool Up_Obj(CHITIET_HDN Obj)
        {
            return obj_m.Up_Obj(Obj);
        }
        public bool Del_Obj(string Obj, string Obj1)
        {
            return obj_m.Del_Obj(Obj, Obj1);
        }
    }
}

