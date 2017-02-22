using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
    class Phongban : ModelBase
    {
        public int PhongbanID { get { return GetINT(0); } set { SetVal(0, value); } }
        public string Ten { get { return GetSTR(1); } set { SetVal(1, value); } }
        public string Dienthoai { get { return GetSTR(2); } set { SetVal(2, value); } }
        public string Fax { get { return GetSTR(3); } set { SetVal(3, value); } }
    }
}
