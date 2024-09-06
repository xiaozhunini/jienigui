
using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication1.Config
{
    public class SQLHelper
    {
        private string strConn = null;
        private SqlConnection Conn = null;
        private SqlDataReader Sqlsdr = null;
        public SQLHelper()
        {
            //利用反射连接数据库 
            strConn = AppConfig.ReadAppSettings("strConn");
            Console.WriteLine(strConn);
            Conn = new SqlConnection(strConn);
        }
        #region 判断数据库连接状态
        /// <summary> 
        /// 状态 是否连接
        /// </summary> 
        /// <returns>SqlConnection</returns> 
        public SqlConnection Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            return Conn;
        }

        /// <summary> 
        /// 状态 是否关闭
        /// </summary> 
        /// <returns>SqlConnection</returns> 
        private SqlConnection Closed()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            return Conn;
        }
        #endregion
        #region   执行sql语句
        //
        // 摘要:
        //     执行语句,返回结果表格DataTable
        //
        // 参数:
        //   sql:
        //     执行语句
        //
        //   iTimeOut:
        //     超时时间,0表示不指定
        //
        // 返回结果:
        //     返回结果表格
        public DataTable ExecuteDataTable(string sql, int iTimeOut = 0)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, Conn);
                if (iTimeOut > 30)
                {
                    sqlDataAdapter.SelectCommand.CommandTimeout = iTimeOut;
                }

                sqlDataAdapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("MySqlException Error:" + ex.ToString());
            }

            return dataTable;
        }
        #endregion
        #region  增

        #endregion
        #region  删

        #endregion
        #region  改
        #endregion
        # region 查
        # endregion




    }
}
