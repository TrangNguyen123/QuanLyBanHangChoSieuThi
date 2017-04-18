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
    public class NHACUNGCAP_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable GetPT()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "Loatnhacungcap";
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
        public bool Add_Obj(NHACUNGCAP obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themnhacungcap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhacungcap", obj.Manhacungcap));
                cmd.Parameters.Add(new SqlParameter("@tennhacungcap", obj.Tennhacungcap));
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
        public bool Up_Obj(NHACUNGCAP obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suanhacungcap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhacungcap", obj.Manhacungcap));
                cmd.Parameters.Add(new SqlParameter("@tennhacungcap", obj.Tennhacungcap));
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
                SqlCommand cmd = new SqlCommand("xoanhacungcap", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhacungcap", obj));
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


