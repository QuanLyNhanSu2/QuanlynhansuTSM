using Quanlynhansu.Core;
using Quanlynhansu.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu.Core
{
    class ControllerBase<T> where T : ModelBase, new()
    {
        List<T> lst = new List<T>();
        public DataGridView ViewControl { get; set; }
        public void Show()
        {
            T objT = new T();
            objT.Initialize();
            string query = objT.ModelName + "_View";
            DataTable dt = DataAccess.Query(
                query,
                new SqlParameter("@sbgtt", SBGTT),
                new SqlParameter("@vtht", VTHT));
            lst.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ModelBase model = new T();
                model.Initialize();
                model.FieldsValue = dr.ItemArray;
                lst.Add((T)model);
            }
            ViewControl.DataSource = null;
            ViewControl.DataSource = lst;
        }
    }
}
