using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Nhanvien : ModelBase
    {
        public int nhanvienID { get { return GetINT(0); } set { SetINT(0, value); } }
        public string tennhanvien { get { return GetSTR(1); } set { SetSTR(1, value); } }
        public int gioitinh { get { return GetINT(2); } set { SetINT(2, value); } }
        public int soCMND { get { return GetINT(3); } set { SetINT(3, value); } }
        public DateTime ngaysinh { get { return GetDT(4); } set { SetDT(4, value); } }
        public string noisinh { get { return GetSTR(5); } set { SetSTR(5, value); } }
        public string dienthoai { get { return GetSTR(6); } set { SetSTR(6, value); } }
        public string dantoc { get { return GetSTR(7); } set { SetSTR(7, value); } }
        public string tongiao { get { return GetSTR(8); } set { SetSTR(8, value); } }
        public string ghichu { get { return GetSTR(9); } set { SetSTR(9, value); } }
        public string tenphongban { get { return GetSTR(10); } set { SetSTR(10, value); } }
        public string tenchucvu { get { return GetSTR(11); } set { SetSTR(11, value); } }
        public Nhanvien()
        {
            MaxPosModelField = 11;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
