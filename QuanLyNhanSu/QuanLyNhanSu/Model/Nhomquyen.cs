using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Nhomquyen:ModelBase
    {
        public int NhomquyenID { get { return GetINT(0); } set { SetINT(0, value); } }
        public string Tenquyen { get { return GetSTR(1); } set { SetSTR(1, value); } }
        public Nhomquyen()
        {
            MaxPosModelField = 1;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
