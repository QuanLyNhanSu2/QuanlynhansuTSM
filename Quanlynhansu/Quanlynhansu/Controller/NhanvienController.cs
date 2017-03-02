using Quanlynhansu.Helper;
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
    class NhanvienController : ModelBase
    {
        public List<Nhanvien> LstNhanvien = new List<Nhanvien>();
        public DataGridView dgv { get; set; }

        public void ThemNhanvien(Nhanvien nv)
        {
            string query = "Add_record";
            bool ok = DataAccess.NonQuery(
                query,
                new System.Data.SqlClient.SqlParameter("@NhanvienID", nv.NhanvienID),
                new System.Data.SqlClient.SqlParameter("@Ten", nv.Ten),
                new System.Data.SqlClient.SqlParameter("@Gioitinh", nv.Gioitinh),
                new System.Data.SqlClient.SqlParameter("@SoCMND", nv.SoCMND),
                new System.Data.SqlClient.SqlParameter("@Ngaysinh", nv.Ngaysinh),
                new System.Data.SqlClient.SqlParameter("@Noisinh", nv.Noisinh),
                new System.Data.SqlClient.SqlParameter("@Dienthoai", nv.Dienthoai),
                new System.Data.SqlClient.SqlParameter("@HoKhau", nv.Hokhau),
                new System.Data.SqlClient.SqlParameter("@Choohiennay", nv.Choohiennay),
                new System.Data.SqlClient.SqlParameter("@Ngayvaolam", nv.Ngayvaolam),
                new System.Data.SqlClient.SqlParameter("@SotheATM", nv.SotheATM),
                new System.Data.SqlClient.SqlParameter("@DantocID", nv.DantocID),
                new System.Data.SqlClient.SqlParameter("@TongiaoID", nv.TongiaoID),
                new System.Data.SqlClient.SqlParameter("@PhongbanID", nv.PhongbanID),
                new System.Data.SqlClient.SqlParameter("@ChucvuID", nv.ChucvuID),
                new System.Data.SqlClient.SqlParameter("@BaohiemID", nv.BaohiemID),
                new System.Data.SqlClient.SqlParameter("@Ghichu", nv.Ghichu)
                );
            if (ok && MessageBox.Show(@"Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) ;
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
