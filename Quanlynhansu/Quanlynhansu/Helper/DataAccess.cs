using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu.Helper
{
    public class DataAccess
    {
        static string strconnection = "";
        static SqlConnection con = new SqlConnection(strconnection);
        public static DataTable Query(string strsql,params SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = null;
            con.Open();
            if (strsql.Trim().Contains(' '))
            {
                da = new SqlDataAdapter(strsql, con);
            }
            else
            {
                SqlCommand cmd = new SqlCommand(strsql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => cmd.Parameters.Add(x));
                da = new SqlDataAdapter(cmd);
            }
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool NonQuery(string strsql, params SqlParameter[] param)
        {
            SqlCommand cmd = null;
            con.Open();
            cmd = new SqlCommand(strsql, con);
            if (strsql.Trim().Contains(' '))
            {
                cmd.CommandType = CommandType.Text;
            }
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => cmd.Parameters.Add(x));
            }
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
    }
}
