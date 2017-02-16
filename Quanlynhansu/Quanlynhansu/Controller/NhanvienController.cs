using Quanlynhansu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu.Controller
{
    public class NhanvienController
    {
        public List<Nhanvien> LstNhanvien = new List<Nhanvien>();
        public DataGridView dgv { get; set; }

        public void ThemNhanvien(Nhanvien nv)
        {

        }

        public void SuaNhanvien(Nhanvien nv)
        {

        }

        public void XoaNhanvien(int nhanvienID)
        {

        }

        public void TimkiemNhanvien(int id)
        {
            DataTable lstTimkiem = null; // lấy dữ liệu từ dataaccess
            dgv.DataSource = null;
            dgv.DataSource = lstTimkiem;
        }

    }
}
