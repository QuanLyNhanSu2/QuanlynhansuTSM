using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Taikhoan:ModelBase
    {

        public int TaikhoanID { get { return GetINT(0); } set { SetINT(0, value); } }
        public int NhomquyenID { get { return GetINT(1); } set { SetINT(1, value); } }
        public string Tentaikhoan { get { return GetSTR(2); } set { SetSTR(2, value); } }
        public string Matkhau { get { return GetSTR(3); } set { SetSTR(3, value); } }
        public Taikhoan()
        {
            MaxPosModelField = 3;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
