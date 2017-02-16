using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
    class NhanVien : ModelBase
    {
        public string Ten { get { return GetSTR(1); } set { SetVal(1, value); } }
        public string GioiTinh { get { return GetSTR(2); } set { SetVal(2, value); } }
        public int SoCMND { get { return GetINT(3); } set { SetVal(3, value); } }
        public DateTime NgaySinh { get { return GetDT(4); } set { SetVal(4, value); } }
        public string NoiSinh { get { return GetSTR(5); } set { SetVal(5, value); } }
        public string DienThoai { get { return GetSTR(6); } set { SetVal(6, value); } }
        public string HoKhau { get { return GetSTR(7); } set { SetVal(7, value); } }
        public string ChoOHienNay { get { return GetSTR(8); } set { SetVal(8, value); } }
        public DateTime NgayVaoLam { get { return GetDT(9); } set { SetVal(9, value); } }
        public string SoBHYT { get { return GetSTR(10); } set { SetVal(10, value); } }
        public string SoTheATM { get { return GetSTR(11); } set { SetVal(11, value); } }
        public int DanTocID { get { return GetINT(12); } set { SetVal(12, value); } }
        public int TonGiaoID { get { return GetINT(13); } set { SetVal(13, value); } }
        public string PhongBan { get { return GetSTR(14); } set { SetVal(14, value); } }
        public int ChucVuID { get { return GetINT(15); } set { SetVal(15, value); } }
    }
}
