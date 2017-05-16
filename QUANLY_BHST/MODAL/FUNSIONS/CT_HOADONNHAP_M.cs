using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DATA_ACCESS;
using MODAL.ENNITES;

namespace MODAL.FUNSIONS
{
  public  class CT_HOADONNHAP_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable Get_Obj()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "loatcthoadonnhap";
            //proc lấy danh sách dữ liệu 
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.OpenConn();//mơ kết nối 
                IDataReader reader = cmd.ExecuteReader();//khai báo một reader
                dt.Load(reader);
                conn.CloseConn();//đóng kết nối

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }
        public bool Add_Obj(CHITIET_HDN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themcthoadonnhap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@mavach", obj.Mavach));
                cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(obj.Soluong));
                cmd.Parameters.AddWithValue("@thanhtien", Convert.ToDouble(obj.Thanhtien));
                cmd.Parameters.AddWithValue("@dongianhap", Convert.ToDouble(obj.Dongianhap));
                cmd.Parameters.AddWithValue("@giamgia", Convert.ToDouble(obj.Giamgia));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
        public bool Up_Obj(CHITIET_HDN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suacthoadonnhap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@mavach", obj.Mavach));
                cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(obj.Soluong));
                cmd.Parameters.AddWithValue("@thanhtien", Convert.ToDouble(obj.Thanhtien));
                cmd.Parameters.AddWithValue("@dongianhap", Convert.ToDouble(obj.Dongianhap));
                cmd.Parameters.AddWithValue("@giamgia", Convert.ToDouble(obj.Giamgia));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex1)
            {
                throw;
            }
        }

        public bool Del_Obj(string obj, string obj1)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("xoacthoadonnhap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
    }
}
