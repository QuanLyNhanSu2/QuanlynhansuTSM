using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
    class Chucvu : ModelBase
    {
        public int ChucvuID { get { return GetINT(0); } set { SetVal(0, value); } }
        public string Ten { get { return GetSTR(1); } set { SetVal(1, value); } }
    }
}
