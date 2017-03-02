using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhansu.Controller;
using Quanlynhansu.Model;
using Quanlynhansu.Helper;

namespace Quanlynhansu.View
{
    public partial class Danhmuc : UserControl
    {
        NhanvienController nvController = new NhanvienController();
        public Danhmuc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "Insert_Nhanvien";
            bool ok = DataAccess.NonQuery(
                query,
                new System.Data.SqlClient.SqlParameter("@NhanvienID", txtNhanvienID.Text),
                new System.Data.SqlClient.SqlParameter("@Hoten", txtHoten.Text),
                new System.Data.SqlClient.SqlParameter("@Gioitinh",cmbGioitinh.SelectedIndex.ToString()),
                new System.Data.SqlClient.SqlParameter("@SoCMND", txtSoCMND.Text),
                new System.Data.SqlClient.SqlParameter("@Ngaysinh",dtpNgaysinh.ToString() ),
                new System.Data.SqlClient.SqlParameter("@Noisinh", txtNoisinh.Text),
                new System.Data.SqlClient.SqlParameter("@Dienthoai", txtDienthoai.Text),
                new System.Data.SqlClient.SqlParameter("@Hokhau", txtHokhau.Text),
                new System.Data.SqlClient.SqlParameter("@Choohiennay", txtChoohiennay.Text),
                new System.Data.SqlClient.SqlParameter("@SoBHYT", txtSoBHYT.Text),
                new System.Data.SqlClient.SqlParameter("@SotheATM", txtSotheATM.Text),
                new System.Data.SqlClient.SqlParameter("@Dantoc", cmbDantoc.SelectedIndex.ToString()),
                new System.Data.SqlClient.SqlParameter("@Tongiao", txtTongiao.Text),
                new System.Data.SqlClient.SqlParameter("@Maphongban", txtMaphongban.Text),
                new System.Data.SqlClient.SqlParameter("@Machucvu", txtChucvu.Text),
                new System.Data.SqlClient.SqlParameter("@SoCMND", txtSoCMND.Text),
                new System.Data.SqlClient.SqlParameter("@Ghichu", rtbGhichu.Text)
                );
            if (ok && MessageBox.Show(@"Thêm mới thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) ;
        }
        string search;
        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimkiem.SelectedItem.ToString() == "Mã")
                search = "NhanvienID";
            else if (cmbTimkiem.SelectedItem.ToString() == "Họ tên")
                search = "Ten";
            else if (cmbTimkiem.SelectedItem.ToString() == "Số CMND")
                search = "SoCMND";
        }

        

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "keyword") ;
            else
            {
                string query = "Search_" + search;
                DataTable dt = DataAccess.Query(
                                                query,
                                                new System.Data.SqlClient.SqlParameter("@keyword", txtTimkiem.Text)
                                                );
                dtgHienthi.DataSource = null;
                dtgHienthi.DataSource = dt;
            }
        }
    }
}
