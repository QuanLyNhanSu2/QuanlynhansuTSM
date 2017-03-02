namespace Quanlynhansu.Model
{
    public class User
    {
        public string Ten { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public int PhanquyenID { get; set; }

        public User() { }
        public User(string user, string pass)
        {
            this.Taikhoan = user;
            this.Matkhau = pass;
        }
        public User(string ten, string user, string pass, int phanquyenid)
        {
            this.Ten = ten;
            this.Taikhoan = user;
            this.Matkhau = pass;
            this.PhanquyenID = phanquyenid;
        }
    }
}