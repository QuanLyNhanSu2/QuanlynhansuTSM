using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Taikhoan_Nhanvien:ModelBase
    {
        public int TaikhoanID { get { return GetINT(0); } set { SetINT(0, value); } }
        public int NhanvienID { get { return GetINT(1); } set { SetINT(1, value); } }
        public Taikhoan_Nhanvien()
        {
            MaxPosModelField = 1;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
