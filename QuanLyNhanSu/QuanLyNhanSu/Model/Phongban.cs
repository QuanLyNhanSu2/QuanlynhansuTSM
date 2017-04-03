using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Phongban: ModelBase
    {
        public int PhongbanID { get { return GetINT(0); } set { SetINT(0, value); } }
        public string Tenphongban { get { return GetSTR(1); } set { SetSTR(1, value); } }
        public string Diachi { get { return GetSTR(2); } set { SetSTR(2, value); } }
        public string Dienthoai { get { return GetSTR(3); } set { SetSTR(3, value); } }
        public Phongban()
        {
            MaxPosModelField = 3;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
