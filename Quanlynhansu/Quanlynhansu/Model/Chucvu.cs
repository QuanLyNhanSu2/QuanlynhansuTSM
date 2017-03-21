using QuanLyNhanSu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    class Chucvu:ModelBase
    {
        public int ChucvuID { get { return GetINT(0); } set { SetINT(0, value); } }
        public string Tenchucvu { get { return GetSTR(1); } set { SetSTR(1, value); } }
        public string Mota { get { return GetSTR(2); } set { SetSTR(2, value); } }
        public Chucvu()
        {
            MaxPosModelField = 2;
        }
        protected override Type TransferType()
        {
            return this.GetType();
        }
    }
}
