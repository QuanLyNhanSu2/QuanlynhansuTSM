using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Core
{
    interface ViewList<T> where T : ModelBase, new()
    {
        List<T> Search(string name);
        List<T> Load();
    }

    interface ViewDT<T> where T : ModelBase, new()
    {
        DataTable Search(int id);
        DataTable Load();
    }
    class ControllerBase<T> : ViewDT<T> where T : ModelBase, new()
    {
        string InsertProcName, UpdateProcName, DeleteProcName, SearchProcName, LoadProcName;

        public ControllerBase()
        {
            T objT = new T();
            InsertProcName = objT.TableName + "_Themmoi";
            UpdateProcName = objT.TableName + "_Sua";
            DeleteProcName = objT.TableName + "_Xoa";
            SearchProcName = objT.TableName + "_Timkiem";
            LoadProcName = objT.TableName + "_Load";
        }

        public void Insert(T obj)
        {
            SqlConnection con = new SqlConnection(Dataconfig.ConnectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(InsertProcName, con);
            sc.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i <= obj.MaxPosModelField; i++)
            {
                sc.Parameters.Add(new SqlParameter("@" + obj.Fields[i], obj.FieldMap[i]));
            }
            sc.ExecuteNonQuery();
            con.Close();
        }
        public void Update(T obj)
        {
            SqlConnection con = new SqlConnection(Dataconfig.ConnectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(UpdateProcName, con);
            sc.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i <= obj.MaxPosModelField; i++)
            {
                sc.Parameters.Add(new SqlParameter("@" + obj.Fields[i], obj.FieldMap[i]));
            }
            sc.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(T obj)
        {
            SqlConnection con = new SqlConnection(Dataconfig.ConnectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(DeleteProcName, con);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add(new SqlParameter("@" + obj.Fields[0], obj.FieldMap[0]));
            sc.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Search(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                T objM = new T();
                SqlCommand sc = new SqlCommand(SearchProcName, con);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.Add(new SqlParameter("@" + objM.Fields[0], id));
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable Load()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                T objM = new T();
                SqlCommand sc = new SqlCommand(LoadProcName, con);
                sc.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable Query(string sql, params SqlParameter[] pr)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                con.Open();
                SqlDataAdapter da = null;
                if (sql.Contains(' '))
                {
                    da = new SqlDataAdapter(sql, con);
                }
                else
                {
                    SqlCommand sc = new SqlCommand(sql, con);
                    sc.CommandType = CommandType.StoredProcedure;
                    if (pr != null)
                        pr.ToList().ForEach(x => sc.Parameters.Add(x));
                    da = new SqlDataAdapter(sc);
                }
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}
