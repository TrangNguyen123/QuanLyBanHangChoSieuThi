using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODAL.ENNITES;
using DATA_ACCESS;
namespace MODAL.FUNSIONS
{
   public class NHANVIEN_M
    {
        ConnectToSQL conn = new ConnectToSQL();//khởi tạo ket noi ke thưa từ connectToSQL
        SqlCommand cmd = new SqlCommand();//khoi tạo command
        public DataTable Get_Obj()
        {
            DataTable dt = new DataTable();
            //gán đói tượng connectiom
            cmd.Connection = conn.SQL_CONN;
            //lấy tên thủ tục
            cmd.CommandText = "Loatnhanvien";
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
        public bool Add_Obj(NHANVIEN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("themnhanvien", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.Add(new SqlParameter("@tennhanvien", obj.Tennhanvien));
                cmd.Parameters.Add(new SqlParameter("@diachi", obj.Diachi));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", obj.Gioitinh));
                cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(obj.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@sodienthoai", obj.Sodienthoai));
                cmd.Parameters.Add(new SqlParameter("@chucvu", obj.Chucvu));


                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }

            catch (Exception ex1)
            {
                throw;
            }
        }
        public bool Up_Obj(NHANVIEN obj)
        {
            try
            {
                conn.OpenConn();
                //    DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("suanhanvien", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj.Manhanvien));
                cmd.Parameters.Add(new SqlParameter("@tennhanvien", obj.Tennhanvien));
                cmd.Parameters.Add(new SqlParameter("@diachi", obj.Diachi));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", obj.Gioitinh));
                cmd.Parameters.Add(new SqlParameter("@sodienthoai", obj.Sodienthoai));
                cmd.Parameters.Add(new SqlParameter("@chucvu", obj.Chucvu));
                cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(obj.Ngaysinh));

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
                SqlCommand cmd = new SqlCommand("xoanhanvien", conn.SQL_CONN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhanvien", obj));
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
