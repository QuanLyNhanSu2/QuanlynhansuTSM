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
        public int NhanvienID { get { return GetINT(0); } set { SetINT(0, value); } }
        public int PhongbanID { get { return GetINT(1); } set { SetINT(1, value); } }
        public int ChucvuID { get { return GetINT(2); } set { SetINT(2, value); } }
        public string Tennhanvien { get { return GetSTR(3); } set { SetSTR(3, value); } }
        public int Gioitinh { get { return GetINT(4); } set { SetINT(4, value); } }
        public int SoCMND { get { return GetINT(5); } set { SetINT(5, value); } }
        public DateTime Ngaysinh { get { return GetDT(6); } set { SetDT(6, value); } }
        public string Noisinh { get { return GetSTR(7); } set { SetSTR(7, value); } }
        public string Dienthoai { get { return GetSTR(8); } set { SetSTR(8, value); } }
        public string Dantoc { get { return GetSTR(9); } set { SetSTR(9, value); } }
        public string Tongiao { get { return GetSTR(10); } set { SetSTR(10, value); } }
        public string Ghichu { get { return GetSTR(11); } set { SetSTR(11, value); } }
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
