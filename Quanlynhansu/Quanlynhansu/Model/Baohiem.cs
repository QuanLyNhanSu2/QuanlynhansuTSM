using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
    class Baohiem : ModelBase
    {
        public int BaohiemID { get { return GetINT(0); } set { SetVal(0, value); } }
        public DateTime Ngaycap { get { return GetDT(1); } set { SetVal(1, value); } }
        public DateTime Ngayhethan { get { return GetDT(2); } set { SetVal(2, value); } }
        public string Noicap { get { return GetSTR(3); } set { SetVal(3, value); } }
    }
}
