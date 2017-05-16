using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS;
using MODAL.ENNITES;
using System.Data;
using System.Data.SqlClient;
namespace MODAL.FUNSIONS
{
  public  class HOADONNHAP_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable Get_Obj()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "loathoadonnhap";
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
        public bool Add_Obj(HOADONNHAP obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themhoadonnhap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.Add(new SqlParameter("@manhacungcap", obj.Manhacungcap));
                cmd.Parameters.AddWithValue("@sohoadonnhap", Convert.ToInt32(obj.Sohoadonnhap));
                cmd.Parameters.AddWithValue("@tongtienhoadonnhap", Convert.ToDouble(obj.Tongtienhoadonnhap));
                cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(obj.Ngaynhap));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
        public bool Up_Obj(HOADONNHAP obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suahoadonnhap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.Add(new SqlParameter("@manhacungcap", obj.Manhacungcap));
                cmd.Parameters.AddWithValue("@sohoadonnhap", Convert.ToInt32(obj.Sohoadonnhap));
                cmd.Parameters.AddWithValue("@tongtienhoadonnhap", Convert.ToDouble(obj.Tongtienhoadonnhap));
                cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(obj.Ngaynhap));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }

        public bool Del_Obj(string obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("xoahoadonnhap", conn.SQL_CONN);
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
