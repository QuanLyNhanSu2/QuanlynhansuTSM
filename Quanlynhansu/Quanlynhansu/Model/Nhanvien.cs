using System;

namespace Quanlynhansu.Model
{
    class Nhanvien : ModelBase
    {
        public int NhanvienID { get { return GetINT(0); } set { SetVal(0, value); } }
        public string Ten { get { return GetSTR(1); } set { SetVal(1, value); } }
        public string Gioitinh { get { return GetSTR(2); } set { SetVal(2, value); } }
        public int SoCMND { get { return GetINT(3); } set { SetVal(3, value); } }
        public DateTime Ngaysinh { get { return GetDT(4); } set { SetVal(4, value); } }
        public string Noisinh { get { return GetSTR(5); } set { SetVal(5, value); } }
        public string Dienthoai { get { return GetSTR(6); } set { SetVal(6, value); } }
        public string Hokhau { get { return GetSTR(7); } set { SetVal(7, value); } }
        public string Choohiennay { get { return GetSTR(8); } set { SetVal(8, value); } }
        public DateTime Ngayvaolam { get { return GetDT(9); } set { SetVal(9, value); } }
        public string SotheATM { get { return GetSTR(10); } set { SetVal(10, value); } }
        public int DantocID { get { return GetINT(11); } set { SetVal(11, value); } }
        public int TongiaoID { get { return GetINT(12); } set { SetVal(12, value); } }
        public int PhongbanID { get { return GetINT(13); } set { SetVal(13, value); } }
        public int ChucvuID { get { return GetINT(14); } set { SetVal(14, value); } }
        public int BaohiemID { get { return GetINT(15); } set { SetVal(15, value); } }
        public string Ghichu { get { return GetSTR(16); } set { SetVal(16, value); } }
    }
}
