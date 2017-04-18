using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODAL.ENNITES;
using MODAL.FUNSIONS;
using System.Data;
using System.Data.SqlClient;
namespace CONTROL
{
    public class NHACUNGCAP_C
    {
        NHACUNGCAP_M obj_m = new NHACUNGCAP_M();
        public DataTable Get_Obj()
        {
            return obj_m.GetPT();
        }
        public bool Add_Obj(NHACUNGCAP Obj)
        {
            return obj_m.Add_Obj(Obj);
        }
        public bool Up_Obj(NHACUNGCAP Obj)
        {
            return obj_m.Up_Obj(Obj);
        }

        public bool Del_Obj(string Obj)
        {
            return obj_m.Del_Obj(Obj);
        }
    }
}
