using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Helper
{
    public class DataAccess
    {
        public static DataTable Query(string strsql,params SqlParameter[] param)
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public static void NonQuery(string strsql, params SqlParameter[] param)
        {

        }
    }
}
