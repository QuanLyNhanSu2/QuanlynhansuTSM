using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Core
{
    class ControllerBase<T> where T : ModelBase, new()
    {
        string InsertProcName, UpdateProcName, DeleteProcName, SearchProcName;

        public ControllerBase()
        {
            T objT = new T();
            InsertProcName = objT.TableName + "_Themmoi";
            UpdateProcName = objT.TableName + "_Sua";
            DeleteProcName = objT.TableName + "_Xoa";
            SearchProcName = objT.TableName + "_Timkiem";
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
            SqlCommand sc = new SqlCommand(InsertProcName, con);
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
            SqlCommand sc = new SqlCommand(InsertProcName, con);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add(new SqlParameter("@" + obj.Fields[0], obj.FieldMap[0]));
            sc.ExecuteNonQuery();
            con.Close();
        }
        public List<T> Search()
        {
            List<T> LstSearch = new List<T>();
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                T objM = new T();
                SqlCommand sc = new SqlCommand(SearchProcName, con);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.Add(new SqlParameter("@" + objM.Fields[0], objM.FieldMap[0]));
                SqlDataAdapter da = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count!=0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        objM.FieldMap = dr.ItemArray;
                        LstSearch.Add((T)objM.Clone());
                    }
                }
            }

            return LstSearch;
        }
        public List<T> Query(string query, params SqlParameter[] sp)
        {
            List<T> LstModel = new List<T>();
            using (SqlConnection con = new SqlConnection(Dataconfig.ConnectionString))
            {
                con.Open();
                SqlDataAdapter da = null;
                T objT = new T();
                if (query.Contains(" "))
                {
                    da = new SqlDataAdapter(query, con);
                }
                else
                {
                    SqlCommand sc = new SqlCommand(query, con);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddRange(sp);
                    da = new SqlDataAdapter(sc);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        objT.FieldMap = dr.ItemArray;
                        LstModel.Add((T)objT.Clone());
                    }
                }
                con.Close();
            }
            return LstModel;
        }
    }
}
