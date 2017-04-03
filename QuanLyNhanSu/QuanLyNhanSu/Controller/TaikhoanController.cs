using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Core;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu.Controller
{
    class TaikhoanController : ControllerBase<Taikhoan>
    {
        public bool Login(string user, string pass)
        {
            bool ok = false;
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand sc = new SqlCommand("Dangnhap", con);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.Add(new SqlParameter("@tentaikhoan", user));
                sc.Parameters.Add(new SqlParameter("@matkhau", pass));
                sc.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
                if (int.Parse(dt.Rows[0][0].ToString()) > 0)
                    ok = true;
                con.Close();
            }
            return ok;
        }
    }
}
