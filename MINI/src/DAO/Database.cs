using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DAO
{
    public class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string strCnn = "Data Source=.; Database=QLthuvien;Integrated Security = True"; 
            sqlConn = new SqlConnection(strCnn);
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn); ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn); sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

    }
}
