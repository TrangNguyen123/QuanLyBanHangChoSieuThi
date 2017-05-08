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
    public class HOADONBAN_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable Get_Obj()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "loathoadonban";
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
        public bool Add_Obj(HOADONBAN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themhoadonban", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.AddWithValue("@sohoadonban", Convert.ToInt32(obj.Sohoadonban));
                cmd.Parameters.AddWithValue("@tongtien", Convert.ToDouble(obj.Tongtien));
                cmd.Parameters.AddWithValue("@ngayban", Convert.ToDateTime(obj.Ngayban));
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
        public bool Up_Obj(HOADONBAN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suahoadonban", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahoadon", obj.Mahoadon));
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.AddWithValue("@sohoadonban", Convert.ToInt32(obj.Sohoadonban));
                cmd.Parameters.AddWithValue("@tongtien", Convert.ToDouble(obj.Tongtien));
                cmd.Parameters.AddWithValue("@ngayban", Convert.ToDateTime(obj.Ngayban));
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
                SqlCommand cmd = new SqlCommand("xoahoadonban", conn.SQL_CONN);
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
