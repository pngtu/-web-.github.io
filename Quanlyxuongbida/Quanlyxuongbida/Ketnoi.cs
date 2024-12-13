using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyxuongbida
{
    internal class KetNoi
    {
        string conStr = @"Data Source=LAPTOP-RJ1AVIQC\SQLEXPRESS;Initial Catalog=ql_bida1;Integrated Security=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet laydulieu(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                dap.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool thucthi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return true;
            }
        }
        public DataSet LayDudichvu()
        {
            string query = "select * from dichvu";
            return laydulieu(query);
        }
    }
}