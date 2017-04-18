using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DATA_ACCESS
{
    public class ConnectToSQL
    {
        #region  Availible
        private SqlConnection sql_conn;
        public SqlConnection SQL_CONN
        {
            get { return sql_conn; }
            set { sql_conn = value; }
        }
        private SqlCommand sql_cmd;
        public SqlCommand SQL_CMD
        {
            get { return sql_cmd; }
            set { sql_cmd = value; }
        }
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
       public static string strconn;
        #endregion
        #region  Contructor
        public ConnectToSQL()
        {
            strconn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog = QuanLyBHST; Integrated Security=True ";

            sql_conn = new SqlConnection(strconn);
        }
        #endregion
        #region Methols
        public bool OpenConn()
        {
            try
            {
                if (sql_conn.State == ConnectionState.Closed)
                {
                    sql_conn.Open();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (sql_conn.State == ConnectionState.Open)
                {
                    sql_conn.Close();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
      
        #endregion
    }
}
