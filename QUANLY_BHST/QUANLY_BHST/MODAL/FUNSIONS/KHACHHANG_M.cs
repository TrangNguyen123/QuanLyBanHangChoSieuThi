using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS;
using System.Data;
using System.Data.SqlClient;
using MODAL.ENNITES;
namespace MODAL.FUNSIONS
{
   public class KHACHHANG_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable Get_Obj()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "Loatkhachhang";
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
        public bool Add_Obj(KHACHHANG obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themkhachhang", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@makhachhang", obj.Makhachhang));
                cmd.Parameters.Add(new SqlParameter("@tenkhachhang", obj.Tenkhachhang));
                cmd.Parameters.Add(new SqlParameter("@diachi", obj.Diachi));
                cmd.Parameters.Add(new SqlParameter("@sodienthoai", obj.Sodienthoai));

                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
        public bool Up_Obj(KHACHHANG obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suakhachhang", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@makhachhang", obj.Makhachhang));
                cmd.Parameters.Add(new SqlParameter("@tenkhachhang", obj.Tenkhachhang));
                cmd.Parameters.Add(new SqlParameter("@diachi", obj.Diachi));
                cmd.Parameters.Add(new SqlParameter("@sodienthoai", obj.Sodienthoai));

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
                SqlCommand cmd = new SqlCommand("xoakhachhang", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@makhachhang", obj));
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
