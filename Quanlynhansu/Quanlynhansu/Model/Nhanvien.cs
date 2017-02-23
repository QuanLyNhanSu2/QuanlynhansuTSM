using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
   

    public class Nhanvien
    {
        public int Manhanvien { get; set; }
        public string Hoten { get; set; }
        public bool Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public int Dienthoai { get; set; }
        public string Hokhau { get; set; }
        public string Choohiennay { get; set; }
        public int SoBHYT { get; set; }
        public int SotheATM { get; set; }
        public string Dantoc { get; set; }
        public string Tongiao { get; set; }
        public int Maphongban { get; set; }
        public string Chucvu { get; set; }
        public int SoCMND { get; set; }
        public string Ghichu { get; set; }
        public Nhanvien()
        {
        }

        public Nhanvien(
                        int _Manhanvien,
                        string _Hoten,
                        bool _Gioitinh,
                        DateTime _Ngaysinh,
                        string _Noisinh,
                        int _Dienthoai,
                        string _Hokhau,
                        string _Choohiennay,
                        int _SoBHYT,
                        int _SotheATM,
                        string _Dantoc,
                        string _Tongiao,
                        int _Maphongban,
                        string _Chucvu,
                        int _SoCMND,
                        string _Ghichu
                        )
        {
            this.Manhanvien = _Manhanvien;
            this.Hoten = _Hoten;
            this.Gioitinh = _Gioitinh;
            this.Ngaysinh = _Ngaysinh;
            this.Noisinh = _Noisinh;
            this.Dienthoai = _Dienthoai;
            this.Hokhau = _Hokhau;
            this.Choohiennay = _Choohiennay;
            this.SoBHYT = _SoBHYT;
            this.SotheATM = _SotheATM;
            this.Dantoc = _Dantoc;
            this.Tongiao = _Tongiao;
            this.Maphongban = _Maphongban;
            this.Chucvu = _Chucvu;
            this.SoCMND = _SoCMND;
            this.Ghichu = _Ghichu;
        }

    }
}
